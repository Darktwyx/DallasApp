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
    public partial class IzmenaMaterijala : Form
    {
        public IzmenaMaterijala()
        {
            InitializeComponent();
        }

        private void IzmenaMaterijala_Load(object sender, EventArgs e)
        {
            KontrolerKI.popuniPoljaMaterijal(txtNaziv, cmbTM);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.izmeniMaterijal(txtNaziv, cmbTM)) 
            {
                new PregledProizvoda().ShowDialog();
                this.Close();
            }
        }
    }
}
