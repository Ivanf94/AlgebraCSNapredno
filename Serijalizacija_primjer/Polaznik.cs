using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serijalizacija_primjer
{
    [Serializable]
    public class Polaznik
    {
        public int ID { get; set; }
        public string Ime {  get; set; }
    }
}
