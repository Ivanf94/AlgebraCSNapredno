using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonimne_metode_primjer
{
    public delegate void Printaj(int vrijednost);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Anonimne metode - jednostavna anonimna metoda");
            Console.WriteLine("==========================================");

            Printaj printer = delegate (int broj)
            {
                Console.WriteLine("Ja sam unutar anonimne metode s brojem" + broj);
            };

            printer(100);
            printer.Invoke(200);

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Anonimne metode - primjer s varijablom");
            Console.WriteLine("==========================================");

            int i = 10;
            printer = delegate (int broj)
            {
                broj += i;
                Console.WriteLine("Ja sam unutar anonimne metode s "+broj);
            };

            printer(100);

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Anonimne metode - anonimna metoda kao parametar");
            Console.WriteLine("==========================================");

            PrintajHelper(
                delegate (int broj) { 
                    Console.WriteLine("Anonimna metoda proslijeđena kao parametar s " + broj); 
                }, 
                100
            );
        }

        public static void PrintajHelper(Printaj printerdelegat, int broj)
        {
            broj += 10;
            printerdelegat(broj);
        }
    }
}
