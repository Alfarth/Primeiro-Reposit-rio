using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnSoma_Click(object sender, EventArgs e)
        {
            int numero1, numero2;
            numero1 = int.Parse(textBox1.Text);
            numero2 = int.Parse(textBox2.Text);
            MessageBox.Show($"{ numero1 + numero2}");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            int numero1, numero2;
            numero1 = int.Parse(textBox1.Text);
            numero2 = int.Parse(textBox2.Text);
            MessageBox.Show($"{ numero1 - numero2}");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            int numero1, numero2;
            numero1 = int.Parse(textBox1.Text);
            numero2 = int.Parse(textBox2.Text);
            MessageBox.Show($"{ numero1 * numero2}");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            int numero1, numero2;
            numero1 = int.Parse(textBox1.Text);
            numero2 = int.Parse(textBox2.Text);
            MessageBox.Show($"{ numero1 / numero2}");
        }

        
    }
}
