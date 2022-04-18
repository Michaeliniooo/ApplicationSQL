using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.CheckedListBox;

namespace AplikacjaZawodnicy
{
    class Zawodnik
    {
        public int Id_zawodnika;
        public int? Id_trenera; //dodanie "?" powoduje że typ jest "nullable" (przyjmuje null), robimy tak wtedy kiesy jakaś zmienna ma możliwość bycia nullem :>
        public string/*?*/ Imie; // string domyślnie jest nullable 
        public string Nazwisko;
        public string Kraj;
        public DateTime DataUrodzenia;
        public int Wzrost;
        public int Waga;

        private CheckedItemCollection soc;

        public string ImieNazwisko { get { return Imie + " " + Nazwisko + " " + Id_trenera; } }

        public string WybraneKolumny { 
            get 
            {
                string kolumny = "";
                if (soc.Contains("Imie"))
                    kolumny += Imie + " ";

                if (soc.Contains("Nazwisko"))
                    kolumny += Nazwisko + " ";

                if (soc.Contains("Kraj"))
                    kolumny += Kraj + " ";

                if (soc.Contains("Data"))
                    kolumny += DataUrodzenia.ToString("dd-mm-yyyy") + " ";

                if (soc.Contains("Waga"))
                    kolumny += Waga + " ";

                if (soc.Contains("Wzrost"))
                    kolumny += Wzrost + " ";

                return kolumny;
            }
        }

        public Zawodnik(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
 
        }
        public Zawodnik(string imie, string nazwisko, CheckedItemCollection soc)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            this.soc = soc;
        }

        public string PrzedstawSie()
        {
            return $"Nazywam {Imie} {Nazwisko} i pochodze z {Kraj}";
        }

    }
}
