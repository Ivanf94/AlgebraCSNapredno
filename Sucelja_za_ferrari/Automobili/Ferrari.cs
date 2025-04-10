using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_za_ferrari.Automobili
{
    internal class Ferrari : IAutomobil
    {
        public Ferrari(string model, string vozac)
        {
            Model = model;
            Vozac = vozac;
        }
        public string Model { get; private set; }

        public string Vozac { get; private set; }

        public string Gorivo()
        {
            return "Pije ko smok...";
        }

        public string Kocnice()
        {
            return "Koči?";
        }

        public override string ToString()
        {
            return $"{Model}/{Kocnice()}/{Gorivo()}/{Vozac}";
        }
    }
}
