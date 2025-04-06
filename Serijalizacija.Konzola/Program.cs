using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serijalizacija.Library;

namespace Serijalizacija.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetodeZaSerijalizaciju metode = new MetodeZaSerijalizaciju();
            metode.SerijalizirajNesto();
            metode.DeserijalizirajNesto();
        }
    }
}
