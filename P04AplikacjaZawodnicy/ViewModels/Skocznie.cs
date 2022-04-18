using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.CheckedListBox;

namespace AplikacjaZawodnicy
{
    class Skocznie
    {
        public int Id_skoczni;
        public string Id_miasta;
        public string Nazwa_skoczni;
        public int? K;
        public int? Sedz;
        public string Kraj_skoczni;

        public CheckedItemCollection cll;

        public string CalaSkocznia {
            get
            {
                string kolumny = "";
                if (cll.Contains("Id_Miasta"))
                    kolumny += Id_miasta + " ";

                if (cll.Contains("Nazwa_Skoczni"))
                    kolumny += Nazwa_skoczni + " ";

                if (cll.Contains("K"))
                    kolumny += K + " ";

                if (cll.Contains("Sedz"))
                    kolumny += Sedz + " ";

                if (cll.Contains("Kraj_Skoczni"))
                    kolumny += Kraj_skoczni + " ";

                return kolumny;
            }
        }

        public Skocznie(CheckedItemCollection cll)
        {
            this.cll = cll;
        }

        public Skocznie()
        {

        }
    }
}
