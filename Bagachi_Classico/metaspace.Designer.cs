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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.coinValue2 = new System.Windows.Forms.PictureBox();
            this.coinValue = new System.Windows.Forms.PictureBox();
            this.dice = new System.Windows.Forms.PictureBox();
            this.P2 = new System.Windows.Forms.PictureBox();
            this.heal_btn = new System.Windows.Forms.PictureBox();
            this.block_btn = new System.Windows.Forms.PictureBox();
            this.attack_btn = new System.Windows.Forms.PictureBox();
            this.P1 = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.flickerTimerP1 = new System.Windows.Forms.Timer(this.components);
            this.flickerTimerP2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.coinValue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heal_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(256, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 24);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // coinValue2
            // 
            this.coinValue2.Image = global::Bagachi_Classico.Properties.Resources.health1;
            this.coinValue2.Location = new System.Drawing.Point(551, 27);
            this.coinValue2.Name = "coinValue2";
            this.coinValue2.Size = new System.Drawing.Size(180, 60);
            this.coinValue2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coinValue2.TabIndex = 12;
            this.coinValue2.TabStop = false;
            // 
            // coinValue
            // 
            this.coinValue.Image = global::Bagachi_Classico.Properties.Resources.health1;
            this.coinValue.Location = new System.Drawing.Point(79, 27);
            this.coinValue.Name = "coinValue";
            this.coinValue.Size = new System.Drawing.Size(180, 60);
            this.coinValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coinValue.TabIndex = 11;
            this.coinValue.TabStop = false;
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
            this.heal_btn.BackgroundImage = global::Bagachi_Classico.Properties.Resources.button;
            this.heal_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.heal_btn.Image = global::Bagachi_Classico.Properties.Resources.heal;
            this.heal_btn.Location = new System.Drawing.Point(562, 323);
            this.heal_btn.Name = "heal_btn";
            this.heal_btn.Size = new System.Drawing.Size(200, 100);
            this.heal_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heal_btn.TabIndex = 3;
            this.heal_btn.TabStop = false;
            this.heal_btn.Click += new System.EventHandler(this.heal_btn_Click);
            this.heal_btn.MouseLeave += new System.EventHandler(this.heal_btn_MouseLeave);
            this.heal_btn.MouseHover += new System.EventHandler(this.heal_btn_MouseHover);
            // 
            // block_btn
            // 
            this.block_btn.BackgroundImage = global::Bagachi_Classico.Properties.Resources.button;
            this.block_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.block_btn.Image = global::Bagachi_Classico.Properties.Resources.block;
            this.block_btn.Location = new System.Drawing.Point(304, 323);
            this.block_btn.Name = "block_btn";
            this.block_btn.Size = new System.Drawing.Size(200, 100);
            this.block_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.block_btn.TabIndex = 2;
            this.block_btn.TabStop = false;
            this.block_btn.Click += new System.EventHandler(this.block_btn_Click);
            this.block_btn.MouseLeave += new System.EventHandler(this.block_btn_MouseLeave);
            this.block_btn.MouseHover += new System.EventHandler(this.block_btn_MouseHover);
            // 
            // attack_btn
            // 
            this.attack_btn.BackgroundImage = global::Bagachi_Classico.Properties.Resources.button;
            this.attack_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.attack_btn.Image = global::Bagachi_Classico.Properties.Resources.attack;
            this.attack_btn.Location = new System.Drawing.Point(50, 323);
            this.attack_btn.Name = "attack_btn";
            this.attack_btn.Size = new System.Drawing.Size(200, 100);
            this.attack_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.attack_btn.TabIndex = 1;
            this.attack_btn.TabStop = false;
            this.attack_btn.Click += new System.EventHandler(this.attack_btn_Click);
            this.attack_btn.MouseLeave += new System.EventHandler(this.atk_btn_MouseLeave);
            this.attack_btn.MouseHover += new System.EventHandler(this.attack_btn_MouseHover);
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
            // metaspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.coinValue2);
            this.Controls.Add(this.coinValue);
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
            this.Load += new System.EventHandler(this.metaspace_Load);
            this.Shown += new System.EventHandler(this.metaspace_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.coinValue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heal_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).EndInit();
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
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox coinValue;
        private System.Windows.Forms.PictureBox coinValue2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer flickerTimerP1;
        private System.Windows.Forms.Timer flickerTimerP2;
    }
}