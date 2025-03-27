using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_i_prosljedjivanje_podataka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaDogadjaja kd = new KlasaDogadjaja();
            kd.ProcesZavrsen += ProcesJeZavrsio;

            kd.ProcesPocinje();
        }

        public static void ProcesJeZavrsio(object sender, bool status)
        {
            Console.WriteLine("Proces "+(status ? "uspješan" : "nije uspio"));
        }
    }
}
