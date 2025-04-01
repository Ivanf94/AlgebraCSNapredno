using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_nad_rac_operacijama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rez, broj;

            Console.WriteLine("Unesite broj: ");
            try
            {
                broj = float.Parse(Console.ReadLine());

                rez = (float)Math.Sqrt(broj);
                Console.WriteLine("Korijen broja je "+rez);
            }
            catch (Exception)
            {
                Console.WriteLine("Pogreška, ne možemo izračunati korijen.");
            }
        }
    }
}
