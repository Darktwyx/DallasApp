
namespace KorisnickiInterfejs
{
    partial class PregledTipovaMaterijala
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
            this.txtUslov = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvTipMaterijala = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipMaterijala)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUslov
            // 
            this.txtUslov.Location = new System.Drawing.Point(13, 13);
            this.txtUslov.Name = "txtUslov";
            this.txtUslov.Size = new System.Drawing.Size(239, 20);
            this.txtUslov.TabIndex = 49;
            this.txtUslov.TextChanged += new System.EventHandler(this.txtUslov_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "(Pretraga tipova materijala po nazivu)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 46);
            this.button1.TabIndex = 47;
            this.button1.Text = "Izmeni tip materijala";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvTipMaterijala
            // 
            this.dgvTipMaterijala.AllowUserToAddRows = false;
            this.dgvTipMaterijala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipMaterijala.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTipMaterijala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipMaterijala.Location = new System.Drawing.Point(12, 65);
            this.dgvTipMaterijala.Name = "dgvTipMaterijala";
            this.dgvTipMaterijala.ReadOnly = true;
            this.dgvTipMaterijala.Size = new System.Drawing.Size(514, 250);
            this.dgvTipMaterijala.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "TIPOVI MATERIJALA";
            // 
            // PregledTipovaMaterijala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 394);
            this.Controls.Add(this.txtUslov);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTipMaterijala);
            this.Controls.Add(this.label1);
            this.Name = "PregledTipovaMaterijala";
            this.Text = "Pregled tipova materijala";
            this.Load += new System.EventHandler(this.PregledTipovaMaterijala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipMaterijala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUslov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvTipMaterijala;
        private System.Windows.Forms.Label label1;
    }
}