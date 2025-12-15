namespace Bagachi_Classico
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.toggleLabel = new System.Windows.Forms.Label();
            this.switcher = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.email = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.cPWord = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uname = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.switcher)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
            this.SuspendLayout();
            // 
            // toggleLabel
            // 
            this.toggleLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toggleLabel.Location = new System.Drawing.Point(63, 330);
            this.toggleLabel.Name = "toggleLabel";
            this.toggleLabel.Size = new System.Drawing.Size(146, 16);
            this.toggleLabel.TabIndex = 6;
            this.toggleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // switcher
            // 
            this.switcher.BackgroundImage = global::Bagachi_Classico.Properties.Resources.button;
            this.switcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.switcher.Image = global::Bagachi_Classico.Properties.Resources.sign_up2;
            this.switcher.Location = new System.Drawing.Point(76, 349);
            this.switcher.Name = "switcher";
            this.switcher.Size = new System.Drawing.Size(100, 50);
            this.switcher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.switcher.TabIndex = 5;
            this.switcher.TabStop = false;
            this.switcher.Click += new System.EventHandler(this.switcher_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Bagachi_Classico.Properties.Resources.textField;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.email);
            this.panel3.Location = new System.Drawing.Point(66, 268);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 40);
            this.panel3.TabIndex = 3;
            this.panel3.Visible = false;
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.Info;
            this.email.Location = new System.Drawing.Point(10, 10);
            this.email.Margin = new System.Windows.Forms.Padding(10);
            this.email.MaximumSize = new System.Drawing.Size(280, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(280, 15);
            this.email.TabIndex = 1;
            this.email.Text = "Email";
            this.email.WordWrap = false;
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::Bagachi_Classico.Properties.Resources.textField;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel.Controls.Add(this.cPWord);
            this.panel.Location = new System.Drawing.Point(66, 223);
            this.panel.Margin = new System.Windows.Forms.Padding(10);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(300, 40);
            this.panel.TabIndex = 4;
            this.panel.Visible = false;
            // 
            // cPWord
            // 
            this.cPWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cPWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.cPWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cPWord.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPWord.ForeColor = System.Drawing.SystemColors.Info;
            this.cPWord.Location = new System.Drawing.Point(10, 10);
            this.cPWord.Margin = new System.Windows.Forms.Padding(10);
            this.cPWord.MaximumSize = new System.Drawing.Size(280, 0);
            this.cPWord.Name = "cPWord";
            this.cPWord.PasswordChar = '*';
            this.cPWord.Size = new System.Drawing.Size(280, 15);
            this.cPWord.TabIndex = 1;
            this.cPWord.Text = "password";
            this.cPWord.WordWrap = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(216, 349);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Bagachi_Classico.Properties.Resources.textField;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.pword);
            this.panel2.Location = new System.Drawing.Point(66, 178);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 40);
            this.panel2.TabIndex = 3;
            // 
            // pword
            // 
            this.pword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.pword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pword.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pword.ForeColor = System.Drawing.SystemColors.Info;
            this.pword.Location = new System.Drawing.Point(10, 10);
            this.pword.Margin = new System.Windows.Forms.Padding(10);
            this.pword.MaximumSize = new System.Drawing.Size(280, 0);
            this.pword.Name = "pword";
            this.pword.PasswordChar = '*';
            this.pword.Size = new System.Drawing.Size(280, 15);
            this.pword.TabIndex = 1;
            this.pword.Text = "password";
            this.pword.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Bagachi_Classico.Properties.Resources.textField;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.uname);
            this.panel1.Location = new System.Drawing.Point(66, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 40);
            this.panel1.TabIndex = 2;
            // 
            // uname
            // 
            this.uname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.uname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uname.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.ForeColor = System.Drawing.SystemColors.Info;
            this.uname.Location = new System.Drawing.Point(10, 10);
            this.uname.Margin = new System.Windows.Forms.Padding(10);
            this.uname.MaximumSize = new System.Drawing.Size(280, 0);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(280, 15);
            this.uname.TabIndex = 1;
            this.uname.Text = "Username";
            this.uname.WordWrap = false;
            // 
            // Title
            // 
            this.Title.Image = global::Bagachi_Classico.Properties.Resources.Login;
            this.Title.Location = new System.Drawing.Point(117, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(200, 70);
            this.Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Title.TabIndex = 0;
            this.Title.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.toggleLabel);
            this.Controls.Add(this.switcher);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.switcher)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Title;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox pword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox cPWord;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.PictureBox switcher;
        private System.Windows.Forms.Label toggleLabel;
    }
}