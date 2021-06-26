using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questões
{
    public partial class txtCotacaoDolar : Form
    {
        double Cotacao_dolar, dolar;




        public txtCotacaoDolar()
        {
            InitializeComponent();
        }

        private void txtDolar_Leave(object sender, EventArgs e)
        {
            dolar = double.Parse(txtDolar.Text);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double conversao;
            conversao = dolar * Cotacao_dolar;

            MessageBox.Show($"A conversão do dólar para o real é:" + conversao);
        }

        private void txtCotacaoDólar_Leave(object sender, EventArgs e)
        {
            Cotacao_dolar = double.Parse(txtCotacaoDólar.Text);
        }



        

       
    }
}
