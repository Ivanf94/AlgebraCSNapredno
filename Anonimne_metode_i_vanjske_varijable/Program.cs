using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonimne_metode_i_vanjske_varijable
{
    internal class Program
    {
        delegate void DelegateBrojacTipova();

        static DelegateBrojacTipova KreirajBrojac(string nazivBrojaca)
        {
            int brojac = 0;
            DelegateBrojacTipova del = delegate
            {
                Console.WriteLine(nazivBrojaca+(++brojac).ToString());
            };

            return del;
        }
        static void Main(string[] args)
        {
            DelegateBrojacTipova brojacA = KreirajBrojac("Brojač A: ");
            DelegateBrojacTipova brojacB = KreirajBrojac("Brojač B: ");

            brojacA();
            brojacA();

            brojacB();
            brojacB();
        }
    }
}
