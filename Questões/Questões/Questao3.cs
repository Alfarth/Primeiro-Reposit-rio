using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Questões
{
    public partial class Questao3 : Form
    {
        double preco_unitario, comissao;
        long quantidade_vendida;

        public Questao3()
        {
            InitializeComponent();
        }

      

        private void txtPreco_Unitario_Leave(object sender, EventArgs e)
        {
            preco_unitario = double.Parse(txtPreco_Unitario.Text);

        }

        private void txtQuantidade_Vendida_Leave(object sender, EventArgs e)
        {
            quantidade_vendida = long.Parse(txtQuantidade_Vendida.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comissao = (preco_unitario * quantidade_vendida) * 0.05;
            MessageBox.Show($" A comissão será R${comissao}");
        }
    }
}
