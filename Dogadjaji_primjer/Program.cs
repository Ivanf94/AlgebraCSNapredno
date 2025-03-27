using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaDogadjaja kd = new KlasaDogadjaja();
            kd.ProcesZavrsen += ProcesJeZavrsio;

            kd.ProcesPoceo();
        }

        public static void ProcesJeZavrsio()
        {
            Console.WriteLine("4");
            Console.WriteLine("3");
            Console.WriteLine("2");
            Console.WriteLine("1");
            Console.WriteLine("Gotovo...");
        }
    }
}
