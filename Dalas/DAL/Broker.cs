using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Domen;

namespace DAL
{
    public class Broker
    {
        SqlConnection konekcija;
        SqlCommand komanda;
        SqlTransaction transakcija;

        void konektujSe() 
        {
            konekcija = new SqlConnection(@"Data Source=DESKTOP-PS2LELV\PEDJA;Initial Catalog=Dalas;Integrated Security=True");
            komanda = konekcija.CreateCommand();
        }

        static Broker instanca;
        public Broker()
        {
            konektujSe();
        }

        public static Broker dajSesiju() 
        {           
            instanca = instanca ?? new Broker();
            return instanca;
        }

        void zapocniTransakciju() 
        {
            try
            {
                konekcija.Open();
                transakcija = konekcija.BeginTransaction();
                komanda = new SqlCommand("", konekcija, transakcija);
            }
            catch (Exception)
            {

                throw;
            }
        }

        void potvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {

                throw;
            }
        }

        void ponistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {

                throw;
            }
        }

        void zatvoriKonekciju()
        {
            try
            {
               
                if (konekcija != null) konekcija.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public int vratiSifru(string tabela) 
        {
            try
            {
                komanda.CommandText="Select max(Sifra) from "+tabela;
                object rez = komanda.ExecuteScalar();
                return rez == DBNull.Value ? 1 : Convert.ToInt32(rez) + 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void izmeniMaterijal(Materijal m) 
        {
            try
            {
                zapocniTransakciju();
                komanda.CommandText = "Update Materijal set Naziv='"+m.Naziv+"', TipM="+m.TipMaterijala.Sifra+" where Sifra="+m.Sifra+" ";
                komanda.ExecuteNonQuery();
                potvrdiTransakciju();
            }
            catch (Exception)
            {
                ponistiTransakciju();
                throw;
            }
            finally { zatvoriKonekciju(); }
        }

        public void izmeniTipMaterijala(TipMaterijala tm)
        {
            try
            {
                zapocniTransakciju();
                komanda.CommandText = "Update TipMaterijala set Naziv='" + tm.Naziv + "' where Sifra=" + tm.Sifra + " ";
                komanda.ExecuteNonQuery();
                potvrdiTransakciju();
            }
            catch (Exception)
            {
                ponistiTransakciju();
                throw;
            }
            finally { zatvoriKonekciju(); }
        }


        public void izmeniTipProizvoda(TipProizvoda tp)
        {
            try
            {
                zapocniTransakciju();
                komanda.CommandText = "Update TipProizvoda set Naziv='" + tp.Naziv + "' where Sifra=" + tp.Sifra + " ";
                komanda.ExecuteNonQuery();
                potvrdiTransakciju();
            }
            catch (Exception)
            {
                ponistiTransakciju();
                throw;
            }
            finally { zatvoriKonekciju(); }
        }

        
        public void SacuvajProizvod(Proizvod p)
        {
            try
            {
                zapocniTransakciju();

                switch (p.Status)
                {

                    case Status.New:
                        p.Sifra = vratiSifru("Proizvod");
                        komanda.CommandText = "Insert into Proizvod ([Sifra],[Naziv],[Dimenzija],[SifraJM],[SifraM],[SifraTP]) values (" + p.Sifra + ",'" + p.Naziv + "', '" + p.Dimenzije.ToString() + "'," + p.JedinicaMere.Sifra+ ","+p.Materijal.Sifra+","+p.TipProizvoda.Sifra+")";
                        break;
                    case Status.Edit:
                        komanda.CommandText = "Update Proizvod set  Naziv='" + p.Naziv + "', Dimenzija='" + p.Dimenzije.ToString() + "',  SifraJM=" + p.JedinicaMere.Sifra + ", SifraM="+p.Materijal.Sifra+", SifraTP="+p.TipProizvoda.Sifra+" where Sifra=" + p.Sifra + "";
                        break;
                    case Status.Delete:
                        komanda.CommandText = "Delete from Proizvod where Sifra=" + p.Sifra + "";
                        break;
                    case Status.Error1:
                        komanda.CommandText = "Update Proizvod set  AktuelnaCena=" + p.AktuelnaCena + " where Sifra=" + p.Sifra + "";
                        break;
                    case Status.Error2:
                        komanda.CommandText = "Update Proizvod set  Materijal='" + p.Materijal3NF + "' where Sifra=" + p.Sifra + "";
                        break;
                    case Status.Error3:
                        komanda.CommandText = "Update Proizvod set  TipMaterijala='" + p.TipMaterijal3NF + "' where Sifra=" + p.Sifra + "";
                        break;

                }

                if (p.Status != Status.None) komanda.ExecuteNonQuery();
                potvrdiTransakciju();
            }
            catch (Exception)
            {
                transakcija.Rollback();
                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }


        public void SacuvajCenu(Proizvod p)
        {
            try
            {
                zapocniTransakciju();

                foreach (OsnovnaCena c in p.IstorijaCena)
                {
                    switch (c.Status)
                    {

                        case Status.New:
                            komanda.CommandText = "Insert into OsnovnaCena  values (" + c.SifraP + ",'" + c.Datum.ToString("yyyy-MM-dd") + "', " + c.Iznos + ")";
                            break;
                        case Status.Edit:
                            komanda.CommandText = "Update OsnovnaCena set  Iznos=" + c.Iznos + " where SifraP=" + c.SifraP + " and Datum =Cast ('" + c.Datum.ToString("yyyy-MM-dd") + "' as date) ";
                            break;
                        case Status.Delete:
                            komanda.CommandText = "Delete from OsnovnaCena where SifraP=" + c.SifraP + " and Cast( Datum as date)=Cast ('" + c.Datum.ToString("yyyy-MM-dd") + "' as date) ";
                            break;

                    }

                   if(c.Status!=Status.None) komanda.ExecuteNonQuery();
                }
                potvrdiTransakciju();
            }
            catch (Exception)
            {
                ponistiTransakciju();
                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }


        public void SacuvajDelove(Proizvod p)
        {
            try
            {
                zapocniTransakciju();

                foreach (USastavu d in p.SpisakDelova)
                {
                    switch (d.Status)
                    {

                        case Status.New:
                            komanda.CommandText = "Insert into USastavu (SifraP, SifraPDela, Kolicina)  values (" + d.Proizvod.Sifra + "," + d.Deo.Sifra + ", " + d.Kolicina + ")";
                            break;
                        case Status.Edit:
                            komanda.CommandText = "Update USastavu set  Kolicina=" + d.Kolicina + " where SifraP=" + d.Proizvod.Sifra + " and SifraPDela="+d.Deo.Sifra+" ";
                            break;
                        case Status.Delete:
                            komanda.CommandText = "Delete from Usastavu  where SifraP = " + d.Proizvod.Sifra + " and SifraPDela = "+d.Deo.Sifra+" ";
                            break;
                        case Status.Error1:
                            komanda.CommandText = "Update USastavu set  TipProizvoda='" + d.TipProizvoda + "' where SifraP=" + d.Proizvod.Sifra + " and SifraPDela=" + d.Deo.Sifra + " ";
                            break;

                    }

                    if (d.Status != Status.None) komanda.ExecuteNonQuery();
                }
                potvrdiTransakciju();
            }
            catch (Exception)
            {
                ponistiTransakciju();
                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<JedinicaMere> VratiJediniceMere(string uslov)
        {
            List<JedinicaMere> lista = new List<JedinicaMere>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from JedinicaMere where Naziv like '" + uslov + "%' ";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    JedinicaMere jm = new JedinicaMere();

                    jm.Sifra = citac.GetInt32(0);
                    jm.Naziv = citac.GetString(1);

                    lista.Add(jm);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<Materijal> VratiMaterijal(string uslov)
        {
            List<Materijal> lista = new List<Materijal>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Materijal m inner join TipMaterijala tm on m.TipM=tm.Sifra where m.Naziv like '" + uslov + "%' ";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Materijal m = new Materijal();

                    m.Sifra = citac.GetInt32(0);
                    m.Naziv = citac.GetString(1);
                    try
                    {
                        m.UvecanjeCene = Convert.ToDouble(citac.GetValue(2));
                    }
                    catch (Exception)
                    {

                       
                    }
                    m.TipMaterijala = new TipMaterijala();
                    m.TipMaterijala.Sifra = citac.GetInt32(3);
                    m.TipMaterijala.Naziv = citac.GetString(5);

                    lista.Add(m);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<TipProizvoda> VratiTipoveProizvoda(string uslov)
        {
            List<TipProizvoda> lista = new List<TipProizvoda>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from TipProizvoda where Naziv like '" + uslov + "%' ";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    TipProizvoda tp = new TipProizvoda();

                    tp.Sifra = citac.GetInt32(0);
                    tp.Naziv = citac.GetString(1);

                    lista.Add(tp);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }


        public List<TipMaterijala> VratiTipMaterijala(string uslov)
        {
            List<TipMaterijala> lista = new List<TipMaterijala>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from TipMaterijala where Naziv like '" + uslov + "%' ";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    TipMaterijala tm = new TipMaterijala();

                    tm.Sifra = citac.GetInt32(0);
                    tm.Naziv = citac.GetString(1);

                    lista.Add(tm);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public List<Proizvod> VratiProizvode(string uslov)
        {
            List<Proizvod> lista = new List<Proizvod>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Proizvod p inner join JedinicaMere jm on p.SifraJM=jm.Sifra inner join TipProizvoda tp on p.SifraTP = tp.Sifra where p.Naziv like '" + uslov + "%' or p.Materijal like '" + uslov + "%' or p.TipMaterijala like '" + uslov + "%' ";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Proizvod p = new Proizvod();

                    p.Sifra = citac.GetInt32(0);
                    p.Naziv = citac.GetString(1);
                    try
                    {
                        p.Dimenzije = Dimenzija.Parse(citac.GetValue(2).ToString());
                    }
                    catch (Exception)
                    {

                       
                    }
                    p.TipProizvoda = new TipProizvoda();
                    p.TipProizvoda.Sifra = citac.GetInt32(3);
                    p.Materijal = new Materijal();
                    p.Materijal.Sifra = citac.GetInt32(4);
                    p.JedinicaMere = new JedinicaMere();
                    p.JedinicaMere.Sifra = citac.GetInt32(5);
                    p.Materijal3NF = citac.GetString(6);
                    p.TipMaterijal3NF = citac.GetString(7);
                    try
                    {
                        p.AktuelnaCena = Convert.ToDouble(citac.GetValue(8));
                    }
                    catch (Exception)
                    {


                    }            
                    p.JedinicaMere.Naziv = citac.GetString(10);
                    p.TipProizvoda.Naziv = citac.GetString(12);

                    lista.Add(p);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void VratiCeneProizvoda(Proizvod p)
        {
           
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from OsnovnaCena where SifraP=" + p.Sifra + " ";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    OsnovnaCena c = new OsnovnaCena();

                    c.SifraP = citac.GetInt32(0);
                    c.Datum = citac.GetDateTime(1);
                    c.Iznos = Convert.ToDouble(citac.GetValue(2));

                    p.IstorijaCena.Add(c);
                }
                citac.Close();
              
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

        public void VratiDeloveProizvoda(Proizvod p)
        {
          
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from USastavu d inner join Proizvod p on d.SifraPDela=p.Sifra where d.SifraP=" + p.Sifra + " ";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    USastavu d = new USastavu();

                    d.Proizvod = p;
                    d.Deo = new Proizvod();
                    d.Deo.Sifra = citac.GetInt32(1);
                    d.Deo.Naziv = citac.GetString(5);
                    d.Kolicina = Convert.ToInt32( citac.GetValue(2));
                    d.TipProizvoda = citac.GetString(3);

                    p.SpisakDelova.Add(d);
                }
                citac.Close();

            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }


        public List<USastavu> VratiDeloveProizvoda()
        {
            List<USastavu> lista = new List<USastavu>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select d.*, p.Naziv, pd.Naziv from USastavu d inner join Proizvod p  on p.Sifra=d.SifraP inner join Proizvod pd on d.SifraPDela = pd.Sifra  ";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    USastavu d = new USastavu();

                    d.Proizvod = new Proizvod();
                    d.Proizvod.Sifra = citac.GetInt32(0);
                    d.Proizvod.Naziv = citac.GetString(4);
                    d.Deo = new Proizvod();
                    d.Deo.Sifra = citac.GetInt32(2);
                    d.Proizvod.Naziv = citac.GetString(5);
                    d.Kolicina = citac.GetInt32(2);
                    d.TipProizvoda = citac.GetString(3);
                   

                    lista.Add(d);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }
    }
}
