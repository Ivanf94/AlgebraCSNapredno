using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_sa_svojstvima_klase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Polaznik> detalji = new List<Polaznik>()
            {
                new Polaznik{Id=1, Ime="Nikola", Prezime="Tesla"},
                new Polaznik{Id=2, Ime="Isac", Prezime="Newton"},
                new Polaznik{Id=3, Ime="Mićo", Prezime="Programerić", Status_polaznika=false},
                new Polaznik{Id=4, Ime="Ivana", Prezime="Brlić-Mažuranić"},
                new Polaznik{Id=5, Ime="Anita", Prezime="Programerić", Status_polaznika=false}
            };

            var sortirani = detalji.OrderBy(x => x.Ime).ToList();
            Console.WriteLine("Sortirani polaznici:");
            foreach(Polaznik p in sortirani)
            {
                Console.WriteLine(p.Id+" "+p.Ime+" "+p.Prezime);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Kreiranje nove liste samo s inicijalima polaznika:
            var detalji_s_inicijalima = detalji.Select(x => new { Id = x.Id, SlovoImena = x.Ime[0], SlovoPrezimena = x.Prezime[0] });
            foreach(var p in detalji_s_inicijalima)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Samo aktivni polaznici
            var samo_aktivni = detalji.Where(x => x.Status_polaznika == true);
            Console.WriteLine("Aktivni polaznici su: ");
            foreach(var p in samo_aktivni)
            {
                Console.WriteLine(p.Id+" "+p.Ime+" "+p.Prezime);
            }
        }
    }
}
