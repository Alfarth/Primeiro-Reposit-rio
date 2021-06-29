using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Questões
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void questão1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Questao_1 F_questao_1 = new F_Questao_1();
            F_questao_1.ShowDialog();
        }

        private void questão2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCotacaoDolar cotacaoDolar = new txtCotacaoDolar();
            cotacaoDolar.ShowDialog();
        }

        private void questão3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Questao3 questao3 = new Questao3();
            questao3.ShowDialog();


        }

        private void questão4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Questao4 questao4 = new Questao4();
            questao4.ShowDialog();
        }
    }
}
