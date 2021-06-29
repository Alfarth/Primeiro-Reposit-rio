
namespace Questões
{
    partial class F_Questao_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstoque_minimo = new System.Windows.Forms.MaskedTextBox();
            this.txtEstoque_Maximo = new System.Windows.Forms.MaskedTextBox();
            this.txtEstoque_Medio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(28, 202);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(144, 27);
            this.txtProduto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(548, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estoque Máximo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEstoque_minimo
            // 
            this.txtEstoque_minimo.Location = new System.Drawing.Point(245, 202);
            this.txtEstoque_minimo.Mask = "00000";
            this.txtEstoque_minimo.Name = "txtEstoque_minimo";
            this.txtEstoque_minimo.Size = new System.Drawing.Size(213, 27);
            this.txtEstoque_minimo.TabIndex = 5;
            this.txtEstoque_minimo.ValidatingType = typeof(int);
            this.txtEstoque_minimo.Leave += new System.EventHandler(this.txtEstoque_minimo_Leave);
            // 
            // txtEstoque_Maximo
            // 
            this.txtEstoque_Maximo.Location = new System.Drawing.Point(548, 202);
            this.txtEstoque_Maximo.Mask = "00000";
            this.txtEstoque_Maximo.Name = "txtEstoque_Maximo";
            this.txtEstoque_Maximo.Size = new System.Drawing.Size(208, 27);
            this.txtEstoque_Maximo.TabIndex = 6;
            this.txtEstoque_Maximo.ValidatingType = typeof(int);
            this.txtEstoque_Maximo.Leave += new System.EventHandler(this.txtEstoque_Maximo_Leave);
            // 
            // txtEstoque_Medio
            // 
            this.txtEstoque_Medio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEstoque_Medio.Location = new System.Drawing.Point(284, 345);
            this.txtEstoque_Medio.Name = "txtEstoque_Medio";
            this.txtEstoque_Medio.Size = new System.Drawing.Size(139, 58);
            this.txtEstoque_Medio.TabIndex = 7;
            this.txtEstoque_Medio.Text = "Estoque Médio";
            this.txtEstoque_Medio.UseVisualStyleBackColor = false;
            this.txtEstoque_Medio.Click += new System.EventHandler(this.txtEstoque_Medio_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(131, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(513, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "Calcular estoque Médio de um Produto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(245, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "Estoque Mínimo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_Questao_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEstoque_Medio);
            this.Controls.Add(this.txtEstoque_Maximo);
            this.Controls.Add(this.txtEstoque_minimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label1);
            this.Name = "F_Questao_1";
            this.Text = "F_Questao_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtEstoque_minimo;
        private System.Windows.Forms.MaskedTextBox txtEstoque_Maximo;
        private System.Windows.Forms.Button txtEstoque_Medio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}