using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_protiv_delegata
{
    internal class Program
    {
        const int Max = 10000000;
        static void Main(string[] args)
        {
            int[] polje = { 1 };
            Func<int, bool> verzijaDelegata = delegate (int argument)
            {
                return argument == 1;
            };

            var s1 = Stopwatch.StartNew();
            for(int i=0; i <Max; i++)
            {
                if (polje.Count(element => element == 1) == 0)
                {
                    return;
                }
            }
            s1.Stop();

            var s2=Stopwatch.StartNew();
            for (int i = 0; i < Max; i++)
            {
                if (polje.Count(verzijaDelegata) == 0) { return; }
            }
            s2.Stop();

            Console.WriteLine("Lambda izraz: "+((double)(s1.Elapsed.TotalMilliseconds*1000000)/Max).ToString("0.00 ns"));
            Console.WriteLine("Delegat: "+((double)(s2.Elapsed.TotalMilliseconds*1000000)/Max).ToString("0.00 ns"));

            Console.ReadKey();
        }
    }
}
