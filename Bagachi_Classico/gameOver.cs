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
    public partial class gameOver : Form
    {
        public gameOver()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {
            metaspace ms = new metaspace();
            ms.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }

        private void gameOver_Shown(object sender, EventArgs e)
        {

            Score.Text = $"SCORE: {sharedAppData.score}";
            highScore.Text = $"HIGH SCORE: {sharedAppData.hscore}";
            label2.Text = sharedAppData.winner;
        }
    }
}
