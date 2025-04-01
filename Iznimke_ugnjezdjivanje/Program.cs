using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_ugnjezdjivanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Molimo unesite broj nula: ");
            try
            {
                int broj = int.Parse(Console.ReadLine());
                try
                {
                    Console.WriteLine(100/broj);
                }
                catch
                {
                    Console.WriteLine("Iznimka unutar iznimke... exceptioninseption");
                }
            }
            catch
            {
                Console.WriteLine("Obična iznimka...");
            }
        }
    }
}
