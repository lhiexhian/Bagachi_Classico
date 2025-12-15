using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bagachi_Classico
{
    public partial class LogIn : Form
    {
        bool isLogin = true;
        public LogIn()
        {
            InitializeComponent();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Trim inputs up front
            string username = uname.Text?.Trim() ?? string.Empty;
            string password = pword.Text?.Trim() ?? string.Empty;
            string cpassword = cPWord.Text?.Trim() ?? string.Empty;
            string emailAddr = email.Text?.Trim() ?? string.Empty;

            // Basic presence checks for both flows
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password is required.");
                return;
            }

            // Shared validation
            if (!IsValidUsername(username))
            {
                MessageBox.Show("Username must be 3-20 characters and contain only letters, digits or underscores.");
                return;
            }

            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password must be at least 6 characters.");
                return;
            }
            else if (!isLogin)
            {
                // Registration-specific validation
                if (password != cpassword)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(emailAddr) && !IsValidEmail(emailAddr) && !isLogin)
            {
                MessageBox.Show("Email address is not valid.");
                return;
            }

            if (isLogin)
            {
                // Login process
                string query = @"
                SELECT Id, Username, Email, Bio, isActive, HighScore, Win, Lose
                FROM Accounts
                WHERE Username = @Username AND Password = @Password";

                try
                {
                    using (SqlConnection connection = new SqlConnection(sharedAppData.conString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = username;
                        command.Parameters.Add("@Password", SqlDbType.VarChar, 255).Value = password;

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Invalid username or password.");
                                return;
                            }

                            // Load user data into sharedAppData
                            sharedAppData.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                            sharedAppData.Username = reader.GetString(reader.GetOrdinal("Username"));
                            sharedAppData.Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? string.Empty : reader.GetString(reader.GetOrdinal("Email"));
                            sharedAppData.Bio = reader.IsDBNull(reader.GetOrdinal("Bio")) ? string.Empty : reader.GetString(reader.GetOrdinal("Bio"));
                            sharedAppData.IsActive = reader.GetBoolean(reader.GetOrdinal("isActive"));
                            sharedAppData.hscore = reader.IsDBNull(reader.GetOrdinal("HighScore")) ? 0 : reader.GetInt32(reader.GetOrdinal("HighScore"));
                            sharedAppData.Wins = reader.IsDBNull(reader.GetOrdinal("Win")) ? 0 : reader.GetInt32(reader.GetOrdinal("Win"));
                            sharedAppData.Loses = reader.IsDBNull(reader.GetOrdinal("Lose")) ? 0 : reader.GetInt32(reader.GetOrdinal("Lose"));
                        }

                        // Set all other accounts to isActive = false
                        string deactivateQuery = "UPDATE Accounts SET isActive = 0 WHERE Id <> @UserId";
                        using (SqlCommand deactivateCmd = new SqlCommand(deactivateQuery, connection))
                        {
                            deactivateCmd.Parameters.Add("@UserId", SqlDbType.Int).Value = sharedAppData.Id;
                            deactivateCmd.ExecuteNonQuery();
                        }

                        // Activate this account
                        string activateQuery = "UPDATE Accounts SET isActive = 1 WHERE Id = @UserId";
                        using (SqlCommand activateCmd = new SqlCommand(activateQuery, connection))
                        {
                            activateCmd.Parameters.Add("@UserId", SqlDbType.Int).Value = sharedAppData.Id;
                            activateCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show($"Login successful! Welcome, {sharedAppData.Username}");
                        MainMenu ms = new MainMenu();
                        ms.Show();
                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error: " + ex.Message);
                }
            }
            else
            {
                // Registration process
                try
                {
                    using (SqlConnection con = new SqlConnection(sharedAppData.conString))
                    {
                        con.Open();

                        // Check username uniqueness
                        using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(1) FROM Accounts WHERE Username = @Username", con))
                        {
                            checkCmd.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = username;
                            int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                            if (exists > 0)
                            {
                                MessageBox.Show("Username already exists. Please choose another.");
                                return;
                            }
                        }

                        // Insert new user. Assume Id is identity (auto-increment) in DB.
                        string insertSql = "INSERT INTO Accounts (Username, Password, Email, isActive, HighScore, Win, Lose) VALUES (@Username, @Password, @Email, @IsActive, @hscore, @win, @lose); SELECT SCOPE_IDENTITY();";
                        int newId;
                        using (SqlCommand insertCmd = new SqlCommand(insertSql, con))
                        {
                            insertCmd.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = username;
                            insertCmd.Parameters.Add("@Password", SqlDbType.VarChar, 255).Value = password;
                            insertCmd.Parameters.Add("@Email", SqlDbType.VarChar, 255).Value = (object)emailAddr ?? DBNull.Value;
                            insertCmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = 1;
                            insertCmd.Parameters.Add("@hscore", SqlDbType.Int).Value = 0;
                            insertCmd.Parameters.Add("@win", SqlDbType.Int).Value = 0;
                            insertCmd.Parameters.Add("@lose", SqlDbType.Int).Value = 0; // activate new user immediately

                            object result = insertCmd.ExecuteScalar();
                            if (result == null || result == DBNull.Value)
                            {
                                MessageBox.Show("Registration failed. Please try again.");
                                return;
                            }

                            // SCOPE_IDENTITY returns decimal when Id is numeric; convert safely
                            newId = Convert.ToInt32(result);
                        }

                        // Load user data into sharedAppData
                        string selectSql = @"
                        SELECT Id, Username, Email, Bio, isActive, HighScore, Win, Lose
                        FROM Accounts
                        WHERE Id = @Id";
                        using (SqlCommand selectCmd = new SqlCommand(selectSql, con))
                        {
                            selectCmd.Parameters.Add("@Id", SqlDbType.Int).Value = newId;
                            using (SqlDataReader reader = selectCmd.ExecuteReader())
                            {
                                if (!reader.Read())
                                {
                                    MessageBox.Show("Unable to retrieve newly created account.");
                                    return;
                                }

                                sharedAppData.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                                sharedAppData.Username = reader.GetString(reader.GetOrdinal("Username"));
                                sharedAppData.Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? string.Empty : reader.GetString(reader.GetOrdinal("Email"));
                                sharedAppData.Bio = reader.IsDBNull(reader.GetOrdinal("Bio")) ? string.Empty : reader.GetString(reader.GetOrdinal("Bio"));
                                sharedAppData.IsActive = reader.GetBoolean(reader.GetOrdinal("isActive"));
                                sharedAppData.hscore = reader.IsDBNull(reader.GetOrdinal("HighScore")) ? 0 : reader.GetInt32(reader.GetOrdinal("HighScore"));
                                sharedAppData.Wins = reader.IsDBNull(reader.GetOrdinal("Win")) ? 0 : reader.GetInt32(reader.GetOrdinal("Win"));
                                sharedAppData.Loses = reader.IsDBNull(reader.GetOrdinal("Lose")) ? 0 : reader.GetInt32(reader.GetOrdinal("Lose"));
                            }
                        }

                        // Deactivate other accounts and ensure this one is active
                        string deactivateQuery = "UPDATE Accounts SET isActive = 0 WHERE Id <> @UserId";
                        using (SqlCommand deactivateCmd = new SqlCommand(deactivateQuery, con))
                        {
                            deactivateCmd.Parameters.Add("@UserId", SqlDbType.Int).Value = sharedAppData.Id;
                            deactivateCmd.ExecuteNonQuery();
                        }

                        string activateQuery = "UPDATE Accounts SET isActive = 1 WHERE Id = @UserId";
                        using (SqlCommand activateCmd = new SqlCommand(activateQuery, con))
                        {
                            activateCmd.Parameters.Add("@UserId", SqlDbType.Int).Value = sharedAppData.Id;
                            activateCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Registration successful. You are now logged in.");
                        MainMenu ms = new MainMenu();
                        ms.Show();
                        this.Close();
                    }
                }
                catch (SqlException ex) when (ex.Number == 2627)
                {
                    MessageBox.Show("Username already exists. Please choose another.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error: " + ex.Message);
                }
            }
        }

        private void switcher_Click(object sender, EventArgs e)
        {
            if (isLogin)
            {
                switcher.Image = Properties.Resources.login2;
                toggleLabel.Text = "Already have an account? Log In";
                Title.Image = Properties.Resources.sign_up;
                panel.Visible = true;
                panel3.Visible = true;
                isLogin = !isLogin;
            }
            else
            {
                switcher.Image = Properties.Resources.sign_up2;
                toggleLabel.Text = "Don't have an account? Register";
                Title.Image = Properties.Resources.Login;
                panel.Visible = false;
                panel3.Visible = false;
                isLogin = !isLogin;
            }
            
        }

        // Validation helpers
        private bool IsValidUsername(string username)
        {
            if (string.IsNullOrEmpty(username)) return false;
            if (username.Length < 3 || username.Length > 20) return false;
            return Regex.IsMatch(username, @"^[A-Za-z0-9_]+$");
        }

        private bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            return password.Length >= 6;
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;
            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

    }
}
