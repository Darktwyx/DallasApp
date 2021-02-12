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
    public partial class PregledTipovaMaterijala : Form
    {
        public PregledTipovaMaterijala()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.odaberitipMaterijala(dgvTipMaterijala))             
            {
                this.Hide();
                new IzmenaTipaMaterijala().ShowDialog();
                KontrolerKI.PretraziTipoveMaterijala(dgvTipMaterijala, txtUslov);
                this.Show();
            }
        }

        private void txtUslov_TextChanged(object sender, EventArgs e)
        {
            KontrolerKI.PretraziTipoveMaterijala(dgvTipMaterijala, txtUslov);
        }

        private void PregledTipovaMaterijala_Load(object sender, EventArgs e)
        {
            KontrolerKI.PretraziTipoveMaterijala(dgvTipMaterijala, txtUslov);

        }
    }
}
