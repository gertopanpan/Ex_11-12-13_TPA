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
    public partial class frmEx11 : Form

    {

        public frmEx11()
        {
            InitializeComponent();
        }
        
        private void frmEx11_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtTabu.Clear();
            txtNum.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            double cont, num, tabuada;
            cont = 1;
            if (double.TryParse(txtNum.Text, out num))
            {

                while (cont != 11)
                {
                    tabuada = num * cont;
                    txtTabu.Text += $"{num} x {cont} = {tabuada} \r\n";
                    cont += 1;
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
                txtNum.Clear();
                txtTabu.Clear();
                txtNum.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {



            double cont, num, tabuada;
            cont = 1;
            if (Double.TryParse(txtNum.Text, out num))
            {
                do
                {

                    tabuada = num * cont;
                    txtTabu.Text += $"{num} x {cont} = {tabuada}\r\n";
                    cont += 1;
                }
                while (cont != 11);

            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
                txtNum.Clear();
                txtTabu.Clear();
                txtNum.Focus();
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            double cont, num, tabuada;
            

            if (double.TryParse(txtNum.Text, out num))
            {

                for (cont = 1; cont <= 10; cont++)
                {
                    tabuada = num * cont;
                    txtTabu.Text += $"{num} x {cont} = {tabuada}\r\n";
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
                txtNum.Clear();
                txtTabu.Clear();
                txtNum.Focus();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
