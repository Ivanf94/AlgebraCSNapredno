using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kolekcije_i_hijerarhija.Sucelja;

namespace Kolekcije_i_hijerarhija.Models
{
    public class DodajUkloniKolekciju<T> : DodajKolekciju<T>, IDodajUkloniKolekciju<T>
    {
        private const int IndexZaDodavanjeNovogElementa = 0;
        public virtual T Ukloni()
        {
            return this.Podaci.Pop();
        }

        public override int Dodaj(T element)
        {
            Podaci = new Stack<T>(new T[] { element }.Concat(Podaci.Reverse()));
            return IndexZaDodavanjeNovogElementa;
        }
    }
}
