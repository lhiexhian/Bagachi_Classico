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
            this.Close();
        }

        private void gameOver_Shown(object sender, EventArgs e)
        {

            timer.Text = $"ELAPSED TIME: {sharedAppData.time}";
            label2.Text = sharedAppData.winner;
        }
    }
}
