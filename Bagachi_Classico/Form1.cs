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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Shown(object sender, EventArgs e)
        {
            // Show the metaspace form on startup
            //metaspace ms = new metaspace();

            LogIn ms = new LogIn();
            this.Hide();
            ms.Show();
        }
    }
}
