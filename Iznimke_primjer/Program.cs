using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_primjer
{
    internal class Program
    {
        static int rezultat = 0;
        static void Main(string[] args)
        {
            Dijeljenje(27, 0);
            Console.WriteLine();
            Console.WriteLine();

            Dijeljenje(33, 11);
        }

        static void Dijeljenje(int broj1, int broj2)
        {
            try
            {
                rezultat = broj1 / broj2;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Uhvaćena je iznimka: "+e);
            }
            finally
            {
                Console.WriteLine("Rezultat je: "+rezultat);
            }
        }
    }
}
