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
    public partial class frmsignup : Form
    {
        public frmsignup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtusername.Text.Length!=0 && txtpassword.Text.Length!=0 && txtconpassword.Text.Length!=0)
            {
              frmmain f1= new frmmain();
            f1.ShowDialog();
            }
            
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsignin f1 = new frmsignin();
            f1.ShowDialog();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmain f1 = new frmmain();
            f1.ShowDialog();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsignup f1 = new frmsignup();
            f1.ShowDialog();
        }

        private void hotelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmhotels f1 = new Frmhotels();
            f1.ShowDialog();
        }

        private void lblsignup_Click(object sender, EventArgs e)
        {
            frmsignin f1 = new frmsignin();
            f1.ShowDialog();
        }

        private void jprdanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmjordan f1= new frmjordan();
            f1.ShowDialog();
        }

        private void egyptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmoman f1= new frmoman();
            f1.ShowDialog();
        }

        private void lebanonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlebanon f1= new frmlebanon();
            f1.ShowDialog();
        }
    }
}
