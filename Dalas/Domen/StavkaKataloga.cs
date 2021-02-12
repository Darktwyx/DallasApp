using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class StavkaKataloga
    {
        public override string ToString()
        {
            return proizvod.ToString();
        }

        int sifraK;
        int rb;
        double popust;
        double cenaSaPopustom;
        Proizvod proizvod;

        public bool Select { get; set; }
        [Browsable(false)]
        public int SifraK { get => sifraK; set => sifraK = value; }
        public int Rb { get => rb; set => rb = value; }
        public Proizvod Proizvod { get => proizvod; set => proizvod = value; }
        public double Popust { get => popust; set => popust = value; }
        public double CenaSaPopustom { get => cenaSaPopustom; set => cenaSaPopustom = value; }
       
    }
}
