using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Questões
{
    public partial class Questao4 : Form
    {
        long numero1, numero2;

        public Questao4()
        {
            InitializeComponent();
        }

        private void txtNumero2_Leave(object sender, EventArgs e)
        {
            numero2 = long.Parse(txtNumero2.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long temp = numero1;
            numero1 = numero2;
            numero2 = temp;

            MessageBox.Show($" O valor do número 1 é: {numero1}, o valor do número 2 é { numero2 }");
        }

        private void txtNumero1_Leave(object sender, EventArgs e)
        {
            numero1 = long.Parse(txtNumero1.Text);
        }

       
    }
}
