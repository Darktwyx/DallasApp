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
    public partial class PregledProizvoda : Form
    {
        public PregledProizvoda()
        {
            InitializeComponent();
        }

        private void txtUslov_TextChanged(object sender, EventArgs e)
        {
            KontrolerKI.PretraziProizvode(dgvProizvod, txtUslov);
        }

        private void PregledProizvoda_Load(object sender, EventArgs e)
        {
            KontrolerKI.PretraziProizvode(dgvProizvod, txtUslov);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UnosProizvoda().ShowDialog();
            KontrolerKI.PretraziProizvode(dgvProizvod, txtUslov);
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            KontrolerKI.odaberiProizvod(dgvProizvod);
            new IzmenaProizvoda().ShowDialog();
            KontrolerKI.PretraziProizvode(dgvProizvod, txtUslov);
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();           
            KontrolerKI.odaberiProizvod(dgvProizvod);
            KontrolerKI.obrisiProizvod();
            KontrolerKI.PretraziProizvode(dgvProizvod, txtUslov);
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            KontrolerKI.odaberiProizvod(dgvProizvod);
            new PregledCena().ShowDialog();
            KontrolerKI.PretraziProizvode(dgvProizvod, txtUslov);
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            KontrolerKI.odaberiProizvod(dgvProizvod);
            new PregledDelova().ShowDialog();
            KontrolerKI.PretraziProizvode(dgvProizvod, txtUslov);
            this.Show();
        }
    }
}
