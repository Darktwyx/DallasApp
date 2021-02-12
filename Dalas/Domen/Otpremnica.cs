using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Otpremnica
    {
        int sifra;
        DateTime datum;
        string napomena;
        string adresaIsporuke;
        string vozac;
        string voziloRegBroj;
        string robuIzdao;
        string robuPrimio;
        Magacin magacin;
        Katalog katalog;
        BindingList<StavkaOtpremnice> stavkeOtpremnice;

        public Otpremnica()
        {
            stavkeOtpremnice = new BindingList<StavkaOtpremnice>();
        }

        public int Sifra { get => sifra; set => sifra = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string Napomena { get => napomena; set => napomena = value; }
        public string AdresaIsporuke { get => adresaIsporuke; set => adresaIsporuke = value; }
        public string Vozac { get => vozac; set => vozac = value; }
        public string VoziloRegBroj { get => voziloRegBroj; set => voziloRegBroj = value; }
        public string RobuIzdao { get => robuIzdao; set => robuIzdao = value; }
        public string RobuPrimio { get => robuPrimio; set => robuPrimio = value; }
        public Magacin Magacin { get => magacin; set => magacin = value; }
        public Katalog Katalog { get => katalog; set => katalog = value; }
        public BindingList<StavkaOtpremnice> StavkeOtpremnice { get => stavkeOtpremnice; set => stavkeOtpremnice = value; }
    }
}
