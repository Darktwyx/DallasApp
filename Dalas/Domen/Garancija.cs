using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Garancija
    {
        int sifra;
        DateTime datum;
        string napomena;
        Kupac kupac;
        string telBrojKupca;
        string adresaKupca;
        string emailKupca;
        string imeProdavca;
        string telBrojProdavca;
        string adresaProdavca;

        public int Sifra { get => sifra; set => sifra = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string Napomena { get => napomena; set => napomena = value; }
        public Kupac Kupac { get => kupac; set => kupac = value; }
        public string TelBrojKupca { get => telBrojKupca; set => telBrojKupca = value; }
        public string AdresaKupca { get => adresaKupca; set => adresaKupca = value; }
        public string EmailKupca { get => emailKupca; set => emailKupca = value; }
        public string ImeProdavca { get => imeProdavca; set => imeProdavca = value; }
        public string TelBrojProdavca { get => telBrojProdavca; set => telBrojProdavca = value; }
        public string AdresaProdavca { get => adresaProdavca; set => adresaProdavca = value; }
    }
}
