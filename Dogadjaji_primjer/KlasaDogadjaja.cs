using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_primjer
{
    public delegate void Notifikacija();
    internal class KlasaDogadjaja
    {
        public event Notifikacija ProcesZavrsen;

        public void ProcesPoceo()
        {
            Console.WriteLine("Neki proces krenuo...");
            //Neki kod povezan s metodom...
            KadaProcesZavrsi();
        }

        protected virtual void KadaProcesZavrsi()
        {
            if(ProcesZavrsen != null)
            {
                ProcesZavrsen.Invoke();
            }

            //ProcesZavrsen?.Invoke();
        }
    }
}
