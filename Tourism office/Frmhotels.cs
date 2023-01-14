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
    public partial class Frmhotels : Form
    {
        public Frmhotels()
        {
            InitializeComponent();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmain f1 = new frmmain();
            f1.ShowDialog();
        }

        private void hotelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmhotels f1 = new Frmhotels();
            f1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Frmhotels_Load(object sender, EventArgs e)
        {

        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsignin f1= new frmsignin();
            f1.ShowDialog();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsignup f1= new frmsignup();
            f1.ShowDialog();
        }

        private void jprdanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmjordan f1= new frmjordan();
            f1.ShowDialog();
        }

        private void egyptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmoman f1 = new frmoman();
            f1.ShowDialog();
        }

        private void lebanonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlebanon f1= new frmlebanon();
            f1.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
