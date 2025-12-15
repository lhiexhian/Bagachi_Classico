using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bagachi_Classico
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool hasActiveUser = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(sharedAppData.conString))
                {
                    connection.Open();
                    string query = "SELECT Id, Username, Email, Bio, isActive, HighScore, Win, Lose FROM Accounts WHERE isActive = 1";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Load user data into sharedAppData
                            sharedAppData.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                            sharedAppData.Username = reader.GetString(reader.GetOrdinal("Username"));
                            sharedAppData.Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? string.Empty : reader.GetString(reader.GetOrdinal("Email"));
                            sharedAppData.Bio = reader.IsDBNull(reader.GetOrdinal("Bio")) ? string.Empty : reader.GetString(reader.GetOrdinal("Bio"));
                            sharedAppData.IsActive = reader.GetBoolean(reader.GetOrdinal("isActive"));
                            sharedAppData.hscore = reader.IsDBNull(reader.GetOrdinal("HighScore")) ? 0 : reader.GetInt32(reader.GetOrdinal("HighScore"));
                            sharedAppData.Wins = reader.IsDBNull(reader.GetOrdinal("Win")) ? 0 : reader.GetInt32(reader.GetOrdinal("Win"));
                            sharedAppData.Loses = reader.IsDBNull(reader.GetOrdinal("Lose")) ? 0 : reader.GetInt32(reader.GetOrdinal("Lose"));

                            hasActiveUser = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking active user: " + ex.Message, "Startup error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // fall back to showing login form
            }

            if (hasActiveUser)
            {
                Application.Run(new MainMenu());
            }
            else
            {
                Application.Run(new LogIn());
            }
        }
    }
}