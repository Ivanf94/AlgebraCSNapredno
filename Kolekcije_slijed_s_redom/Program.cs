﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_slijed_s_redom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj slijedova: ");
            var n = long.Parse(Console.ReadLine());

            var sequence = new Queue<long>();
            sequence.Enqueue(n);
            var s = n;

            for(int i=0, skipCount =0; i < 49; i++)
            {
                switch (i % 3)
                {
                    case 0:
                        s = sequence.ToArray().Skip(skipCount).Take(1).ToArray()[0];
                        sequence.Enqueue(s + 1);
                        skipCount++;
                        break;
                    case 1:
                        sequence.Enqueue(2 * s + 1);
                        break;
                    case 2:
                        sequence.Enqueue(s + 2);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ",sequence));
        }
    }
}
