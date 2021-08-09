
namespace Academia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModalidade = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModalidade
            // 
            this.btnModalidade.Location = new System.Drawing.Point(32, 86);
            this.btnModalidade.Name = "btnModalidade";
            this.btnModalidade.Size = new System.Drawing.Size(75, 23);
            this.btnModalidade.TabIndex = 0;
            this.btnModalidade.Text = "Modalidade";
            this.btnModalidade.UseVisualStyleBackColor = true;
            this.btnModalidade.Click += new System.EventHandler(this.btnModalidade_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.Location = new System.Drawing.Point(220, 86);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAluno.TabIndex = 1;
            this.btnAluno.Text = "Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // btnProfessor
            // 
            this.btnProfessor.Location = new System.Drawing.Point(127, 86);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnProfessor.TabIndex = 2;
            this.btnProfessor.Text = "Professor";
            this.btnProfessor.UseVisualStyleBackColor = true;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 198);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.btnModalidade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModalidade;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnProfessor;
    }
}

