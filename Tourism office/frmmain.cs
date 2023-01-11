using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourism_office
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsignin f1 = new frmsignin();
            f1.ShowDialog();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsignup f1= new frmsignup();
            f1.ShowDialog();
        }
    }
}
