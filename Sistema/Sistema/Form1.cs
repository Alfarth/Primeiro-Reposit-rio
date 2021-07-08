using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Dominio;

namespace Sistema
{
    public partial class Form1 : Form

    {
        Academia academia;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            academia.AdicionaAluno(txtNome.Text);
            AtualizaLista();
        }

        private void AtualizaLista()
        {
            lista.Items.Clear();
            foreach (var academia in academia.Alunos)
            {
                lista.Items.Add(academia);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            academia.ExcluirAluno(txtCPF.Text);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            academia.Pagar(txtCPF.Text);
        }
    }
}
