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
    public partial class PregledDelova : Form
    {
        public PregledDelova()
        {
            InitializeComponent();
        }

        private void PregledDelova_Load(object sender, EventArgs e)
        {
            KontrolerKI.popuniPoljaDelovi(dgvDelovi);
            KontrolerKI.popuniCmbProizvod(cmbProizvod);
        }

        private void dgvDelovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KontrolerKI.odaberiDeo(dgvDelovi, cmbProizvod, txtKolicina);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KontrolerKI.dodajDeo(txtKolicina, cmbProizvod);
            KontrolerKI.obojiGridDelovi(dgvDelovi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KontrolerKI.izmeniDeo(txtKolicina, cmbProizvod);
            KontrolerKI.obojiGridDelovi(dgvDelovi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KontrolerKI.obrisiDeo(txtKolicina, cmbProizvod);
            KontrolerKI.obojiGridDelovi(dgvDelovi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.sacuvajDelove()) 
            {
                KontrolerKI.osveziDelove(dgvDelovi);
            }
        }
    }
}
