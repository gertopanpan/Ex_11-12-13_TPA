using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_11_12_13_TPA
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void ex11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEx11 ex11 = new frmEx11();
            ex11.Show();
        }

        private void ex12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEx12 Ex12 = new frmEx12();
            Ex12.Show();
        }

        private void ex13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEx13 ex13 = new frmEx13();
            ex13.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
