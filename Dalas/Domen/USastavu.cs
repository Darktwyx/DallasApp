using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class USastavu
    {
        Proizvod proizvod;
        Proizvod deo;
        int kolicina;
        string tipProizvoda;
        Status status;

        [Browsable(false)]
        public Proizvod Proizvod { get => proizvod; set => proizvod = value; }
        public Proizvod Deo { get => deo; set => deo = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public string TipProizvoda { get => tipProizvoda; set => tipProizvoda = value; }
        [Browsable(false)]
        public Status Status { get => status; set => status = value; }

        public override bool Equals(object obj)
        {
            return obj is USastavu sastavu &&
                   EqualityComparer<Proizvod>.Default.Equals(proizvod, sastavu.proizvod) &&
                   EqualityComparer<Proizvod>.Default.Equals(deo, sastavu.deo);
        }
    }
}
