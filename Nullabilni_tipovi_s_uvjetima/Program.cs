using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullabilni_tipovi_s_uvjetima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            int j = 10;

            Console.WriteLine("==============================");
            Console.WriteLine("Nullabilni tipovi s granjanjem");
            Console.WriteLine("==============================");

            if (i < j)
            {
                Console.WriteLine("i je manje od j");
            }
            else if(i > 10)
            {
                Console.WriteLine("i je veći od j");
            }
            else if (i == 10)
            {
                Console.WriteLine("i je jednak j");
            }
            else
            {
                Console.WriteLine("Nije moguće napraviti usporedbu");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine("Nullabilni tipovi s uvjetom i pomoćnim klasama");
            Console.WriteLine("==============================================");
            Console.WriteLine();

            if(Nullable.Compare<int>(i,j) < 0)
            {
                Console.WriteLine("i je manji od j");
            }
            else if(Nullable.Compare<int>(i, j) > 0)
            {
                Console.WriteLine("i je veći od j");
            }
            else if (Nullable.Compare<int>(i, j) == 0)
            {
                Console.WriteLine("i je jednak j");
            }
            else
            {
                Console.WriteLine("Nije moguće napraviti usporedbu");
            }
        }
    }
}
