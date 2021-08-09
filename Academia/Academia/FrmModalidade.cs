using Academia.Dominio;
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
        public FrmModalidade()
        {
            InitializeComponent();
        }

        private void FrmModalidade_Load(object sender, EventArgs e)
        {
            using (var db = new AplicacaoDBContext())
            {
                modalidadeBindingSource.DataSource = db.Modalidades.ToList();
                txtNome.DataBindings.Add(new Binding("Text", modalidade, "Nome"));
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(modalidade.Nome))
            {
                return;
            }
            var result = MessageBox.Show("aviso", "confirma?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
            modalidadeBindingSource.Add(modalidade);
            modalidadeBindingSource.MoveLast();
            modalidade = modalidadeBindingSource.Current as Modalidade;
            

                using (var db = new AplicacaoDBContext())
                {
                    if (db.Entry<Modalidade>(modalidade).State == System.Data.Entity.EntityState.Detached)
                        db.Set<Modalidade>().Attach(modalidade);

                    db.Entry<Modalidade>(modalidade).State = System.Data.Entity.EntityState.Added;
                    if (db.SaveChanges() >0)
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
                }
            }

            modalidade = new Modalidade();
            txtNome.DataBindings.Clear();
            txtNome.DataBindings.Add(new Binding("Text", modalidade, "Nome"));
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            using (var db = new AplicacaoDBContext())
            {          
                db.Entry<Modalidade>(modalidade).State = EntityState.Modified;
                if (db.SaveChanges() > 0)
                {
                    dgvModalidade.Refresh();
                    MessageBox.Show($"Categoria {modalidade.Nome} alterado", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show($"Modalidade {modalidade.Nome} não pode ser salva.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void dgvModalidade_SelectionChanged(object sender, EventArgs e)
        {

            if (modalidadeBindingSource.Current == null)
            {
                modalidade = modalidadeBindingSource.Current as Modalidade;
                txtNome.DataBindings.Clear();
                txtNome.DataBindings.Add(new Binding("Text", modalidade, "Nome"));
            }
            
        }
    }
}
