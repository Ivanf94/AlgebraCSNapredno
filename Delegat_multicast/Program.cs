using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_multicast
{

    internal class Program
    {
        public delegate void TestDelegat(string poruka);
        static void Main(string[] args)
        {
            TestDelegat del1 = KlasaA.MetodaA;
            TestDelegat del2 = KlasaB.MetodaB;

            TestDelegat del_boy = del1 + del2;
            del_boy("Ja sam prvi");
            Console.WriteLine("=============");

            TestDelegat del3 = (string p) => Console.WriteLine("Poziv preko lambda izraza: " + p);
            del_boy += del3;
            del_boy("Ja sam drugi");
            Console.WriteLine("=============");

            del_boy = del_boy - del2;
            del_boy("Ja sam treći");
            Console.WriteLine("=============");

            del_boy -= del1;
            del_boy("Ja sam zadnji");

            del_boy += del3;
            del_boy("Pitanja?");
        }
    }
    public class KlasaA
    {
        public static void MetodaA(string poruka)
        {
            Console.WriteLine("Pozvali smo KlasaA.MetodaA() s parametrima: " + poruka);
        }

        public static string str(string s) { return ""; }
    }

    public class KlasaB
    {
        public static void MetodaB(string poruka)
        {
            Console.WriteLine("Pozvali smo KlasaB.MetodaB() s parametrima: " + poruka);
        }
    }
}
