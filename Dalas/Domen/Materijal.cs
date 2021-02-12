using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Materijal
    {
        public override string ToString()
        {
            return Naziv;
        }

        public override bool Equals(object obj)
        {
            return obj is Materijal materijal &&
                   sifra == materijal.sifra;
        }

        int sifra;
        string naziv;
        double uvecanjeCene;
        TipMaterijala tipMaterijala;

        public int Sifra { get => sifra; set => sifra = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public double UvecanjeCene { get => uvecanjeCene; set => uvecanjeCene = value; }
        public TipMaterijala TipMaterijala { get => tipMaterijala; set => tipMaterijala = value; }
    }
}
