using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string username = uname.Text;
            string password = pword.Text;

            string query = "SELECT COUNT(1) FROM Accounts WHERE Username=@Username AND Password=@Password";

            // Use 'using' statements to ensure proper disposal of SQL objects
            using (SqlConnection connection = new SqlConnection(sharedAppData.conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password); // Use hashed password here

                    try
                    {
                        connection.Open();
                        // ExecuteScalar retrieves a single value (the count)
                        int count = (int)command.ExecuteScalar();

                        if (count == 1)
                        {
                            MessageBox.Show("Login successful!");
                            // Proceed to the main application form
                            metaspace ms = new metaspace();
                            ms.Show();
                            this.Hide(); // Hide the login form
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message);
                    }
                }
            }
        }
    }
}
