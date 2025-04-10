using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kolekcije_i_hijerarhija.Sucelja;

namespace Kolekcije_i_hijerarhija.Models
{
    public class DodajKolekciju<T> : IDodajKolekciju<T>
    {
        protected Stack<T> Podaci { get; set; }
        
        public DodajKolekciju()
        {
            Podaci = new Stack<T>();
        }
        public virtual int Dodaj(T element)
        {
            Podaci.Push(element);
            return Podaci.Count - 1;
        }
    }
}
