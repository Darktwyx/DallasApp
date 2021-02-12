
namespace KorisnickiInterfejs
{
    partial class PregledDelovaZaIzmenu
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
            this.dgvMaterijal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaterijal
            // 
            this.dgvMaterijal.AllowUserToAddRows = false;
            this.dgvMaterijal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterijal.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMaterijal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterijal.Location = new System.Drawing.Point(12, 34);
            this.dgvMaterijal.Name = "dgvMaterijal";
            this.dgvMaterijal.ReadOnly = true;
            this.dgvMaterijal.Size = new System.Drawing.Size(467, 250);
            this.dgvMaterijal.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "DELOVI PROIZVODA";
            // 
            // PregledDelovaZaIzmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 304);
            this.Controls.Add(this.dgvMaterijal);
            this.Controls.Add(this.label1);
            this.Name = "PregledDelovaZaIzmenu";
            this.Text = "Prikaz delova za izmenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterijal;
        private System.Windows.Forms.Label label1;
    }
}