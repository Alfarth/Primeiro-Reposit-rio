using Academia.Dominio;
using Academia.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class FrmProfessor : Form
    {
        Professor professor = new Professor();
        RepositorioProfessor repositorioProfessor = new RepositorioProfessor();
        public FrmProfessor()
        {
            InitializeComponent();
        }

        private void FrmProfessor_Load(object sender, EventArgs e)
        {
            using (var db = new AplicacaoDBContext())
            {
                professorBindingSource.DataSource = db.Professores.ToList();
                // txtNome.Text = ""
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                return;
            }

            var result = MessageBox.Show("aviso", "confirma?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == result)
            {
                professor = new Professor();
                professor.Nome = txtNome.Text;
                professorBindingSource.Add(professor);
                professorBindingSource.MoveLast();

                if (repositorioProfessor.Adicionar(professor) > 0)
                {
                    dgvProfessor.Refresh();
                    MessageBox.Show($"Categoria {professor.Nome} salva com sucesso", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Professor {professor.Nome} não pode ser salva.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                professor = new Professor();
                txtNome.DataBindings.Clear();
                txtNome.DataBindings.Add(new Binding("Text", professor, "Nome"));
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(professor.Nome))
            {
                return;
            }

            var result = MessageBox.Show("confirma?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            professor = professorBindingSource.Current as Professor;
            professor.Nome = txtNome.Text;
            if (DialogResult.Yes == result)
            {
                if (repositorioProfessor.Atualizar(professor) > 0)
                {
                    dgvProfessor.Refresh();
                    MessageBox.Show($"Categoria {professor.Nome} atualizada com sucesso", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Professor {professor.Nome} não pode ser atualizada.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("confirma?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (repositorioProfessor.Excluir(professor) > 0)
            {
                professorBindingSource.Remove(professor);
                dgvProfessor.Refresh();
                MessageBox.Show($"Categoria {professor.Nome} excluida com sucesso", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Professor {professor.Nome} não pode ser excluida.", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProfessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (professorBindingSource.Current != null)
            {
                professor = professorBindingSource.Current as Professor;
                txtNome.Text = professor.Nome;
            }
        }
    }
}
    
