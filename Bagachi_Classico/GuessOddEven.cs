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
    public partial class GuessOddEven : Form
    {
        bool isEven;
        public GuessOddEven()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            isEven = false;
            sharedAppData.guess = isEven;
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            isEven = true;
            sharedAppData.guess = isEven;
            this.Close();
        }
    }
}
