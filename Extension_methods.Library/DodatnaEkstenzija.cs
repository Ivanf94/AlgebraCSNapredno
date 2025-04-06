using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_methods.Library
{
    public static class DodatnaEkstenzija
    {
        public static void DodatnaMetodaEkstenzije(this ObicnaKlasa ook)
        {
            Console.WriteLine("Ja sam proširena metoda klase ObicnaKlasa");
        }
    }
}
