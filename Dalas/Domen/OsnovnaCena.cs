using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class OsnovnaCena
    {
        int sifraP;
        DateTime datum;
        double iznos;
        Status status;

        public int SifraP { get => sifraP; set => sifraP = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public double Iznos { get => iznos; set => iznos = value; }
        [Browsable(false)]
        public Status Status { get => status; set => status = value; }

        public override bool Equals(object obj)
        {
            return obj is OsnovnaCena cena &&
                   sifraP == cena.sifraP &&
                   datum.Date == cena.datum.Date;
        }
    }
}
