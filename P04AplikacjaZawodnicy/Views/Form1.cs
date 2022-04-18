using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;
using static System.Windows.Forms.ListBox;

namespace AplikacjaZawodnicy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Odswierz(string page)
        {
            switch (page)
            {
                case "Zawodnicy":
                    ManagerZawodników mgZ = new ManagerZawodników();
                    CheckedItemCollection soc = chbListKolumny.CheckedItems;
                    mgZ.Wczytaj(soc);

                    lbDane.DataSource = mgZ.tabZawodnicy;
                    lbDane.DisplayMember = "WybraneKolumny";

                    break;

                case "Skocznie":
                    ManagerSkoczni mgS = new ManagerSkoczni();
                    CheckedItemCollection cic = chbListSkocznie.CheckedItems;
                    mgS.Wczytaj(cic);

                    lbSkocznie.DataSource = mgS.tabSkoczni;
                    lbSkocznie.DisplayMember = "CalaSkocznia";
                    break;


                case "Trenerzy":
                    ManagerTrenerow mgT = new ManagerTrenerow();
                    CheckedItemCollection cll = chbListTrenerzy.CheckedItems;

                    mgT.Wczytaj(cll);

                    blTrenerzy.DataSource = mgT.tabTrenerow;
                    blTrenerzy.DisplayMember = "CalyTrener";

                    break;
            }
        }

        private Zawodnik ZczytajZawodnika()
        {
        
            Zawodnik z = new Zawodnik(txtImie.Text, txtNazwisko.Text);

            z.Kraj = txtKraj.Text;
            z.Waga = Convert.ToInt32(txtWaga.Text);
            z.Wzrost = Convert.ToInt32(txtWzrost.Text);
            z.DataUrodzenia = Convert.ToDateTime(dtpData.Value);

            return z;
        }

        private Skocznie ZczytajSkocznie()
        {
            Skocznie s = new Skocznie();

            s.Id_miasta = txtIdMiasta.Text;
            s.Nazwa_skoczni = txtNazwa_Skoczni.Text;
            s.K = Convert.ToInt32(txtK.Text);
            s.Sedz = Convert.ToInt32(txtSedz.Text);
            s.Kraj_skoczni = txtKraj_Skoczni.Text;

            return s;
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswierz("Zawodnicy");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Zawodnik z = ZczytajZawodnika();

            ManagerZawodników mgZ = new ManagerZawodników();
            mgZ.Dodaj(z);
            Odswierz("Zawodnicy");
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            Zawodnik z = ZczytajZawodnika();
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;
            z.Id_zawodnika = zaznaczony.Id_zawodnika;

            ManagerZawodników mgZ = new ManagerZawodników();
            mgZ.Edytuj(z);
            Odswierz("Zawodnicy");
        }

        private void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;

            txtImie.Text = zaznaczony.Imie;
            txtNazwisko.Text = zaznaczony.Nazwisko;
            txtWaga.Text = Convert.ToString(zaznaczony.Waga);
            txtWzrost.Text = Convert.ToString(zaznaczony.Wzrost);
            txtKraj.Text = zaznaczony.Kraj;
            dtpData.Value = zaznaczony.DataUrodzenia;

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;
            ManagerZawodników mgZ = new ManagerZawodników();
            mgZ.Usun(zaznaczony.Id_zawodnika);
            Odswierz("Zawodnicy");
                
        }

        private void btnWczytaj_Skocznie_Click(object sender, EventArgs e)
        {
            Odswierz("Skocznie");
        }

        private void btnZapisz_Skocznie_Click(object sender, EventArgs e)
        {
            ManagerSkoczni mgS = new ManagerSkoczni();
            mgS.Zapisz(ZczytajSkocznie());

            Odswierz("Skocznie");
        }

        private void btnUsun_Skocznie_Click(object sender, EventArgs e)
        {
            Skocznie s = (Skocznie)lbSkocznie.SelectedItem;
            ManagerSkoczni mgS = new ManagerSkoczni();
            mgS.Usun(s.Id_skoczni);
            Odswierz("Skocznie");
        }

        private void btnEdytuj_Skocznie_Click(object sender, EventArgs e)
        {
            Skocznie s = ZczytajSkocznie();
            Skocznie zaznaczona = (Skocznie)lbSkocznie.SelectedItem;

            ManagerSkoczni mgS = new ManagerSkoczni();

            mgS.Edytuj(zaznaczona.Id_skoczni,s);

            Odswierz("Skocznie");

        }

        private void lbSkocznie_SelectedIndexChanged(object sender, EventArgs e)
        {
            Skocznie zaznaczona = (Skocznie)lbSkocznie.SelectedItem;

            txtIdMiasta.Text = zaznaczona.Id_miasta;
            txtNazwa_Skoczni.Text = zaznaczona.Nazwa_skoczni;
            txtK.Text = Convert.ToString(zaznaczona.K);
            txtSedz.Text = Convert.ToString(zaznaczona.Sedz);
            txtKraj_Skoczni.Text = zaznaczona.Kraj_skoczni;
        }

        private void btnWczytaj_Trenerzy_Click(object sender, EventArgs e)
        {
            Odswierz("Trenerzy");

        }

        private Trener WczytajTrenera()
        {
            Trener t = new Trener();

            t.Imie_t = txtImie_Trenerzy.Text;
            t.Nazwisko_t = txtNazwisko_Trenerzy.Text;
            t.Data_ur_t = dtpData_Trenerzy.Value;

            return t;
        }

        private void btnZapisz_Trenerzy_Click(object sender, EventArgs e)
        {
            ManagerTrenerow mgT = new ManagerTrenerow();
            mgT.Zapisz(WczytajTrenera());

            Odswierz("Trenerzy");
        }

        private void btnUsun_Trenerzy_Click(object sender, EventArgs e)
        {
            Trener zaznaczony = (Trener)blTrenerzy.SelectedItem;

            ManagerTrenerow mgT = new ManagerTrenerow();
            mgT.Usun(zaznaczony);

            Odswierz("Trenerzy");

        }

        private void btnEdytuj_Trenerzy_Click(object sender, EventArgs e)
        {
            Trener zaznaczony = (Trener)blTrenerzy.SelectedItem;
            Trener t = WczytajTrenera();
            t.Id_trenera = zaznaczony.Id_trenera;

            ManagerTrenerow mgT = new ManagerTrenerow();
            mgT.Edytuj(t);

            Odswierz("Trenerzy");

        }

        private void blTrenerzy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trener t = (Trener)blTrenerzy.SelectedItem;

            txtImie_Trenerzy.Text = t.Imie_t;
            txtNazwisko_Trenerzy.Text = t.Nazwisko_t;
            //dtpData_Trenerzy.Value = t.Data_ur_t;
        }
    }
}
