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
    public partial class frmsignin : Form
    {
        public frmsignin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmmain f1=new frmmain();
            f1.ShowDialog();
        }
    }
}
