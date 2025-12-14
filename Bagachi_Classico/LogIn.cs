using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bagachi_Classico
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // 1. Basic validation
            if (string.IsNullOrWhiteSpace(uname.Text) || string.IsNullOrWhiteSpace(pword.Text))
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            string query = @"
                SELECT Id, Username, Email, Bio, isActive, HighScore, Win, Lose
                FROM Accounts
                WHERE Username = @Username AND Password = @Password";

            try
            {
                using (SqlConnection connection = new SqlConnection(sharedAppData.conString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Username", SqlDbType.VarChar).Value = uname.Text;
                    command.Parameters.Add("@Password", SqlDbType.VarChar).Value = pword.Text;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Invalid username or password.");
                            return;
                        }

                        // 2. Load user data into sharedAppData
                        sharedAppData.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        sharedAppData.Username = reader.GetString(reader.GetOrdinal("Username"));
                        sharedAppData.Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? string.Empty : reader.GetString(reader.GetOrdinal("Email"));
                        sharedAppData.Bio = reader.IsDBNull(reader.GetOrdinal("Bio")) ? string.Empty : reader.GetString(reader.GetOrdinal("Bio"));
                        sharedAppData.IsActive = reader.GetBoolean(reader.GetOrdinal("isActive"));
                        sharedAppData.HighScorePoints = reader.GetInt32(reader.GetOrdinal("HighScore"));
                        sharedAppData.Wins = reader.GetInt32(reader.GetOrdinal("Win"));
                        sharedAppData.Loses = reader.GetInt32(reader.GetOrdinal("Lose"));
                    }

                    // 3. Set all other accounts to isActive = false
                    string deactivateQuery = "UPDATE Accounts SET isActive = 0 WHERE Id <> @UserId";
                    using (SqlCommand deactivateCmd = new SqlCommand(deactivateQuery, connection))
                    {
                        deactivateCmd.Parameters.Add("@UserId", SqlDbType.Int).Value = sharedAppData.Id;
                        deactivateCmd.ExecuteNonQuery();
                    }

                    // 4. Activate this account
                    string activateQuery = "UPDATE Accounts SET isActive = 1 WHERE Id = @UserId";
                    using (SqlCommand activateCmd = new SqlCommand(activateQuery, connection))
                    {
                        activateCmd.Parameters.Add("@UserId", SqlDbType.Int).Value = sharedAppData.Id;
                        activateCmd.ExecuteNonQuery();
                    }

                    // 5. Notify user and open game
                    MessageBox.Show($"Login successful! Welcome, {sharedAppData.Username}");
                    metaspace ms = new metaspace();
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
    }
}
