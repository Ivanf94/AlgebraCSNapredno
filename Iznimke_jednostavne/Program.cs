using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_jednostavne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Unesite broj: ");
                    int broj = int.Parse(Console.ReadLine());

                    if (broj == 0) break;

                    Console.WriteLine($"Kvadrat broja {broj} je {broj*broj}");
                }
                catch
                {
                    Console.WriteLine("Neispravan unos cijelog broja!");
                    Console.WriteLine("Pokušajte ponovno...");
                    Console.WriteLine();
                }
                finally
                {
                    Console.WriteLine("Unesite novi cijeli broj:");
                    Console.WriteLine();
                    Console.WriteLine("===================================");
                }
            }
        }
    }
}
