using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exstension_methods_i_interfaces
{
    public interface IMojInterface
    {
        void MetodaB();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.MetodaA(2);
            a.MetodaA("pozdrav");

            a.MetodaB();

            b.MetodaA(1);
            b.MetodaB();

            b.MetodaA(":)");

            c.MetodaA(1);
            c.MetodaA("sup");
            c.MetodaB();
        }
    }

    class A : IMojInterface
    {
        public void MetodaB() { Console.WriteLine("A.MetodaB()"); }
    }

    class B : IMojInterface
    {
        public void MetodaB() { Console.WriteLine("B.MetodaB()"); }
        public void MetodaA(int i) { Console.WriteLine("B.MetodaA(int i)"); }
    }

    class C : IMojInterface
    {
        public void MetodaB() { Console.WriteLine("C.MetodaB()"); }
        public void MetodaA(object o)
        {
            Console.WriteLine("C.MetodaA(object o)");
        }
    }
}
