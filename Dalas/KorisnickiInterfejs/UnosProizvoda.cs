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
    public partial class UnosProizvoda : Form
    {
        public UnosProizvoda()
        {
            InitializeComponent();
        }

        private void UnosProizvoda_Load(object sender, EventArgs e)
        {
            KontrolerKI.popuniCmbZaProizvod(cmbJM, cmbMat, cmbTP);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.sacuvajProizvod(txtNaziv, txtDuzina, txtSirina, txtVisina, cmbJM, cmbMat, cmbTP)) this.Close();
        }
    }
}
