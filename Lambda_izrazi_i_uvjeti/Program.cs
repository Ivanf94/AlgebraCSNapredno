using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_i_uvjeti
{
    internal class Program
    {
        delegate int MojDelegat(int p1, int p2, int p3);
        static void Main(string[] args)
        {
            MojDelegat del = (x, y, z) => (x > y) ? (x > z ? x : z) : (y > z ? y : z);
            Console.WriteLine(del(50,60,30));
        }
    }
}
