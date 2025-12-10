using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bagachi_Classico
{
    public partial class metaspace : Form
    {
        int counter = 0;
        int action = 0;
        public metaspace()
        {
            InitializeComponent();
            P2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case 0:
                    switch (counter)
                    {
                        case 0:
                            P1.Image = Bagachi_Classico.Properties.Resources.Idle1;
                            break;
                        case 1:
                            P1.Image = Bagachi_Classico.Properties.Resources.Idle2;
                            break;
                        case 2:
                            P1.Image = Bagachi_Classico.Properties.Resources.Idle3;
                            break;
                        case 3:
                            P1.Image = Bagachi_Classico.Properties.Resources.Idle4;
                            break;
                        default:
                            P1.Image = Bagachi_Classico.Properties.Resources.Idle1;
                            counter = 0;
                            break;
                    }
                    break;
                case 1:
                    switch (counter)
                    {
                        case 0:
                            P1.Image = Bagachi_Classico.Properties.Resources.attack1;
                            break;
                        case 1:
                            P1.Image = Bagachi_Classico.Properties.Resources.attack2;
                            break;
                        case 2:
                            P1.Image = Bagachi_Classico.Properties.Resources.attack3;
                            break;
                        case 3:
                            P1.Image = Bagachi_Classico.Properties.Resources.attack4;
                            break;
                        default:
                            P1.Image = Bagachi_Classico.Properties.Resources.attack1;
                            counter = 0;
                            action = 0;
                            break;
                    }
                    break;
                case 2:
                    switch (counter)
                    {
                        case 0:
                            P1.Image = Bagachi_Classico.Properties.Resources.block1;
                            break;
                        case 1:
                            P1.Image = Bagachi_Classico.Properties.Resources.block2;
                            break;
                        case 2:
                            P1.Image = Bagachi_Classico.Properties.Resources.block3;
                            break;
                        case 3:
                            P1.Image = Bagachi_Classico.Properties.Resources.block4;
                            break;
                        default:
                            P1.Image = Bagachi_Classico.Properties.Resources.block1;
                            counter = 0;
                            action = 0;
                            break;
                    }
                    break;
                case 3:
                    switch (counter)
                    {
                        case 0:
                            P1.Image = Bagachi_Classico.Properties.Resources.heal1;
                            break;
                        case 1:
                            P1.Image = Bagachi_Classico.Properties.Resources.heal2;
                            break;
                        case 2:
                            P1.Image = Bagachi_Classico.Properties.Resources.heal3;
                            break;
                        case 3:
                            P1.Image = Bagachi_Classico.Properties.Resources.heal4;
                            break;
                        default:
                            P1.Image = Bagachi_Classico.Properties.Resources.heal1;
                            counter = 0;
                            action = 0;
                            break;
                    }
                    break;
            }
            switch (counter)
            {
                case 0:
                    P2.Image = Bagachi_Classico.Properties.Resources.Idle1;
                    break;
                case 1:
                    P2.Image = Bagachi_Classico.Properties.Resources.Idle2;
                    break;
                case 2:
                    P2.Image = Bagachi_Classico.Properties.Resources.Idle3;
                    break;
                case 3:
                    P2.Image = Bagachi_Classico.Properties.Resources.Idle4;
                    break;
                default:
                    P2.Image = Bagachi_Classico.Properties.Resources.Idle1;
                    counter = 0;
                    break;
            }
            P2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            counter++;
        }

        private void attack_btn_Click(object sender, EventArgs e)
        {
            action = 1;
            counter = 0;
        }

        private void block_btn_Click(object sender, EventArgs e)
        {
            action = 2;
            counter = 0;
        }

        private void heal_btn_Click(object sender, EventArgs e)
        {
            action = 3;
            counter = 0;
        }
    }
}
