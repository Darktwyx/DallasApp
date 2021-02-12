using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class PregledCena : Form
    {
        public PregledCena()
        {
            InitializeComponent();
        }

        private void PregledCena_Load(object sender, EventArgs e)
        {
            KontrolerKI.popuniPoljaCene(dgvCene);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KontrolerKI.dodajCenu(txtIznosC, dtpDatumC);
            KontrolerKI.obojiGrid(dgvCene);
        }

        private void dgvCene_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KontrolerKI.odaberiCenu(dgvCene, dtpDatumC, txtIznosC);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KontrolerKI.izmeniCenu(txtIznosC, dtpDatumC);
            KontrolerKI.obojiGrid(dgvCene);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KontrolerKI.obrisiCenu(txtIznosC, dtpDatumC);
            KontrolerKI.obojiGrid(dgvCene);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.sacuvajCene()) 
            {
                KontrolerKI.osveziCene(dgvCene);
            }
        }
    }
}
