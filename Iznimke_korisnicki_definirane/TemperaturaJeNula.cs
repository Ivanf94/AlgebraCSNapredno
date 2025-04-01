using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_korisnicki_definirane
{
    public class TemperaturaJeNula : Exception
    {
        public TemperaturaJeNula(string poruka) : base(poruka)
        { }
    }
}
