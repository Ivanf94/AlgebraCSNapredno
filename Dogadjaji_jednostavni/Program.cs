using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_jednostavni
{
    public delegate void DelegateEventHandler();
    internal class Program
    {
        public static event DelegateEventHandler Dodaj;
        static void Main(string[] args)
        {
            Dodaj += new DelegateEventHandler(Njemacka);
            Dodaj += new DelegateEventHandler(Slovenija);
            Dodaj += new DelegateEventHandler(Filipini);

            Dodaj.Invoke();
        }

        static void Njemacka()
        {
            Console.WriteLine("Njemačka");
        }

        static void Slovenija()
        {
            Console.WriteLine("Slovenija");
        }

        static void Filipini()
        {
            Console.WriteLine("Filipini");
        }
    }
}
