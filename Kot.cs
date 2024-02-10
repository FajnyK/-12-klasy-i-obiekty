using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_klasy_i_obiekty
{
    internal class Kot
    {
        public string imie = "brak danych";
        public int wiek;
        public float waga;
        public string kolorOczu;
        public string kolorSiersci;
        public int iloscmyszy;

        public void PokazInformacje()
        {
            Console.WriteLine($"imie: {imie} \nwiek: {wiek} \nwaga: {waga} " +
                $"\nkolor oczu: {kolorOczu} \nkolor siersci: {kolorSiersci}");
        }
    }
}
