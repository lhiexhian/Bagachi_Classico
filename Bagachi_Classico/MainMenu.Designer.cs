namespace Bagachi_Classico
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bagachi = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.PictureBox();
            this.profile = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bagachi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 125;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bagachi
            // 
            this.bagachi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bagachi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bagachi.Image = global::Bagachi_Classico.Properties.Resources.Idle1;
            this.bagachi.Location = new System.Drawing.Point(466, 0);
            this.bagachi.Name = "bagachi";
            this.bagachi.Size = new System.Drawing.Size(320, 400);
            this.bagachi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bagachi.TabIndex = 3;
            this.bagachi.TabStop = false;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.title.Image = global::Bagachi_Classico.Properties.Resources.title1;
            this.title.Location = new System.Drawing.Point(50, 94);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(400, 200);
            this.title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.title.TabIndex = 2;
            this.title.TabStop = false;
            // 
            // profile
            // 
            this.profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.profile.BackgroundImage = global::Bagachi_Classico.Properties.Resources.button;
            this.profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile.Image = global::Bagachi_Classico.Properties.Resources.profile;
            this.profile.Location = new System.Drawing.Point(260, 300);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(200, 100);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile.TabIndex = 1;
            this.profile.TabStop = false;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            this.profile.MouseLeave += new System.EventHandler(this.profile_MouseLeave);
            this.profile.MouseHover += new System.EventHandler(this.profile_MouseHover);
            // 
            // play
            // 
            this.play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.play.BackgroundImage = global::Bagachi_Classico.Properties.Resources.button;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.Image = global::Bagachi_Classico.Properties.Resources.play;
            this.play.Location = new System.Drawing.Point(50, 300);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(200, 100);
            this.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.play.TabIndex = 0;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            this.play.MouseLeave += new System.EventHandler(this.play_MouseLeave);
            this.play.MouseHover += new System.EventHandler(this.play_MouseHover);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bagachi);
            this.Controls.Add(this.title);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.play);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.bagachi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox profile;
        private System.Windows.Forms.PictureBox title;
        private System.Windows.Forms.PictureBox bagachi;
        private System.Windows.Forms.Timer timer1;
    }
}