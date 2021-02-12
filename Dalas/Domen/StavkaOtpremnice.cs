using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class StavkaOtpremnice
    {
        int sifraO;
        int rb;
        int kolicina;
        double iznos;
        StavkaKataloga stavkaKataloga;

        [Browsable(false)]
        public int SifraO { get => sifraO; set => sifraO = value; }
        public int Rb { get => rb; set => rb = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public double Iznos { get => iznos; set => iznos = value; }
        public StavkaKataloga StavkaKataloga { get => stavkaKataloga; set => stavkaKataloga = value; }
    }
}
