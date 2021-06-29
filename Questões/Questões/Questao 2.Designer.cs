
namespace Questões
{
    partial class txtCotacaoDolar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCotacaoDólar = new System.Windows.Forms.MaskedTextBox();
            this.txtDolar = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCotacaoDólar
            // 
            this.txtCotacaoDólar.Location = new System.Drawing.Point(47, 263);
            this.txtCotacaoDólar.Name = "txtCotacaoDólar";
            this.txtCotacaoDólar.Size = new System.Drawing.Size(157, 27);
            this.txtCotacaoDólar.TabIndex = 0;
            this.txtCotacaoDólar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCotacaoDólar_MaskInputRejected);
            this.txtCotacaoDólar.Leave += new System.EventHandler(this.txtCotacaoDólar_Leave);
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(293, 263);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(204, 27);
            this.txtDolar.TabIndex = 2;
            this.txtDolar.Leave += new System.EventHandler(this.txtDolar_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(571, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 29);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(102, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cálculo para cotação do dólar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(47, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 55);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cotação do Dólar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(293, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 55);
            this.label3.TabIndex = 9;
            this.label3.Text = "Informe um valor em Dólar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(571, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 55);
            this.label4.TabIndex = 10;
            this.label4.Text = "Conversão em real";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtCotacaoDólar);
            this.Name = "txtCotacaoDolar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCotacaoDólar;
        private System.Windows.Forms.MaskedTextBox txtDolar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

