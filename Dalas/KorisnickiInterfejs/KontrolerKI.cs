using DAL;
using Domen;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public class KontrolerKI
    {
        public static Proizvod proizvod;
        public static Materijal materijal;
        public static TipMaterijala tipMaterijala;
        public static TipProizvoda tipProizvoda;
        public static OsnovnaCena cena;
        public static USastavu deo;

        internal static void popuniPoljaDelovi(DataGridView dgvDelovi)
        {
            try
            {
                dgvDelovi.DataSource = proizvod.SpisakDelova;
            }
            catch (Exception)
            {

                
            }
        }

        internal static void popuniCmbProizvod(ComboBox cmbProizvod)
        {
            cmbProizvod.DataSource = Broker.dajSesiju().VratiProizvode("");
            cmbProizvod.Text = "Odaberite proizvod!";
        }

        internal static bool odaberiMaterijal(DataGridView dgv)
        {
            try
            {
                materijal = (Materijal)dgv.CurrentRow.DataBoundItem;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska!\n"+ex.Message);
                return false;
            }
        }

        internal static void odaberiCenu(DataGridView dgvCene, DateTimePicker dtpDatumC, TextBox txtIznosC)
        {
            try
            {
                cena = (OsnovnaCena)dgvCene.CurrentRow.DataBoundItem;
                dtpDatumC.Value = cena.Datum;
                txtIznosC.Text = cena.Iznos.ToString("N02");
            }
            catch (Exception)
            {

               
            }
        }
        internal static void izmeniCenu(TextBox txtIznosC, DateTimePicker dtpDatumC)
        {
           
            try
            {
                cena.Iznos = Convert.ToDouble(txtIznosC.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Niste ispravno uneli cenu!");
                return;
            }

            cena.Datum = dtpDatumC.Value;

            if (proizvod.IstorijaCena.Where(x => x.Datum.Date == cena.Datum.Date).ToList().Count > 1)
            {
                MessageBox.Show("Uneli ste vec cenu za isti datum!");
                return;
            }

            if (cena.Status != Status.New) cena.Status = Status.Edit;
            txtIznosC.Clear();
            dtpDatumC.Value = DateTime.Now;
            cena = null;
        }

        internal static void osveziCene(DataGridView dgvCene)
        {
            try
            {
                dgvCene.Rows.Clear();
                Broker.dajSesiju().VratiCeneProizvoda(proizvod);
                dgvCene.DataSource = proizvod.IstorijaCena;
            }
            catch (Exception)
            {

               
            }
        }

        internal static bool sacuvajCene()
        {
            try
            {
                Broker.dajSesiju().SacuvajCenu(proizvod);
                MessageBox.Show("Cene su sacuvane!");
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greska!\n"+ex.Message);
                return false;
            }
        }

        internal static void obrisiCenu(TextBox txtIznosC, DateTimePicker dtpDatumC)
        {

            if (cena.Status == Status.New) proizvod.IstorijaCena.Remove(cena);
            else cena.Status = Status.Delete;
          

            txtIznosC.Clear();
            dtpDatumC.Value = DateTime.Now;
            cena = null;
        }

        internal static void obojiGrid(DataGridView dgvCene)
        {
            foreach (DataGridViewRow red in dgvCene.Rows) 
            {
                try
                {
                    OsnovnaCena c = (OsnovnaCena)red.DataBoundItem;

                    switch (c.Status)
                    {                       
                        case Status.New: red.DefaultCellStyle.ForeColor = Color.Blue;
                            break;
                        case Status.Edit: red.DefaultCellStyle.ForeColor = Color.Green;
                            break;
                        case Status.Delete: red.DefaultCellStyle.ForeColor = Color.Red;
                            break;                      
                        default:
                            break;
                    }
                }
                catch (Exception)
                {

                   
                }
                dgvCene.Refresh();
               
            }
        }

        internal static void dodajCenu(TextBox txtIznosC, DateTimePicker dtpDatumC)
        {
            OsnovnaCena c = new OsnovnaCena() { Status=Status.New };

            try
            {
                c.Iznos = Convert.ToDouble(txtIznosC.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Niste ispravno uneli cenu!");
                return;
            }

            c.Datum = dtpDatumC.Value;

            c.SifraP = proizvod.Sifra;

            if (proizvod.IstorijaCena.Contains(c)) 
            {
                MessageBox.Show("Uneli ste vec cenu za isti datum!");
                return;
            }

            proizvod.IstorijaCena.Add(c);
            txtIznosC.Clear();
            dtpDatumC.Value = DateTime.Now;
            cena = null;
        }


        internal static void popuniPoljaCene(DataGridView dgvCene)
        {
            dgvCene.DataSource = proizvod.IstorijaCena;
        }

        internal static bool izmeniProzivod(TextBox txtNaziv, TextBox txtDuzina, TextBox txtSirina, TextBox txtVisina, TextBox txtAktuelnaCena, TextBox txtMaterijal, TextBox txtTipMaterijala, ComboBox cmbJM, ComboBox cmbMat, ComboBox cmbTP)
        {
            try
            {               
                proizvod.Naziv = txtNaziv.Text;
                proizvod.Dimenzije = Dimenzija.Parse(txtDuzina.Text + "X" + txtSirina.Text + "X" + txtVisina.Text);
                proizvod.JedinicaMere = (JedinicaMere)cmbJM.SelectedItem;
                proizvod.TipProizvoda = (TipProizvoda)cmbTP.SelectedItem;
                proizvod.Materijal = (Materijal)cmbMat.SelectedItem;
                proizvod.Materijal3NF = txtMaterijal.Text;
                proizvod.TipMaterijal3NF = txtTipMaterijala.Text;
                proizvod.AktuelnaCena = Convert.ToDouble(txtAktuelnaCena.Text);

                Broker.dajSesiju().SacuvajProizvod(proizvod);
                MessageBox.Show("Proizvod je izmenjen!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska!\n" + ex.Message);
                return false;
            }
        }

        internal static void odaberiDeo(DataGridView dgvDeo, ComboBox cmbProizvod, TextBox txtKol)
        {
            try
            {
              
                deo = (USastavu)dgvDeo.CurrentRow.DataBoundItem;
                cmbProizvod.SelectedItem = deo.Deo;
                txtKol.Text = deo.Kolicina.ToString();                
            }
            catch (Exception)
            {


            }
        }

        internal static void dodajDeo(TextBox txtKol, ComboBox cmbProizvod)
        {
            USastavu d = new USastavu() { Status = Status.New };

            try
            {
                d.Kolicina = Convert.ToInt32(txtKol.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Niste ispravno uneli kolicinu!");
                return;
            }

            d.Deo = (Proizvod)cmbProizvod.SelectedItem;

            d.Proizvod = proizvod;

            if (proizvod.SpisakDelova.Contains(d))
            {
                MessageBox.Show("Isti deo je vec dodat!!");
                return;
            }

            proizvod.SpisakDelova.Add(d);
            txtKol.Clear();
            popuniCmbProizvod(cmbProizvod);
        }
        internal static void izmeniDeo(TextBox txtKol, ComboBox cmbProizvod)
        {
           
            try
            {
                deo.Kolicina = Convert.ToInt32(txtKol.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Niste ispravno uneli kolicinu!");
                return;
            }

            deo.Deo = (Proizvod)cmbProizvod.SelectedItem;

            deo.Proizvod = proizvod;

            if (proizvod.SpisakDelova.Where(x=>x.Deo.Equals(deo)).ToList().Count>1)
            {
                MessageBox.Show("Isti deo je vec dodat!!");
                return;
            }

            if (deo.Status != Status.New) deo.Status = Status.Edit;

            txtKol.Clear();
            popuniCmbProizvod(cmbProizvod);
        }

        internal static void osveziDelove(DataGridView dgvDeo)
        {
            try
            {
                dgvDeo.Rows.Clear();
                Broker.dajSesiju().VratiDeloveProizvoda(proizvod);
                dgvDeo.DataSource = proizvod.SpisakDelova;
            }
            catch (Exception)
            {


            }
        }

        internal static bool sacuvajDelove()
        {
            try
            {
                Broker.dajSesiju().SacuvajDelove(proizvod);
                MessageBox.Show("Delovi su sacuvani!");
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greska!\n" + ex.Message);
                return false;
            }
        }

        internal static void obrisiDeo(TextBox txtKol, ComboBox cmbProizvod)
        {

            if (deo.Status == Status.New) proizvod.SpisakDelova.Remove(deo);
            else deo.Status = Status.Delete;


            txtKol.Clear();
            popuniCmbProizvod(cmbProizvod);
        }

        internal static void obojiGridDelovi(DataGridView dgvDeo)
        {
            foreach (DataGridViewRow red in dgvDeo.Rows)
            {
                try
                {
                    USastavu d = (USastavu)red.DataBoundItem;

                    switch (d.Status)
                    {
                        case Status.New:
                            red.DefaultCellStyle.ForeColor = Color.Blue;
                            break;
                        case Status.Edit:
                            red.DefaultCellStyle.ForeColor = Color.Green;
                            break;
                        case Status.Delete:
                            red.DefaultCellStyle.ForeColor = Color.Red;
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {


                }
                dgvDeo.Refresh();
                deo = null;
            }
        }
        internal static void popuniPoljaProizvoda(TextBox txtNaziv, TextBox txtDuzina, TextBox txtSirina, TextBox txtVisina, TextBox txtAktuelnaCena, TextBox txtMaterijal, TextBox txtTipMaterijala, ComboBox cmbJM, ComboBox cmbMat, ComboBox cmbTP)
        {
            txtAktuelnaCena.Text = proizvod.AktuelnaCena.ToString("N02");
            txtDuzina.Text = proizvod.Dimenzije.Duzina.ToString();
            txtSirina.Text = proizvod.Dimenzije.Sirina.ToString();
            txtVisina.Text = proizvod.Dimenzije.Visina.ToString();
            txtMaterijal.Text = proizvod.Materijal3NF;
            txtNaziv.Text = proizvod.Naziv;
            txtTipMaterijala.Text = proizvod.TipMaterijal3NF;

            cmbJM.SelectedItem = proizvod.JedinicaMere;
            cmbMat.SelectedItem = proizvod.Materijal;
            cmbTP.SelectedItem = proizvod.TipProizvoda;
        }

        internal static bool sacuvajProizvod(TextBox txtNaziv, TextBox txtDuzina, TextBox txtSirina, TextBox txtVisina, ComboBox cmbJM, ComboBox cmbMat, ComboBox cmbTP)
        {
            try
            {
                proizvod = new Proizvod() { Status=Status.New};
                proizvod.Naziv = txtNaziv.Text;
                
                if(string.IsNullOrEmpty(proizvod.Naziv))
                {
                    MessageBox.Show("Niste uneli naziv proizvoda.");
                    return false;
                }

                proizvod.Dimenzije = Dimenzija.Parse(txtDuzina.Text+"X"+txtSirina.Text+"X"+txtVisina.Text);
                proizvod.JedinicaMere = (JedinicaMere)cmbJM.SelectedItem;
                proizvod.TipProizvoda = (TipProizvoda)cmbTP.SelectedItem;
                proizvod.Materijal = (Materijal)cmbMat.SelectedItem;

                Broker.dajSesiju().SacuvajProizvod(proizvod);
                MessageBox.Show("Proizvod je sacuvan!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska!\n" + ex.Message);
                return false;
            }
        }

        internal static void popuniCmbZaProizvod(ComboBox cmbJM, ComboBox cmbMat, ComboBox cmbTP)
        {
            try
            {
                cmbJM.DataSource = Broker.dajSesiju().VratiJediniceMere("");
                cmbMat.DataSource = Broker.dajSesiju().VratiMaterijal("");
                cmbTP.DataSource = Broker.dajSesiju().VratiTipoveProizvoda("");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greska!\n"+ex.Message);
            }
        }

        internal static void popuniPoljaTipMaterijala(TextBox txtNaziv)
        {
            txtNaziv.Text = tipMaterijala.Naziv;
        }

        internal static void popuniPoljaTipProizvoda(TextBox txtNaziv)
        {
            txtNaziv.Text = tipProizvoda.Naziv;
        }

        internal static bool izmeniMaterijal(TextBox txtNaziv, ComboBox cmbTM)
        {
            try
            {
                materijal.Naziv = txtNaziv.Text;
                materijal.TipMaterijala = (TipMaterijala)cmbTM.SelectedItem;

                Broker.dajSesiju().izmeniMaterijal(materijal);
                MessageBox.Show("Materijal je uspesno izmenjen!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska!\n"+ex.Message);
                return false;
            }
        }

        internal static void obrisiProizvod()
        {
            try
            {
                proizvod.Status = Status.Delete;
                Broker.dajSesiju().SacuvajProizvod(proizvod);
                MessageBox.Show("Proizvod je obrisan!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greska!\n"+ex.Message);               
            }
        }

        internal static bool izmeniTipMaterijala(TextBox txtNaziv)
        {
            try
            {
                tipMaterijala.Naziv = txtNaziv.Text;            

                Broker.dajSesiju().izmeniTipMaterijala(tipMaterijala);
                MessageBox.Show("Tip materijala je uspesno izmenjen!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska!\n" + ex.Message);
                return false;
            }
        }

        internal static bool izmeniTipProizvoda(TextBox txtNaziv)
        {
            try
            {
                tipProizvoda.Naziv = txtNaziv.Text;

                Broker.dajSesiju().izmeniTipProizvoda(tipProizvoda);
                MessageBox.Show("Tip proizvoda je uspesno izmenjen!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska!\n" + ex.Message);
                return false;
            }
        }

        internal static void popuniPoljaMaterijal(TextBox txtNaziv, ComboBox cmbTM)
        {
            cmbTM.DataSource = Broker.dajSesiju().VratiTipMaterijala("");
            txtNaziv.Text = materijal.Naziv;
            cmbTM.SelectedItem = materijal.TipMaterijala;
        }

        internal static bool odaberitipMaterijala(DataGridView dgv)
        {
            try
            {
                tipMaterijala = (TipMaterijala)dgv.CurrentRow.DataBoundItem;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska!\n" + ex.Message);
                return false;
            }
        }

        internal static bool odaberiTipProizvoda(DataGridView dgv)
        {
            try
            {
                tipProizvoda = (TipProizvoda)dgv.CurrentRow.DataBoundItem;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska!\n" + ex.Message);
                return false;
            }
        }

        internal static bool odaberiProizvod(DataGridView dgv)
        {
            try
            {
                proizvod = null;
                proizvod = (Proizvod)dgv.CurrentRow.DataBoundItem;
                Broker.dajSesiju().VratiCeneProizvoda(proizvod);
                Broker.dajSesiju().VratiDeloveProizvoda(proizvod);
                proizvod.Status = Status.Edit;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska!\n" + ex.Message);
                return false;
            }
        }

        internal static void PretraziMaterijale(DataGridView dgv, TextBox txtUslov)
        {
            try
            {
                dgv.DataSource = Broker.dajSesiju().VratiMaterijal(txtUslov.Text);
            }
            catch (Exception)
            {

                
            }
        }

        internal static void PretraziTipoveMaterijala(DataGridView dgv, TextBox txtUslov)
        {
            try
            {
                dgv.DataSource = Broker.dajSesiju().VratiTipMaterijala(txtUslov.Text);
            }
            catch (Exception)
            {


            }
        }

        internal static void PretraziTipoveProizvoda(DataGridView dgv, TextBox txtUslov)
        {
            try
            {
                dgv.DataSource = Broker.dajSesiju().VratiTipoveProizvoda(txtUslov.Text);
            }
            catch (Exception)
            {


            }
        }

        internal static void PretraziProizvode(DataGridView dgv, TextBox txtUslov)
        {
            try
            {
                dgv.DataSource = Broker.dajSesiju().VratiProizvode(txtUslov.Text);
            }
            catch (Exception)
            {


            }
        }
    }
}
