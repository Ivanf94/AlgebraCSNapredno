using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_i_kolekcije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi = { 1, 2, 4, 5, 6, 10, 13, 16, 22, 27, 29, 31 };

            int[] parni = brojevi.Where(x => x % 2 == 0).ToArray();
            int[] neparni = brojevi.Where(x => x % 2 != 0).ToArray();

            List<Osoba> osobe = new List<Osoba>()
            {
                new Osoba{Ime="Marko"},
                new Osoba{Ime="Ana"},
                new Osoba{Ime="Ivana"},
                new Osoba{Ime="Dario"}
            };

            //var prvoA = osobe.Where(x => x.Ime[0] == 'A').ToList();
            List<Osoba> ime_pocinje_s_A = osobe.Where(o => o.Ime.StartsWith("A")).ToList();
        }
    }

    class Osoba
    {
        public string Ime { get; set; }
    }
}
