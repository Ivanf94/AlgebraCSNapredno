using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sucelja_ali_eksplicitna.Sucelja;

namespace Sucelja_ali_eksplicitna.Models
{
    public class Gradjanin : IStanovnik, IOsoba
    {   
        public string Ime { get; private set; }
        public string Prezime { get; private set; }
        public int Godine { get; private set; }
        public string Drzava { get; private set; }

        string IOsoba.DohvatiImePrezime()
        {
            return Ime + " " + Prezime;
        }

        string IStanovnik.DohvatiImePrezime()
        {
            return "Gdin/Gđa/Gđica " + Ime + " " + Prezime;
        }

        public Gradjanin(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
    }
}
