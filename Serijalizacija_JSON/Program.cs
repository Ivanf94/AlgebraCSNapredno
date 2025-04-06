using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Serijalizacija_JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba()
            {
                Id = 1,
                Ime = "Marko",
                Prezime = "Markić",
                DatumRodjenja = new DateTime(1990, 7, 13)
            };

            string json = JsonSerializer.Serialize(o);

            Console.WriteLine(json);
            File.WriteAllText("Osoba.json", json);

            Osoba no = JsonSerializer.Deserialize<Osoba>(json);
            Console.WriteLine(no.Id+" "+no.Ime+" "+no.Prezime+" "+no.DatumRodjenja.ToShortDateString());

            List<Osoba> osobe = new List<Osoba>();
            osobe.Add(o);
            osobe.Add(no);

            json = JsonSerializer.Serialize(osobe);
            Console.WriteLine("Osobe serijalizirane: ");
            Console.WriteLine(json);

            List<Osoba> deserijalizirane_osobe = JsonSerializer.Deserialize<List<Osoba>>(json);

            foreach(var item in deserijalizirane_osobe)
            {
                Console.WriteLine(item.Id+" "+item.Ime);
            }
        }
    }
}
