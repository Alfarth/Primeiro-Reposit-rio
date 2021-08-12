using Academia.Dominio;
using Academia.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class FrmModalidade : Form
    {

        Modalidade modalidade = new Modalidade();
        RepositorioModalidade repositorioModalidade = new RepositorioModalidade();
        public FrmModalidade()
        {
            InitializeComponent();
        }

        private void FrmModalidade_Load(object sender, EventArgs e)
        {
            using (var db = new AplicacaoDBContext())
            {
                modalidadeBindingSource.DataSource = db.Modalidades.ToList();
               // txtNome.Text = ""
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                return;
            }
            
            var result = MessageBox.Show("aviso", "confirma?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            
            if (DialogResult.Yes == result)
            {
                modalidade = new Modalidade();
                modalidade.Nome = txtNome.Text;
                modalidadeBindingSource.Add(modalidade);
                modalidadeBindingSource.MoveLast();

                if (repositorioModalidade.Adicionar(modalidade) > 0)
                {
                    dgvModalidade.Refresh();
                    MessageBox.Show($"Categoria {modalidade.Nome} salva com sucesso", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Modalidade {modalidade.Nome} não pode ser salva.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                modalidade = new Modalidade();
                txtNome.DataBindings.Clear();
                txtNome.DataBindings.Add(new Binding("Text", modalidade, "Nome"));
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(modalidade.Nome))
            {
                return;
            }

            var result = MessageBox.Show("confirma?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            modalidade = modalidadeBindingSource.Current as Modalidade;
            modalidade.Nome = txtNome.Text;
            if (DialogResult.Yes == result)
            {
                if (repositorioModalidade.Atualizar(modalidade) > 0)
                {
                    dgvModalidade.Refresh();
                    MessageBox.Show($"Categoria {modalidade.Nome} atualizada com sucesso", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Modalidade {modalidade.Nome} não pode ser atualizada.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("confirma?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (repositorioModalidade.Excluir(modalidade) > 0)
            {
                modalidadeBindingSource.Remove(modalidade);
                dgvModalidade.Refresh();
                MessageBox.Show($"Categoria {modalidade.Nome} excluida com sucesso", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Modalidade {modalidade.Nome} não pode ser excluida.", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvModalidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modalidadeBindingSource.Current != null)
            {
                modalidade = modalidadeBindingSource.Current as Modalidade;
                txtNome.Text = modalidade.Nome;
            }
        }
    }
}
