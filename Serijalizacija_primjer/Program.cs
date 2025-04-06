using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Serijalizacija_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polaznik p = new Polaznik { ID = 1, Ime = "Mirko" };

            IFormatter formatiraj = new BinaryFormatter();
            Stream pohrani = new FileStream("primjer.txt", FileMode.Create, FileAccess.Write);

            formatiraj.Serialize(pohrani, p);
            pohrani.Close();

            pohrani = new FileStream("primjer.txt", FileMode.Open, FileAccess.Read);
            Polaznik novi = (Polaznik)formatiraj.Deserialize(pohrani);

            Console.WriteLine("ID: "+novi.ID);
            Console.WriteLine("Ime: "+novi.Ime);
        }
    }
}
