using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.CheckedListBox;

namespace AplikacjaZawodnicy
{
    class ManagerZawodników
    {
        // przeniosłem connection string do klasy PolaczenieZBaza

        public Zawodnik[] tabZawodnicy;


        public void Wczytaj(CheckedItemCollection soc)
        {
            
            PolaczenieZBaza pzb = new PolaczenieZBaza();

            object[][] wynik = pzb.WykonajZapytanieSQL("select * from zawodnicy");

            tabZawodnicy = new Zawodnik[wynik.Length];

            for (int i = 0; i < wynik.Length; i++) // proces mapowania postaci tabelkowej na postać obiektową (tablice obiektów)
            {
                Zawodnik z = new Zawodnik((string)wynik[i][2], (string)wynik[i][3], soc);

                z.Id_zawodnika = (int)wynik[i][0];

                if (!(wynik[i][1] is DBNull))// sprawdzamy czy nasz wynik jest NULLem z baz danych ("DBNull")
                    z.Id_trenera = (int)wynik[i][1];

                //try mozna zrobić try catch żeby obsłużyć ten problem
                //{
                //    z.Id_trenera = (int)wynik[i][1];
                //}
                //catch (Exception)
                //{
                //    
                //} // NULL w bazach danych to nie to samo co NULL w c# przez to są problemy

                z.Kraj = (string)wynik[i][4];
                z.DataUrodzenia = (DateTime)wynik[i][5];
                z.Wzrost = (int)wynik[i][6];
                z.Waga = (int)wynik[i][7];

                tabZawodnicy[i] = z;
            }

        }
        public void Dodaj(Zawodnik z)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();

            string sql = string.Format("insert into zawodnicy values (null,'{0}','{1}','{2}','{3}',{4},{5})", 
                z.Imie,z.Nazwisko,z.Kraj,z.DataUrodzenia,z.Wzrost,z.Waga);

            pzb.WykonajZapytanieSQL(sql);

        }

        public void Edytuj(Zawodnik z)
        {

            PolaczenieZBaza pzb = new PolaczenieZBaza();
            pzb.WykonajZapytanieSQL(string.Format("update zawodnicy set imie = '{0}', nazwisko = '{1}', kraj = '{2}', data_ur = '{3}', wzrost = {4}, waga = {5} where id_zawodnika = {6}",
                z.Imie,z.Nazwisko,z.Kraj,z.DataUrodzenia,z.Wzrost,z.Waga,z.Id_zawodnika));

        }

        public void Usun(int id)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();
            pzb.WykonajZapytanieSQL($"delete zawodnicy where id_zawodnika={id}");
        }
    }
}
