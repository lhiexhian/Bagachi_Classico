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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void main_Shown(object sender, EventArgs e)
        {
            // Show the metaspace form on startup
            //metaspace ms = new metaspace();
            MainMenu ms = new MainMenu();
            //LogIn ms = new LogIn();
            this.Hide();
            ms.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
