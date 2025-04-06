using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Serijalizacija.Library
{
    public class MetodeZaSerijalizaciju
    {
        public void SerijalizirajNesto()
        {
            KlasaZaSerijalizaciju[] kzs = new KlasaZaSerijalizaciju[3];
            kzs[0] = new KlasaZaSerijalizaciju();
            kzs[0].Godine = 33;
            kzs[0].Ime = "Mirko";
            kzs[0].Prezime = "Mirkić";
            kzs[1] = new KlasaZaSerijalizaciju();
            kzs[1].Godine = 44;
            kzs[1].Ime = "Ana";
            kzs[1].Prezime = "Anić";
            kzs[2] = new KlasaZaSerijalizaciju();
            kzs[2].Godine = 55;
            kzs[2].Ime = "Božo";
            kzs[2].Prezime = "Božić";

            IFormatter format = new BinaryFormatter();
            Stream pohrani = new FileStream("primjer.dat", FileMode.Create);

            format.Serialize(pohrani, kzs);
            pohrani.Close();
        }

        public void DeserijalizirajNesto()
        {
            KlasaZaSerijalizaciju[] kzs;

            IFormatter format = new BinaryFormatter();
            Stream procitaj = new FileStream("primjer.dat", FileMode.Open);
            kzs = (KlasaZaSerijalizaciju[])format.Deserialize(procitaj);
            procitaj.Close();

            Console.WriteLine("Deserijalizirano: ");
            foreach(var item in kzs)
            {
                Console.WriteLine(item.Ime+" "+item.Prezime+" "+item.Godine);
            }
        }
    }
}
