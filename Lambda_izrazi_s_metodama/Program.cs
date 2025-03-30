using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_s_metodama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> metoda1 = x => x + 1;
            Console.WriteLine("METODA 1: {0}", metoda1.Invoke(200));

            Func<int, int> metoda2 = x => { return x+ 1; };
            Console.WriteLine("METODA 2: {0}", metoda2.Invoke(200));

            Func<int, int> metoda3 = (int x) => x + 1;
            Console.WriteLine("METODA 3: {0}", metoda3.Invoke(200));

            Func<int, int> metoda4 = (int x) => { return x + 1; };
            Console.WriteLine("METODA 4: {0}", metoda4.Invoke(200));

            Func<int, int, int> metoda5 = (x, y) => x * y;
            Console.WriteLine("METODA 5: {0}", metoda5.Invoke(15,3));

            Action tekst = () => Console.WriteLine("Pozdrav svima :)");
            tekst.Invoke();
        }
    }
}
