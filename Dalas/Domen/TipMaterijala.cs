using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class TipMaterijala
    {
        public override string ToString()
        {
            return naziv;
        }

        public override bool Equals(object obj)
        {
            return obj is TipMaterijala materijala &&
                   sifra == materijala.sifra;
        }

        int sifra;
        string naziv;

        public int Sifra { get => sifra; set => sifra = value; }
        public string Naziv { get => naziv; set => naziv = value; }
    }
}
