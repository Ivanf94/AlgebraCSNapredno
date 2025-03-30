using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullabilni_tipovi_kratice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? i = null;

            int j = i ?? 0;

            Console.WriteLine(j);

            //j = (int)i;
            //Console.WriteLine(j);
        }
    }
}
