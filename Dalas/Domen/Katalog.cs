using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Katalog
    {
        public override string ToString()
        {
            return BrojKataloga;
        }

        public Katalog()
        {
            stavkeKataloga = new BindingList<StavkaKataloga>();
        }

        int sifra;
        DateTime datum;
        string brojKataloga;
        BindingList<StavkaKataloga> stavkeKataloga;

        public int Sifra { get => sifra; set => sifra = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string BrojKataloga { get => brojKataloga; set => brojKataloga = value; }
        public BindingList<StavkaKataloga> StavkeKataloga { get => stavkeKataloga; set => stavkeKataloga = value; }

        public override bool Equals(object obj)
        {
            return obj is Katalog katalog &&
                   sifra == katalog.sifra;
        }
    }
}
