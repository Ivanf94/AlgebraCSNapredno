using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_i_logika_jednakosti
{
    public class Osoba : IComparable<Osoba>
    {
        private string ime;
        private string prezime;
        private int dob;

        public Osoba(string ime, string prezime, int dob)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.dob = dob;
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public int Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        public int CompareTo(Osoba os)
        {
            var usporedba = this.prezime.CompareTo(os.prezime);
            if(usporedba == 0)
            {
                usporedba = this.ime.CompareTo(os.ime);
                if(usporedba == 0)
                {
                    usporedba = this.dob.CompareTo(os.dob);   
                }
            }
            return usporedba;
        }
    }
}
