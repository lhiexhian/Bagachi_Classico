using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bagachi_Classico
{
    public partial class MainMenu : Form
    {
        int i = 0;
        bool flip = false;
        public MainMenu()
        {
            InitializeComponent();
            timer1.Start();
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    title.Image = Properties.Resources.title1;
                    bagachi.Image = Properties.Resources.Idle1;
                    break;
                case 1:
                    title.Image = Properties.Resources.title2;
                    bagachi.Image = Properties.Resources.Idle2;
                    break;
                case 2:
                    title.Image = Properties.Resources.title3;
                    bagachi.Image = Properties.Resources.Idle3;
                    break;
                case 3:
                    title.Image = Properties.Resources.title4;
                    bagachi.Image = Properties.Resources.Idle4;
                    break;
                case 4:
                    title.Image = Properties.Resources.title1;
                    bagachi.Image = Properties.Resources.Idle1;
                    i = 1;
                    flip = !flip;
                    break;
            }
            if (flip)
                bagachi.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            i++;
        }

        private void play_MouseHover(object sender, EventArgs e)
        {
            play.BackgroundImage = Properties.Resources.button_hover;
        }

        private void profile_MouseHover(object sender, EventArgs e)
        {
            profile.BackgroundImage = Properties.Resources.button_hover;
        }

        private void profile_MouseLeave(object sender, EventArgs e)
        {
            profile.BackgroundImage = Properties.Resources.button;
        }

        private void play_MouseLeave(object sender, EventArgs e)
        {
            play.BackgroundImage = Properties.Resources.button;
        }

        private void play_Click(object sender, EventArgs e)
        {
            metaspace ms = new metaspace();
            ms.Show();
            this.Close();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            Profile pf = new Profile();
            pf.ShowDialog();
        }
    }
}
