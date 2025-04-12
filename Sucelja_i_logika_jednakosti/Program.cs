using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_i_logika_jednakosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sortirane_osobe = new SortedSet<Osoba>();
            var hashed_osobe = new HashSet<Osoba>(new UpraviteljUsporedjivanjaOsoba());
            PopuniKolekciju(sortirane_osobe, hashed_osobe);

            Console.WriteLine("Sortirane osobe (" + sortirane_osobe.Count + "): ");
            foreach(var o in sortirane_osobe)
            {
                Console.WriteLine(o.Prezime+" "+o.Ime+" "+o.Dob);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Hashed osobe("+ hashed_osobe.Count + "): ");
            foreach(var o in hashed_osobe)
            {
                Console.WriteLine(o.Prezime + " " + o.Ime + " " + o.Dob);
            }
        }

        private static void PopuniKolekciju(SortedSet<Osoba> sortirane_osobe, HashSet<Osoba> hashed_osobe)
        {
            Console.Write("Unesite broj ljudi za unos: ");
            int broj_ljudi = int.Parse(Console.ReadLine());

            while( broj_ljudi > 0)
            {
                try
                {
                    Console.Write("Unesite prvo ime pa prezime i dob odvojeno razmakom: ");
                    var podaci = Console.ReadLine().Split();
                    sortirane_osobe.Add(new Osoba(podaci[0], podaci[1], int.Parse(podaci[2])));
                    hashed_osobe.Add(new Osoba(podaci[0], podaci[1], int.Parse(podaci[2])));

                    broj_ljudi--;
                    Console.WriteLine();
                }
                catch(Exception e)
                {
                    Console.WriteLine("Dogodila se greška: \n" + e.Message);
                    Console.WriteLine("Pokušajte ponovno s unosom...");
                }
            }
        }
    }
}
