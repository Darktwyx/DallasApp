using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Kupac
    {
        public override string ToString()
        {
            return Kontakt;
        }

        public override bool Equals(object obj)
        {
            return obj is Kupac kupac &&
                   sifra == kupac.sifra;
        }

        int sifra;
        string mesto;
        string kontakt;

        public int Sifra { get => sifra; set => sifra = value; }
        public string Mesto { get => mesto; set => mesto = value; }
        public string Kontakt { get => kontakt; set => kontakt = value; }
    }
}
