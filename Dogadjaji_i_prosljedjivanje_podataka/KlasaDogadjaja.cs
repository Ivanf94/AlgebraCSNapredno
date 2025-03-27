using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_i_prosljedjivanje_podataka
{
    internal class KlasaDogadjaja
    {
        public event EventHandler<bool> ProcesZavrsen;

        public void ProcesPocinje()
        {
            try
            {
                Console.WriteLine("Proces zapoceo...");
                //kod procesa
                KadProcesZavrsi(true);
            }
            catch
            {
                KadProcesZavrsi(false);
            }
        }

        public virtual void KadProcesZavrsi(bool status)
        {
            ProcesZavrsen?.Invoke(this,status);
        }
    }
}
