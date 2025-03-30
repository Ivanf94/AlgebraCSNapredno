using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> brojevi = new List<int>() { 36, 71, 12, 15, 29, 18, 27, 17, 9, 34 };

            Console.WriteLine("Lista brojeva: ");
            foreach(int broj in brojevi)
            {
                Console.Write($"{broj}  ");
            }
            Console.WriteLine();
            Console.WriteLine();

            var kvadrat_brojeva = brojevi.Select(x => x * x);
            foreach(int broj in kvadrat_brojeva)
            {
                Console.Write($"{broj}  ");
            }
            Console.WriteLine();
            Console.WriteLine();

            List<int> djeljivi_s_3 = brojevi.FindAll(x => (x % 3) == 0);
            Console.WriteLine("Brojevi liste koji su djeljivi s 3: ");
            foreach(int broj in djeljivi_s_3)
            {
                Console.Write($"{broj}  ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
