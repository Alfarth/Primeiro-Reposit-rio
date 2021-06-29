
namespace Questões
{
    partial class Questao4
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(108, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe um número";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(174, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Troca de valores";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(108, 241);
            this.txtNumero1.Mask = "00000000000000000";
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(165, 27);
            this.txtNumero1.TabIndex = 2;
            this.txtNumero1.ValidatingType = typeof(int);
            this.txtNumero1.Leave += new System.EventHandler(this.txtNumero1_Leave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(492, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "Informe outro número";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(492, 241);
            this.txtNumero2.Mask = "00000000000000000";
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(165, 27);
            this.txtNumero2.TabIndex = 4;
            this.txtNumero2.ValidatingType = typeof(int);
            this.txtNumero2.Leave += new System.EventHandler(this.txtNumero2_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(286, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Fazer a troca de valores";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Questao4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Questao4";
            this.Text = "Questao4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtNumero1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtNumero2;
        private System.Windows.Forms.Button button1;
    }
}