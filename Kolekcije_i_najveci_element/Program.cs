using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_i_najveci_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Broj ponavljanja petlje: ");
            int n = int.Parse(Console.ReadLine());

            var stack = new Stack<long>();
            var rez = new StringBuilder();

            var maxHistory = new Stack<long>();
            maxHistory.Push(long.MinValue);

            for(int i = 0; i < n; i++)
            {
                Console.Write("Odaberite naredbu (1, 2 ili 3): ");
                int[] command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                switch (command[0])
                {
                    case 1:
                        if(command.Length > 1)
                        {
                            stack.Push(command[1]);
                            if (command[1] >= maxHistory.Peek())
                            {
                                maxHistory.Push(command[1]);
                            }
                        }
                        break;
                    case 2:
                        if(stack.Count > 0)
                        {
                            var popped = stack.Pop();

                            if(popped == maxHistory.Peek())
                            {
                                maxHistory.Pop();
                            }
                        }
                        break;
                    case 3:
                        rez.Append($"{maxHistory.Peek()}{Environment.NewLine}");
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(rez.ToString());
        }
    }
}
