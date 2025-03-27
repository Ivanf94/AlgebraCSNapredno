using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_kao_parametar
{
    public delegate void TestDelegat(string poruka);
    internal class Program
    {
        static void Main(string[] args)
        {
            TestDelegat del = KlasaA.MetodaA;
            Poziv(del);

            del = KlasaB.MetodaB;
            Poziv(del);

            del = (string poruka) => Console.WriteLine("Poziv preko lambda izraza: " + poruka);
            Poziv(del);
        }

        static void Poziv(TestDelegat del)
        {
            del("pozdrav...");
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
