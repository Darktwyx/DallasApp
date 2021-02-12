
namespace KorisnickiInterfejs
{
    partial class PregledCena
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
            this.gbCena = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatumC = new System.Windows.Forms.DateTimePicker();
            this.txtIznosC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCene = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.gbCena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCene)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCena
            // 
            this.gbCena.Controls.Add(this.button3);
            this.gbCena.Controls.Add(this.button2);
            this.gbCena.Controls.Add(this.button1);
            this.gbCena.Controls.Add(this.label3);
            this.gbCena.Controls.Add(this.dtpDatumC);
            this.gbCena.Controls.Add(this.txtIznosC);
            this.gbCena.Controls.Add(this.label2);
            this.gbCena.Controls.Add(this.label1);
            this.gbCena.Controls.Add(this.dgvCene);
            this.gbCena.Location = new System.Drawing.Point(12, 10);
            this.gbCena.Name = "gbCena";
            this.gbCena.Size = new System.Drawing.Size(522, 227);
            this.gbCena.TabIndex = 1;
            this.gbCena.TabStop = false;
            this.gbCena.Text = "Cene proizvoda";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(336, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 41);
            this.button3.TabIndex = 26;
            this.button3.Text = "Obrisi cenu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(336, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 41);
            this.button2.TabIndex = 25;
            this.button2.Text = "Izmeni cenu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(336, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 41);
            this.button1.TabIndex = 24;
            this.button1.Text = "Dodaj cenu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "RSD";
            // 
            // dtpDatumC
            // 
            this.dtpDatumC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumC.Location = new System.Drawing.Point(386, 19);
            this.dtpDatumC.Name = "dtpDatumC";
            this.dtpDatumC.Size = new System.Drawing.Size(125, 20);
            this.dtpDatumC.TabIndex = 18;
            // 
            // txtIznosC
            // 
            this.txtIznosC.Location = new System.Drawing.Point(386, 42);
            this.txtIznosC.Name = "txtIznosC";
            this.txtIznosC.Size = new System.Drawing.Size(86, 20);
            this.txtIznosC.TabIndex = 17;
            this.txtIznosC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Iznos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Datum:";
            // 
            // dgvCene
            // 
            this.dgvCene.AllowUserToAddRows = false;
            this.dgvCene.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCene.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCene.Location = new System.Drawing.Point(12, 19);
            this.dgvCene.Name = "dgvCene";
            this.dgvCene.Size = new System.Drawing.Size(306, 195);
            this.dgvCene.TabIndex = 0;
            this.dgvCene.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCene_CellClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(24, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(499, 41);
            this.button4.TabIndex = 27;
            this.button4.Text = "Sacuvaj promene";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PregledCena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 302);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.gbCena);
            this.Name = "PregledCena";
            this.Text = "Pregled cena";
            this.Load += new System.EventHandler(this.PregledCena_Load);
            this.gbCena.ResumeLayout(false);
            this.gbCena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCena;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatumC;
        private System.Windows.Forms.TextBox txtIznosC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCene;
        private System.Windows.Forms.Button button4;
    }
}