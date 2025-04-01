using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_korisnicki_definirane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura t = new Temperatura();
            try
            {
                t.PrikaziTemperaturu();
            }
            catch(TemperaturaJeNula e)
            {
                Console.WriteLine("Poruka: "+e.Message);
            }
        }
    }
}
