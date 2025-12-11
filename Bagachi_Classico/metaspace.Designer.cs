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
            this.diceTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.spit = new System.Windows.Forms.PictureBox();
            this.dice = new System.Windows.Forms.PictureBox();
            this.P2 = new System.Windows.Forms.PictureBox();
            this.heal_btn = new System.Windows.Forms.PictureBox();
            this.block_btn = new System.Windows.Forms.PictureBox();
            this.attack_btn = new System.Windows.Forms.PictureBox();
            this.P1 = new System.Windows.Forms.PictureBox();
            this.spit2 = new System.Windows.Forms.PictureBox();
            this.coinbar = new System.Windows.Forms.Panel();
            this.coinValue = new System.Windows.Forms.Panel();
            this.coinbar2 = new System.Windows.Forms.Panel();
            this.coinValue2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.spit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heal_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spit2)).BeginInit();
            this.coinbar.SuspendLayout();
            this.coinbar2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // diceTime
            // 
            this.diceTime.Interval = 50;
            this.diceTime.Tick += new System.EventHandler(this.diceTime_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spit
            // 
            this.spit.BackColor = System.Drawing.Color.Transparent;
            this.spit.Image = global::Bagachi_Classico.Properties.Resources.spit1;
            this.spit.Location = new System.Drawing.Point(256, 196);
            this.spit.Name = "spit";
            this.spit.Size = new System.Drawing.Size(300, 20);
            this.spit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spit.TabIndex = 7;
            this.spit.TabStop = false;
            // 
            // dice
            // 
            this.dice.Image = global::Bagachi_Classico.Properties.Resources.dice1;
            this.dice.Location = new System.Drawing.Point(325, 125);
            this.dice.Name = "dice";
            this.dice.Size = new System.Drawing.Size(150, 150);
            this.dice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice.TabIndex = 5;
            this.dice.TabStop = false;
            // 
            // P2
            // 
            this.P2.BackColor = System.Drawing.Color.Transparent;
            this.P2.Image = global::Bagachi_Classico.Properties.Resources.Idle1;
            this.P2.Location = new System.Drawing.Point(562, 98);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(160, 200);
            this.P2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P2.TabIndex = 4;
            this.P2.TabStop = false;
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
            // spit2
            // 
            this.spit2.BackColor = System.Drawing.Color.Transparent;
            this.spit2.Image = global::Bagachi_Classico.Properties.Resources.spit1;
            this.spit2.Location = new System.Drawing.Point(256, 196);
            this.spit2.Name = "spit2";
            this.spit2.Size = new System.Drawing.Size(300, 20);
            this.spit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spit2.TabIndex = 8;
            this.spit2.TabStop = false;
            // 
            // coinbar
            // 
            this.coinbar.BackColor = System.Drawing.Color.Black;
            this.coinbar.Controls.Add(this.coinValue);
            this.coinbar.Location = new System.Drawing.Point(100, 28);
            this.coinbar.Name = "coinbar";
            this.coinbar.Size = new System.Drawing.Size(150, 50);
            this.coinbar.TabIndex = 9;
            // 
            // coinValue
            // 
            this.coinValue.BackColor = System.Drawing.Color.Red;
            this.coinValue.ForeColor = System.Drawing.Color.Transparent;
            this.coinValue.Location = new System.Drawing.Point(0, 0);
            this.coinValue.Name = "coinValue";
            this.coinValue.Size = new System.Drawing.Size(150, 50);
            this.coinValue.TabIndex = 0;
            // 
            // coinbar2
            // 
            this.coinbar2.BackColor = System.Drawing.Color.Black;
            this.coinbar2.Controls.Add(this.coinValue2);
            this.coinbar2.Location = new System.Drawing.Point(562, 28);
            this.coinbar2.Name = "coinbar2";
            this.coinbar2.Size = new System.Drawing.Size(150, 50);
            this.coinbar2.TabIndex = 10;
            // 
            // coinValue2
            // 
            this.coinValue2.BackColor = System.Drawing.Color.Red;
            this.coinValue2.ForeColor = System.Drawing.Color.Transparent;
            this.coinValue2.Location = new System.Drawing.Point(0, 0);
            this.coinValue2.Name = "coinValue2";
            this.coinValue2.Size = new System.Drawing.Size(150, 50);
            this.coinValue2.TabIndex = 0;
            // 
            // metaspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.coinbar2);
            this.Controls.Add(this.coinbar);
            this.Controls.Add(this.spit2);
            this.Controls.Add(this.spit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dice);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.heal_btn);
            this.Controls.Add(this.block_btn);
            this.Controls.Add(this.attack_btn);
            this.Controls.Add(this.P1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "metaspace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "metaspace";
            ((System.ComponentModel.ISupportInitialize)(this.spit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heal_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spit2)).EndInit();
            this.coinbar.ResumeLayout(false);
            this.coinbar2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox P1;
        private System.Windows.Forms.PictureBox attack_btn;
        private System.Windows.Forms.PictureBox block_btn;
        private System.Windows.Forms.PictureBox heal_btn;
        private System.Windows.Forms.PictureBox P2;
        private System.Windows.Forms.PictureBox dice;
        private System.Windows.Forms.Timer diceTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox spit;
        private System.Windows.Forms.PictureBox spit2;
        private System.Windows.Forms.Panel coinbar;
        private System.Windows.Forms.Panel coinValue;
        private System.Windows.Forms.Panel coinbar2;
        private System.Windows.Forms.Panel coinValue2;
    }
}