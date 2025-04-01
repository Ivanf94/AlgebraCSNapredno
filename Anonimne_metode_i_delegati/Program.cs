using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonimne_metode_i_delegati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Zaposlenik> zaposlenici = new List<Zaposlenik>()
            {
                new Zaposlenik{ID=101,Ime="Ana",Prezime="Anić",Spol="Žensko",Placa=1000},
                new Zaposlenik{ID=102,Ime="Iva",Prezime="Ivić",Spol="Žensko",Placa=2000},
                new Zaposlenik{ID=103,Ime="Nikola",Prezime="Tesla",Spol="Žensko",Placa=2300},
                new Zaposlenik{ID=104,Ime="Colin",Prezime="McRae",Spol="Žensko",Placa=10000},
                new Zaposlenik{ID=104,Ime="Ayton",Prezime="Senna",Spol="Žensko",Placa=15000},
            };

            Zaposlenik zap = zaposlenici.Find(
                    delegate (Zaposlenik x)
                    {
                        return x.ID == 103;
                    }
                );
            Console.WriteLine(zap.ID+" "+zap.Ime+" "+zap.Prezime+" "+zap.Spol+" "+zap.Placa);

            zap = zaposlenici.Find(x => x.ID == 103);
        }
    }

    public class Zaposlenik
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Spol { get; set; }
        public double Placa { get; set; }
    }
}
