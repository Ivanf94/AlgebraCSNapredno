using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_multicast_s_povratnom_vrijednosti
{
    public delegate int TestDelegat();
    internal class Program
    {
        static void Main(string[] args)
        {
            TestDelegat del1 = KlasaA.MetodaA;
            TestDelegat del2 = KlasaB.MetodaB;

            TestDelegat del = del1 + del2;
            int b = del();

            Console.WriteLine(b);
        }
    }

    public class KlasaA
    {
        public static int MetodaA() { return 500; }
    }

    public class KlasaB
    {
        public static int MetodaB() { return 1000; }
    }
}
