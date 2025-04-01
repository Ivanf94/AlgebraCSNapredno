using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonimni_tipovi_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Anonimni tipovi - jednostavan anonimni tip");
            Console.WriteLine("==========================================");

            var polaznik = new { Id = 1, Ime = "Marko", Prezime = "Marić" };
            Console.WriteLine(polaznik.Id);
            Console.WriteLine(polaznik.Ime);
            Console.WriteLine(polaznik.Prezime);

            //polaznik.Id = 2; read-only

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Anonimni tipovi - uključivanje drugih anonimnih tipova");
            Console.WriteLine("==========================================");

            var novi_polaznik = new
            {
                Id = 1,
                Ime = "Marko",
                Prezime = "Marić",
                Adresa = new { Id = 1, Grad = "Osijek", Drzava = "HR" }
            };
            Console.WriteLine(novi_polaznik.Id);
            Console.WriteLine(novi_polaznik.Ime);
            Console.WriteLine(novi_polaznik.Prezime);
            Console.WriteLine(novi_polaznik.Adresa.Id);
            Console.WriteLine(novi_polaznik.Adresa.Grad);
            Console.WriteLine(novi_polaznik.Adresa.Drzava);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Anonimni tipovi - polje anonimnih tipova");
            Console.WriteLine("==========================================");

            var polaznici = new[]
            {
                new{Id=1,Ime="Marko",Prezime="Marić"},
                new{Id=2,Ime="Ana",Prezime="Anić"},
                new{Id=3,Ime="Iva",Prezime="Ivić"}
            };

            Console.WriteLine(polaznici);
        }
    }
}
