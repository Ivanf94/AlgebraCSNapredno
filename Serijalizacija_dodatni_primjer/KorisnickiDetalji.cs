using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serijalizacija_dodatni_primjer
{
    [Serializable]
    public class KorisnickiDetalji
    {
        public int Sifra { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }

        public KorisnickiDetalji(int id, string ime, string prezime, string adresa)
        {
            Sifra = id;
            Ime = ime;
            Prezime = prezime;
            Adresa = adresa;
        }

        public void DohvatiDetalje()
        {
            Console.WriteLine("Sifra: "+Sifra);
            Console.WriteLine($"Ime i prezime: {Ime} {Prezime}");
            Console.WriteLine("Adresa: "+Adresa);
        }
    }
}
