using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Questões
{
    public partial class F_Questao_1 : Form

    {
        string Produto = "";
        long estoque_minimo = 0;
        long estoque_maximo = 0;
        long estoque_medio = 0;

        public F_Questao_1()
        {
            InitializeComponent();
        }
          private void txtEstoque_minimo_Leave(object sender, EventArgs e)
        {
            estoque_minimo = long.Parse(txtEstoque_minimo.Text);
        }

        private void txtEstoque_Maximo_Leave(object sender, EventArgs e)
        {
            estoque_maximo = long.Parse(txtEstoque_Maximo.Text);
        }

        private void txtEstoque_Medio_Click(object sender, EventArgs e)
        {
            estoque_medio = (estoque_minimo + estoque_maximo) / 2;
            MessageBox.Show($" O estoque médio é: {estoque_medio} ");
        }

       
    }
    
}
