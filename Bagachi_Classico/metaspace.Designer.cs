namespace Bagachi_Classico
{
    partial class metaspace
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
            this.heal_btn = new System.Windows.Forms.PictureBox();
            this.block_btn = new System.Windows.Forms.PictureBox();
            this.attack_btn = new System.Windows.Forms.PictureBox();
            this.P1 = new System.Windows.Forms.PictureBox();
            this.P2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.heal_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // heal_btn
            // 
            this.heal_btn.Image = global::Bagachi_Classico.Properties.Resources.heal;
            this.heal_btn.Location = new System.Drawing.Point(502, 306);
            this.heal_btn.Name = "heal_btn";
            this.heal_btn.Size = new System.Drawing.Size(200, 100);
            this.heal_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heal_btn.TabIndex = 3;
            this.heal_btn.TabStop = false;
            this.heal_btn.Click += new System.EventHandler(this.heal_btn_Click);
            // 
            // block_btn
            // 
            this.block_btn.Image = global::Bagachi_Classico.Properties.Resources.block;
            this.block_btn.Location = new System.Drawing.Point(296, 306);
            this.block_btn.Name = "block_btn";
            this.block_btn.Size = new System.Drawing.Size(200, 100);
            this.block_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.block_btn.TabIndex = 2;
            this.block_btn.TabStop = false;
            this.block_btn.Click += new System.EventHandler(this.block_btn_Click);
            // 
            // attack_btn
            // 
            this.attack_btn.Image = global::Bagachi_Classico.Properties.Resources.attack;
            this.attack_btn.Location = new System.Drawing.Point(90, 306);
            this.attack_btn.Name = "attack_btn";
            this.attack_btn.Size = new System.Drawing.Size(200, 100);
            this.attack_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.attack_btn.TabIndex = 1;
            this.attack_btn.TabStop = false;
            this.attack_btn.Click += new System.EventHandler(this.attack_btn_Click);
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.Color.Transparent;
            this.P1.Image = global::Bagachi_Classico.Properties.Resources.Idle1;
            this.P1.Location = new System.Drawing.Point(90, 100);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(160, 200);
            this.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P1.TabIndex = 0;
            this.P1.TabStop = false;
            // 
            // P2
            // 
            this.P2.BackColor = System.Drawing.Color.Transparent;
            this.P2.Image = global::Bagachi_Classico.Properties.Resources.Idle1;
            this.P2.Location = new System.Drawing.Point(542, 100);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(160, 200);
            this.P2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P2.TabIndex = 4;
            this.P2.TabStop = false;
            // 
            // metaspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.heal_btn);
            this.Controls.Add(this.block_btn);
            this.Controls.Add(this.attack_btn);
            this.Controls.Add(this.P1);
            this.Name = "metaspace";
            this.Text = "metaspace";
            ((System.ComponentModel.ISupportInitialize)(this.heal_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox P1;
        private System.Windows.Forms.PictureBox attack_btn;
        private System.Windows.Forms.PictureBox block_btn;
        private System.Windows.Forms.PictureBox heal_btn;
        private System.Windows.Forms.PictureBox P2;
    }
}