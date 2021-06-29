
namespace Questões
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.questõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questão1 = new System.Windows.Forms.ToolStripMenuItem();
            this.questão2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questão3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questão4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questão5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // questõesToolStripMenuItem
            // 
            this.questõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questão1,
            this.questão2ToolStripMenuItem,
            this.questão3ToolStripMenuItem,
            this.questão4ToolStripMenuItem,
            this.questão5ToolStripMenuItem});
            this.questõesToolStripMenuItem.Name = "questõesToolStripMenuItem";
            this.questõesToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.questõesToolStripMenuItem.Text = "Questões";
            // 
            // questão1
            // 
            this.questão1.Name = "questão1";
            this.questão1.Size = new System.Drawing.Size(159, 26);
            this.questão1.Text = "Questão 1";
            this.questão1.Click += new System.EventHandler(this.questão1ToolStripMenuItem_Click);
            // 
            // questão2ToolStripMenuItem
            // 
            this.questão2ToolStripMenuItem.Name = "questão2ToolStripMenuItem";
            this.questão2ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.questão2ToolStripMenuItem.Text = "Questão 2";
            this.questão2ToolStripMenuItem.Click += new System.EventHandler(this.questão2ToolStripMenuItem_Click);
            // 
            // questão3ToolStripMenuItem
            // 
            this.questão3ToolStripMenuItem.Name = "questão3ToolStripMenuItem";
            this.questão3ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.questão3ToolStripMenuItem.Text = "Questão 3";
            this.questão3ToolStripMenuItem.Click += new System.EventHandler(this.questão3ToolStripMenuItem_Click);
            // 
            // questão4ToolStripMenuItem
            // 
            this.questão4ToolStripMenuItem.Name = "questão4ToolStripMenuItem";
            this.questão4ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.questão4ToolStripMenuItem.Text = "Questão 4";
            this.questão4ToolStripMenuItem.Click += new System.EventHandler(this.questão4ToolStripMenuItem_Click);
            // 
            // questão5ToolStripMenuItem
            // 
            this.questão5ToolStripMenuItem.Name = "questão5ToolStripMenuItem";
            this.questão5ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.questão5ToolStripMenuItem.Text = "Questão 5";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(80, 225);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(366, 20);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.Text = "Clique em \"questões\" e selecione a questão desejada!";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(585, 520);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem questõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questão1;
        private System.Windows.Forms.ToolStripMenuItem questão2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questão3ToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripMenuItem questão4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questão5ToolStripMenuItem;
    }
}