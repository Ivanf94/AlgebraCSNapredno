using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_za_ferrari.Automobili
{
    public interface IAutomobil
    {
        string Model { get; }
        string Vozac { get; }

        string Kocnice();
        string Gorivo();
    }
}
