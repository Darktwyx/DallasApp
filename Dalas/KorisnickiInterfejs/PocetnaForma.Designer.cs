
namespace KorisnickiInterfejs
{
    partial class PocetnaForma
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
            this.pROIZVODIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mATERIJAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIPMATERIJALAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIPPROIZVODAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROIZVODIToolStripMenuItem,
            this.mATERIJAToolStripMenuItem,
            this.tIPMATERIJALAToolStripMenuItem,
            this.tIPPROIZVODAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pROIZVODIToolStripMenuItem
            // 
            this.pROIZVODIToolStripMenuItem.Name = "pROIZVODIToolStripMenuItem";
            this.pROIZVODIToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.pROIZVODIToolStripMenuItem.Text = "PROIZVODI";
            this.pROIZVODIToolStripMenuItem.Click += new System.EventHandler(this.pROIZVODIToolStripMenuItem_Click);
            // 
            // mATERIJAToolStripMenuItem
            // 
            this.mATERIJAToolStripMenuItem.Name = "mATERIJAToolStripMenuItem";
            this.mATERIJAToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.mATERIJAToolStripMenuItem.Text = "MATERIJAL";
            this.mATERIJAToolStripMenuItem.Click += new System.EventHandler(this.mATERIJAToolStripMenuItem_Click);
            // 
            // tIPMATERIJALAToolStripMenuItem
            // 
            this.tIPMATERIJALAToolStripMenuItem.Name = "tIPMATERIJALAToolStripMenuItem";
            this.tIPMATERIJALAToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.tIPMATERIJALAToolStripMenuItem.Text = "TIP MATERIJALA";
            this.tIPMATERIJALAToolStripMenuItem.Click += new System.EventHandler(this.tIPMATERIJALAToolStripMenuItem_Click);
            // 
            // tIPPROIZVODAToolStripMenuItem
            // 
            this.tIPPROIZVODAToolStripMenuItem.Name = "tIPPROIZVODAToolStripMenuItem";
            this.tIPPROIZVODAToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.tIPPROIZVODAToolStripMenuItem.Text = "TIP PROIZVODA";
            this.tIPPROIZVODAToolStripMenuItem.Click += new System.EventHandler(this.tIPPROIZVODAToolStripMenuItem_Click);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PocetnaForma";
            this.Text = "Pocetna forma";
            this.Load += new System.EventHandler(this.PocetnaForma_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pROIZVODIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mATERIJAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tIPMATERIJALAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tIPPROIZVODAToolStripMenuItem;
    }
}

