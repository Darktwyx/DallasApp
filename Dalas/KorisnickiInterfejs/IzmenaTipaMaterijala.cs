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
    public partial class IzmenaTipaMaterijala : Form
    {
        public IzmenaTipaMaterijala()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.izmeniTipMaterijala(txtNaziv))
            {
                new PregledProizvoda().ShowDialog();
                this.Close();
            }
        }

        private void IzmenaTipaMaterijala_Load(object sender, EventArgs e)
        {
            KontrolerKI.popuniPoljaTipMaterijala(txtNaziv);
        }
    }
}
