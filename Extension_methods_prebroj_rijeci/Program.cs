using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_methods_prebroj_rijeci
{
    public static class EkstenzijeZaString
    {
        public static int PrebrojRijeci(this string unos)
        {
            if (!string.IsNullOrEmpty(unos))
            {
                string[] rijeci = unos.Split(' ');
                return rijeci.Count();
                //moglo je i rijeci.Length
            }
            return 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite rečenicu: ");
            string recenica = Console.ReadLine();
            int broj_rijeci = recenica.PrebrojRijeci();
            Console.WriteLine($"Rečenica \"{recenica}\" ima {broj_rijeci} riječi");
        }
    }
}
