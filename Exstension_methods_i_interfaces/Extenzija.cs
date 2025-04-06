using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exstension_methods_i_interfaces
{
    public static class Extenzija
    {
        public static void MetodaA(this IMojInterface mi, int i)
        {
            Console.WriteLine("Ekstenzija.MetodaA(this IMojInterface mi, int i)");
        }

        public static void MetodaA(this IMojInterface mi, string s)
        {
            Console.WriteLine("Ekstenzija.MetodaA(this IMojInterface mi, string s)");
        }

        public static void MetodaB(this IMojInterface mi)
        {
            Console.WriteLine("Ekstenzija.MetodaB(this IMojInterface mi)");
        }
    }
}
