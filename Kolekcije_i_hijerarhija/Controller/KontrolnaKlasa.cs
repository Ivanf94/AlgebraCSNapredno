using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kolekcije_i_hijerarhija.Models;
using Kolekcije_i_hijerarhija.Sucelja;

namespace Kolekcije_i_hijerarhija.Controller
{
    public class KontrolnaKlasa
    {
        private IDodajKolekciju<string> dodaj_kolekciju;
        private IDodajUkloniKolekciju<string> dodaj_ukloni_kolekciju;
        private IMojaLista<string> moja_lista;
        private StringBuilder rezultat_za_ispis;

        public KontrolnaKlasa()
        {
            dodaj_kolekciju = new DodajKolekciju<string>();
            dodaj_ukloni_kolekciju = new DodajUkloniKolekciju<string>();
            moja_lista = new MojaLista<string>();
            rezultat_za_ispis = new StringBuilder();
        }

        public void PokreniProces()
        {
            Console.Write("Unesite nekoliko riječi ili dužu rečenicu: ");
            var ulaz = Console.ReadLine().Split();
            PopuniKolekciju(ref ulaz, dodaj_kolekciju);
            PopuniKolekciju(ref ulaz, dodaj_ukloni_kolekciju);
            PopuniKolekciju(ref ulaz, moja_lista);

            Console.Write("Unesite broj elemenata za uklanjanje: ");
            int broj = int.Parse(Console.ReadLine());
            OperacijaUklanjanja(broj, dodaj_ukloni_kolekciju);
            OperacijaUklanjanja(broj, moja_lista);

            Console.WriteLine(rezultat_za_ispis.ToString());
        }

        private void OperacijaUklanjanja<T>(int broj_elemenata_za_uklanjanje, IDodajUkloniKolekciju<T> kolekcija)
        {
            while(broj_elemenata_za_uklanjanje > 0)
            {
                var removed_element = kolekcija.Ukloni();
                rezultat_za_ispis.Append($"{removed_element} ");
                broj_elemenata_za_uklanjanje--;
            }

            rezultat_za_ispis.Remove(rezultat_za_ispis.Length - 1, 1).AppendLine();
        }

        private void PopuniKolekciju(ref string[] input, IDodajKolekciju<string> kolekcija)
        {
            foreach(var s in input)
            {
                var index = kolekcija.Dodaj(s);
                rezultat_za_ispis.Append($"{index} ");
            }
            rezultat_za_ispis.Remove(this.rezultat_za_ispis.Length - 1, 1).AppendLine();
        }
    }
}
