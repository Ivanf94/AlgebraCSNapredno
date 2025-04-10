using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kolekcije_i_hijerarhija.Sucelja;

namespace Kolekcije_i_hijerarhija.Models
{
    public class MojaLista<T> : DodajUkloniKolekciju<T>, IMojaLista<T>
    {
        public IReadOnlyCollection<T> Used
        {
            get
            {
                return Podaci as IReadOnlyCollection<T>;
            }
        }

        public override T Ukloni()
        {
            var prvi = Podaci.Last();
            Podaci = new Stack<T>(Podaci.Take(this.Podaci.Count - 1).Reverse());
            return prvi;
        }
    }
}
