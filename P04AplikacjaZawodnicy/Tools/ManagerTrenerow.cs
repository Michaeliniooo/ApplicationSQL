using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.CheckedListBox;

namespace AplikacjaZawodnicy
{
    class ManagerTrenerow
    {
        public Trener[] tabTrenerow;

        public void Wczytaj(CheckedItemCollection cic)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();

            object[][] wynik = pzb.WykonajZapytanieSQL("select * from trenerzy");
            
            tabTrenerow = new Trener[wynik.Length];

            for (int i = 0; i < wynik.Length; i++)
            {
                Trener t = new Trener(cic);

                t.Id_trenera = (int)wynik[i][0];
                t.Imie_t = (string)wynik[i][1];
                t.Nazwisko_t = (string)wynik[i][2];
                if(!(wynik[i][3] is DBNull))
                    t.Data_ur_t = (DateTime)wynik[i][3];

                tabTrenerow[i] = t;

            }
        }

        public void Zapisz(Trener t)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();
            object[][] fields = pzb.WykonajZapytanieSQL("select * from trenerzy");

            DateTime? data = null;
            if (!(t.Data_ur_t is null))
                data = t.Data_ur_t;
            
            

            string sql = string.Format("insert into trenerzy values ({0}, '{1}', '{2}', null)",
                fields.Length + 1, t.Imie_t, t.Nazwisko_t, data);

            pzb.WykonajZapytanieSQL(sql);
        }

        public void Usun(Trener t)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();

            string sql = $"delete trenerzy where id_trenera = {t.Id_trenera}";

            pzb.WykonajZapytanieSQL(sql);

        }

        public void Edytuj(Trener t)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();

            string sql = string.Format("update trenerzy set imie_t = '{0}', nazwisko_t = '{1}' where id_trenera = {2}",
                t.Imie_t, t.Nazwisko_t, t.Id_trenera);

            pzb.WykonajZapytanieSQL(sql);
        }
    }
}
