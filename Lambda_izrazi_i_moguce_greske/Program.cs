using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_i_moguce_greske
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 10, 20, 30 };
            //var rez = Array.Find(array, e => 20);
            var rez = Array.Find(array, e => e == 20);
        }
    }
}
