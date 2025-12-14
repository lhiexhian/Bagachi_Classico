namespace Bagachi_Classico
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.edit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.losee = new System.Windows.Forms.TextBox();
            this.winn = new System.Windows.Forms.TextBox();
            this.highScore = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Bio = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // edit
            // 
            this.edit.BackgroundImage = global::Bagachi_Classico.Properties.Resources.actionBTN;
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit.Location = new System.Drawing.Point(381, 178);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(50, 50);
            this.edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.edit.TabIndex = 10;
            this.edit.TabStop = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Bagachi_Classico.Properties.Resources.plate;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.losee);
            this.panel1.Controls.Add(this.winn);
            this.panel1.Controls.Add(this.highScore);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(125, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 300);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bagachi_Classico.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(66, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(182, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "LOSE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(114, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "WIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(35, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "HIGH";
            // 
            // losee
            // 
            this.losee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.losee.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losee.ForeColor = System.Drawing.SystemColors.Window;
            this.losee.Location = new System.Drawing.Point(170, 142);
            this.losee.Margin = new System.Windows.Forms.Padding(10);
            this.losee.MaximumSize = new System.Drawing.Size(180, 4);
            this.losee.Name = "losee";
            this.losee.Size = new System.Drawing.Size(55, 19);
            this.losee.TabIndex = 5;
            this.losee.Text = "LOSE";
            this.losee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // winn
            // 
            this.winn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.winn.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winn.ForeColor = System.Drawing.SystemColors.Window;
            this.winn.Location = new System.Drawing.Point(100, 142);
            this.winn.Margin = new System.Windows.Forms.Padding(10);
            this.winn.MaximumSize = new System.Drawing.Size(180, 4);
            this.winn.Name = "winn";
            this.winn.Size = new System.Drawing.Size(55, 19);
            this.winn.TabIndex = 4;
            this.winn.Text = "WIN";
            this.winn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // highScore
            // 
            this.highScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.highScore.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScore.ForeColor = System.Drawing.SystemColors.Window;
            this.highScore.Location = new System.Drawing.Point(25, 142);
            this.highScore.Margin = new System.Windows.Forms.Padding(10);
            this.highScore.MaximumSize = new System.Drawing.Size(180, 4);
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(55, 19);
            this.highScore.TabIndex = 1;
            this.highScore.Text = "HIGH";
            this.highScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Bagachi_Classico.Properties.Resources.textField_big;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Controls.Add(this.Bio);
            this.panel4.Location = new System.Drawing.Point(25, 174);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 3;
            // 
            // Bio
            // 
            this.Bio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Bio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bio.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bio.ForeColor = System.Drawing.SystemColors.Window;
            this.Bio.Location = new System.Drawing.Point(5, 7);
            this.Bio.Margin = new System.Windows.Forms.Padding(10);
            this.Bio.MaximumSize = new System.Drawing.Size(190, 80);
            this.Bio.Multiline = true;
            this.Bio.Name = "Bio";
            this.Bio.ReadOnly = true;
            this.Bio.Size = new System.Drawing.Size(190, 80);
            this.Bio.TabIndex = 0;
            this.Bio.Text = "etwywy";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Bagachi_Classico.Properties.Resources.textField;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.Email);
            this.panel3.Location = new System.Drawing.Point(25, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 30);
            this.panel3.TabIndex = 2;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Email.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.Window;
            this.Email.Location = new System.Drawing.Point(10, 10);
            this.Email.Margin = new System.Windows.Forms.Padding(10);
            this.Email.MaximumSize = new System.Drawing.Size(180, 0);
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Size = new System.Drawing.Size(180, 12);
            this.Email.TabIndex = 0;
            this.Email.Text = "etwywy";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Bagachi_Classico.Properties.Resources.textField;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.Username);
            this.panel2.Location = new System.Drawing.Point(25, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 30);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.Window;
            this.Username.Location = new System.Drawing.Point(10, 10);
            this.Username.Margin = new System.Windows.Forms.Padding(10);
            this.Username.MaximumSize = new System.Drawing.Size(180, 0);
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Size = new System.Drawing.Size(180, 12);
            this.Username.TabIndex = 0;
            this.Username.Text = "etwywy";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.edit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Bio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox losee;
        private System.Windows.Forms.TextBox winn;
        private System.Windows.Forms.TextBox highScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox edit;
    }
}