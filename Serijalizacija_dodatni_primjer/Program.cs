using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Serijalizacija_dodatni_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KorisnickiDetalji kd = new KorisnickiDetalji(1, "Ana", "Anić", "Osijek");

            Console.WriteLine("Prije serijalizacije objekt sadrži sljedeći podatke:");
            kd.DohvatiDetalje();
            Console.WriteLine();

            string datoteka = "primjer.txt";

            if (File.Exists(datoteka))
            {
                File.Delete(datoteka);
            }

            Stream pohrani = File.Open(datoteka, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(pohrani, kd);
            pohrani.Close();

            Console.WriteLine();
            Console.WriteLine("Serijalizacija je uspješno odrađena...");

            Stream citaj = File.Open(datoteka, FileMode.Open);
            bf = new BinaryFormatter();
            KorisnickiDetalji novi_detalji = (KorisnickiDetalji)bf.Deserialize(citaj);
            citaj.Close();

            Console.WriteLine();
            Console.WriteLine("Nakon deserijalizacije podaci: ");
            novi_detalji.DohvatiDetalje();
        }
    }
}
