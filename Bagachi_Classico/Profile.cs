using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bagachi_Classico
{
    public partial class Profile : Form
    {

        public Profile()
        {
            InitializeComponent();
            // Load user data from sharedAppData
            Username.Text = sharedAppData.Username;
            Email.Text = sharedAppData.Email;
            Bio.Text = sharedAppData.Bio;
            highScore.Text = $"{sharedAppData.hscore}";
            winn.Text = $"{sharedAppData.Wins}";
            losee.Text = $"{sharedAppData.Loses}";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {
            bool isEditing = Username.ReadOnly;

            Username.ReadOnly = !isEditing;
            Email.ReadOnly = !isEditing;
            Bio.ReadOnly = !isEditing;

            if (!Username.ReadOnly)
            {
                // Enter edit mode
                edit.Image = Properties.Resources.cancel;
                edit.BackgroundImage = Properties.Resources.actionBTN2;
            }
            else
            {
                // Save changes locally
                sharedAppData.Username = Username.Text;
                sharedAppData.Email = Email.Text;
                sharedAppData.Bio = Bio.Text;

                // Save to database
                UpdateProfile();

                edit.Image = Properties.Resources.edit;
                edit.BackgroundImage = Properties.Resources.actionBTN3;
            }
        }


        private void UpdateProfile()
        {
            string query = @"UPDATE Accounts 
                     SET Username = @Username,
                         Email = @Email,
                         Bio = @Bio
                     WHERE Id = @Id"; // BEST OPTION

            using (SqlConnection con = new SqlConnection(sharedAppData.conString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Username", Username.Text);
                cmd.Parameters.AddWithValue("@Email", Email.Text);
                cmd.Parameters.AddWithValue("@Bio", Bio.Text);
                cmd.Parameters.AddWithValue("@Id", sharedAppData.Id); // make sure this exists

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            edit.Image = Properties.Resources.save;
            edit.BackgroundImage = Properties.Resources.actionBTN3;
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            edit.Image = Properties.Resources.save;
            edit.BackgroundImage = Properties.Resources.actionBTN3;

        }

        private void Bio_TextChanged(object sender, EventArgs e)
        {
            edit.Image = Properties.Resources.save;
            edit.BackgroundImage = Properties.Resources.actionBTN3;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }
    }
}
