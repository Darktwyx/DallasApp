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
    public partial class PregledTipovaProizvoda : Form
    {
        public PregledTipovaProizvoda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.odaberiTipProizvoda(dgvTipProizvoda))
            {
                this.Hide();
                new IzmenaTipaProizvoda().ShowDialog();
                KontrolerKI.PretraziTipoveProizvoda(dgvTipProizvoda, txtUslov);
                this.Show();
            }
        }

        private void txtUslov_TextChanged(object sender, EventArgs e)
        {
            KontrolerKI.PretraziTipoveProizvoda(dgvTipProizvoda, txtUslov);
        }

        private void PregledTipovaProizvoda_Load(object sender, EventArgs e)
        {
            KontrolerKI.PretraziTipoveProizvoda(dgvTipProizvoda, txtUslov);
        }
    }
}
