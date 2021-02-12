using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Status { None, New, Edit, Delete,
        Error3,
        Error2,
        Error1
    }
    public class Proizvod
    {
        public override string ToString()
        {
            return naziv;
        }

        public override bool Equals(object obj)
        {
            return obj is Proizvod proizvod &&
                   sifra == proizvod.sifra;
        }

        public Proizvod()
        {
            istorijaCena = new BindingList<OsnovnaCena>();
            spisakDelova = new BindingList<USastavu>();
        }

        int sifra;
        string naziv;
        Dimenzija dimenzije;
        TipProizvoda tipProizvoda;
        Materijal materijal;
        JedinicaMere jedinicaMere;
        string materijal3NF;
        string tipMaterijal3NF;
        double aktuelnaCena;
        BindingList<OsnovnaCena> istorijaCena;
        BindingList<USastavu> spisakDelova;
        Status status;

        public int Sifra { get => sifra; set => sifra = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public Dimenzija Dimenzije { get => dimenzije; set => dimenzije = value; }      
        public TipProizvoda TipProizvoda { get => tipProizvoda; set => tipProizvoda = value; }
        [Browsable(false)]
        public Materijal Materijal { get => materijal; set => materijal = value; }
        public JedinicaMere JedinicaMere { get => jedinicaMere; set => jedinicaMere = value; }
        public string Materijal3NF { get => materijal3NF; set => materijal3NF = value; }
        public string TipMaterijal3NF { get => tipMaterijal3NF; set => tipMaterijal3NF = value; }
        public double AktuelnaCena { get => aktuelnaCena; set => aktuelnaCena = value; }
        public BindingList<OsnovnaCena> IstorijaCena { get => istorijaCena; set => istorijaCena = value; }
        [Browsable(false)]
        public Status Status { get => status; set => status = value; }
        public BindingList<USastavu> SpisakDelova { get => spisakDelova; set => spisakDelova = value; }
    }
}
