using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.CheckedListBox;

namespace AplikacjaZawodnicy
{
    class Trener
    {
        public int Id_trenera;
        public string Imie_t;
        public string Nazwisko_t;
        public DateTime? Data_ur_t;

        public CheckedItemCollection cic;

        public string CalyTrener {
            get
            {
                string trener = "";
                if (cic.Contains("Imie"))
                    trener += Imie_t + " ";
                if (cic.Contains("Nazwisko"))
                    trener += Nazwisko_t + " ";
                if (cic.Contains("Data"))
                    trener += Data_ur_t + " ";

                return trener;
            }
        }

        public Trener() { }

        public Trener(CheckedItemCollection cic)
        {
            this.cic = cic;
        }
    }
}
