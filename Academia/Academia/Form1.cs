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
    public partial class Form1 : Form
    {
        FrmModalidade frmModalidade;
        FrmProfessor frmProfessor;
        FrmAluno frmAluno;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModalidade_Click(object sender, EventArgs e)
        {
            using (var frmModalidade = new FrmModalidade())
            {
                frmModalidade.ShowDialog();
            }
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            using (var frmProfessor = new FrmProfessor())
            {
                frmProfessor.ShowDialog();
            }
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            using (var frmAluno = new FrmAluno())
            {
                frmAluno.ShowDialog();
            }
        }
    }
}
