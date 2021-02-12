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
    public partial class IzmenaProizvoda : Form
    {
        public IzmenaProizvoda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KontrolerKI.proizvod.Status = Domen.Status.Edit;
            if (KontrolerKI.izmeniProzivod(txtNaziv,txtDuzina,txtSirina,txtVisina,txtAktuelnaCena,txtMaterijal,txtTipMaterijala,cmbJM,cmbMat,cmbTP)) this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KontrolerKI.proizvod.Status = Domen.Status.Error2;
            if (KontrolerKI.izmeniProzivod(txtNaziv, txtDuzina, txtSirina, txtVisina, txtAktuelnaCena, txtMaterijal, txtTipMaterijala, cmbJM, cmbMat, cmbTP)) this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KontrolerKI.proizvod.Status = Domen.Status.Error3;
            if (KontrolerKI.izmeniProzivod(txtNaziv, txtDuzina, txtSirina, txtVisina, txtAktuelnaCena, txtMaterijal, txtTipMaterijala, cmbJM, cmbMat, cmbTP)) this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KontrolerKI.proizvod.Status = Domen.Status.Error1;
            if (KontrolerKI.izmeniProzivod(txtNaziv, txtDuzina, txtSirina, txtVisina, txtAktuelnaCena, txtMaterijal, txtTipMaterijala, cmbJM, cmbMat, cmbTP)) this.Close();
        }

        private void IzmenaProizvoda_Load(object sender, EventArgs e)
        {
            KontrolerKI.popuniCmbZaProizvod(cmbJM, cmbMat, cmbTP);
            KontrolerKI.popuniPoljaProizvoda(txtNaziv, txtDuzina, txtSirina, txtVisina, txtAktuelnaCena, txtMaterijal, txtTipMaterijala, cmbJM, cmbMat, cmbTP);
        }
    }
}
