using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_korisnicki_definirane
{
    public class Temperatura
    {
        int temperatura = 0;
        
        public void PrikaziTemperaturu()
        {
            if(temperatura == 0)
            {
                throw new TemperaturaJeNula("Temperatura je 0!");
            }
            else
            {
                Console.WriteLine("Temperatura je "+ temperatura);
            }
        }
    }
}
