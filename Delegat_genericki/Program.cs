using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_genericki
{
    public delegate T add<T>(T param1, T param2);
    internal class Program
    {
        static void Main(string[] args)
        {
            add<int> z = Zbroj;
            Console.WriteLine(z(10,20));

            add<string> s = Konkatenacija;
            Console.WriteLine(s("pozdrav ","svima"));

        }

        public static int Zbroj(int broj1, int broj2) { return broj1 + broj2; }

        public static string Konkatenacija(string r1, string r2) { return r1 + r2; }
    }
}