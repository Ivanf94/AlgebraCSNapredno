using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dogadjaji_semafor
{
    internal class Program
    {
        public delegate void SvjetlaNaSemaforu(byte semafor);

        public static event SvjetlaNaSemaforu SvjetlaSemaforaDogadjaj;
        static void Main(string[] args)
        {
            Console.WriteLine("Križanje sa 4 semafora:");
            Console.WriteLine();

            SvjetlaSemaforaDogadjaj += new SvjetlaNaSemaforu(CrvenoSvjetlo);
            Status(1, 3);

            SvjetlaSemaforaDogadjaj -= new SvjetlaNaSemaforu(CrvenoSvjetlo);
            SvjetlaSemaforaDogadjaj += new SvjetlaNaSemaforu(ZelenoSvjetlo);
            Status(2, 4);

            Thread.Sleep(5000);

            SvjetlaSemaforaDogadjaj -= new SvjetlaNaSemaforu(ZelenoSvjetlo);
            SvjetlaSemaforaDogadjaj += new SvjetlaNaSemaforu(ZutoSvjetlo);
            Status(1, 3);
            Status(2, 4);

            Thread.Sleep(5000);

            SvjetlaSemaforaDogadjaj -= new SvjetlaNaSemaforu(ZutoSvjetlo);
            SvjetlaSemaforaDogadjaj += new SvjetlaNaSemaforu(ZelenoSvjetlo);
            Status(1, 3);

            SvjetlaSemaforaDogadjaj -= new SvjetlaNaSemaforu(ZelenoSvjetlo);
            SvjetlaSemaforaDogadjaj += new SvjetlaNaSemaforu(CrvenoSvjetlo);
            Status(2, 4);
        }

        static void ZelenoSvjetlo(byte semafor)
        {
            Console.WriteLine("Svjetlo na semaforu {0} : Zeleno", semafor);
        }

        static void ZutoSvjetlo(byte semafor)
        {
            Console.WriteLine("Svjetlo na semaforu {0} : Žuto", semafor);
        }

        static void CrvenoSvjetlo(byte semafor)
        {
            Console.WriteLine("Svjetlo na semaforu {0} : Crveno", semafor);
        }

        static void Status(byte s1, byte s2)
        {
            if(SvjetlaSemaforaDogadjaj != null)
            {
                SvjetlaSemaforaDogadjaj(s1);
                SvjetlaSemaforaDogadjaj(s2);
            }
        }
    }
}
