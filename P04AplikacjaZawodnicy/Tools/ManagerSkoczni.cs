using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.CheckedListBox;

namespace AplikacjaZawodnicy
{
    class ManagerSkoczni
    {

        public Skocznie[] tabSkoczni;

        public void Wczytaj(CheckedItemCollection cll)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();
            object[][] wynik = pzb.WykonajZapytanieSQL("select * from skocznie");

            tabSkoczni = new Skocznie[wynik.Length - 1];

            for (int i = 1; i < wynik.Length; i++)
            {
                Skocznie s = new Skocznie(cll);

                if (!(wynik[i][0] is DBNull))
                    s.Id_skoczni = (int)wynik[i][0];

                if (!(wynik[i][1] is DBNull))
                    s.Id_miasta = (string)wynik[i][1];

                if (!(wynik[i][2] is DBNull))
                    s.Nazwa_skoczni = (string)wynik[i][2];

                if (!(wynik[i][3] is DBNull))
                    s.K = (int)wynik[i][3];

                if (!(wynik[i][4] is DBNull))
                    s.Sedz = (int)wynik[i][4];
                if (!(wynik[i][5] is DBNull))
                    s.Kraj_skoczni = (string)wynik[i][5];


                tabSkoczni[i - 1] = s;
            }
        }

        public void Zapisz(Skocznie s)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();
            object[][] fields = pzb.WykonajZapytanieSQL("select * from skocznie");



            string sql = string.Format("insert into skocznie values ({5}, '{0}', '{1}', {2}, {3}, '{4}')",
                s.Id_miasta, s.Nazwa_skoczni, s.K, s.Sedz, s.Kraj_skoczni, fields.Length);

            pzb.WykonajZapytanieSQL(sql);
        }

        public void Usun(int id)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();

            string sql = $"delete skocznie where id_skoczni={id}";

            pzb.WykonajZapytanieSQL(sql);
        }

        public void Edytuj(int id, Skocznie s)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();

            string sql = string.Format("update skocznie set id_miasta = '{0}', nazwa_skoczni = '{1}', k = {2}, sedz = {3}, kraj_skoczni = '{4}' WHERE id_skoczni = {5}",
                s.Id_miasta,s.Nazwa_skoczni,s.K,s.Sedz,s.Kraj_skoczni,id);

            pzb.WykonajZapytanieSQL(sql);
        }

    }
}
