using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sucelja_ali_eksplicitna.Models;
using Sucelja_ali_eksplicitna.Sucelja;

namespace Sucelja_ali_eksplicitna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintajImenaSDrugacijimInterfejsom();
            PrintajImenaSTypeCastingom();
        }

        private static void PrintajImenaSTypeCastingom()
        {
            do
            {
                Console.Write("Unesite ime i prezime (unesite \"kraj\" za kraj): ");
                var unos = Console.ReadLine().Split();
                if (unos[0] == "kraj") break;

                Gradjanin osoba = new Gradjanin(unos[0], unos[1]);
                //Console.WriteLine(osoba.DohvatImePrezime());
                Console.WriteLine(((IOsoba)osoba).DohvatiImePrezime());
                Console.WriteLine(((IStanovnik)osoba).DohvatiImePrezime());

                IOsoba os = osoba;
                IStanovnik st = osoba;
                Console.WriteLine(os.DohvatiImePrezime());
                Console.WriteLine(st.DohvatiImePrezime());
            } while (true);
        }
        private static void PrintajImenaSDrugacijimInterfejsom()
        {
            while (true)
            {
                Console.Write("Unesite ime i prezime (unesite \"kraj\" za kraj): ");
                var unos = Console.ReadLine().Split();
                if (unos[0] == "kraj") break;

                IOsoba os = new Gradjanin(unos[0], unos[1]);
                Console.WriteLine(os.DohvatiImePrezime());

                IStanovnik st = new Gradjanin(unos[0], unos[1]);
                Console.WriteLine(st.DohvatiImePrezime());
            }
        }
    }
}
