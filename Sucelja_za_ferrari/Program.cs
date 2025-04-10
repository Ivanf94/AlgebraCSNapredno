using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sucelja_za_ferrari.Automobili;

namespace Sucelja_za_ferrari
{
    internal class Program
    {
        private const string Model = "488-Spider";
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite vozača: ");
            string vozac = Console.ReadLine();
            var auto = new Ferrari(Model, vozac);
            Console.WriteLine(auto);

            string FerrariKlasaNaziv = typeof(Ferrari).Name;
            string IAutomobiliInterfaceNaziv = typeof(IAutomobil).Name;

            Console.WriteLine(FerrariKlasaNaziv+" "+IAutomobiliInterfaceNaziv);

            bool jeKreiran = typeof(IAutomobil).IsInterface;
            if (!jeKreiran) throw new Exception("Nije stvoreno sučelje IAutomobil!!");
        }
    }
}
