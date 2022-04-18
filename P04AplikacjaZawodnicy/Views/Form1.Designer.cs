
namespace AplikacjaZawodnicy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.txtWzrost = new System.Windows.Forms.TextBox();
            this.txtWaga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.chbListKolumny = new System.Windows.Forms.CheckedListBox();
            this.tbcTabeka = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.blTrenerzy = new System.Windows.Forms.ListBox();
            this.chbListTrenerzy = new System.Windows.Forms.CheckedListBox();
            this.btnWczytaj_Trenerzy = new System.Windows.Forms.Button();
            this.btnUsun_Trenerzy = new System.Windows.Forms.Button();
            this.txtImie_Trenerzy = new System.Windows.Forms.TextBox();
            this.btnEdytuj_Trenerzy = new System.Windows.Forms.Button();
            this.txtNazwisko_Trenerzy = new System.Windows.Forms.TextBox();
            this.btnZapisz_Trenerzy = new System.Windows.Forms.Button();
            this.dtpData_Trenerzy = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbSkocznie = new System.Windows.Forms.ListBox();
            this.chbListSkocznie = new System.Windows.Forms.CheckedListBox();
            this.btnWczytaj_Skocznie = new System.Windows.Forms.Button();
            this.btnUsun_Skocznie = new System.Windows.Forms.Button();
            this.txtIdMiasta = new System.Windows.Forms.TextBox();
            this.btnEdytuj_Skocznie = new System.Windows.Forms.Button();
            this.txtNazwa_Skoczni = new System.Windows.Forms.TextBox();
            this.btnZapisz_Skocznie = new System.Windows.Forms.Button();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtSedz = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKraj_Skoczni = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbcTabeka.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(6, 57);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(362, 303);
            this.lbDane.TabIndex = 0;
            this.lbDane.SelectedIndexChanged += new System.EventHandler(this.lbDane_SelectedIndexChanged);
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(6, 12);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(440, 57);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(101, 20);
            this.txtImie.TabIndex = 2;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(440, 83);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(101, 20);
            this.txtNazwisko.TabIndex = 3;
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(440, 109);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(101, 20);
            this.txtKraj.TabIndex = 4;
            // 
            // txtWzrost
            // 
            this.txtWzrost.Location = new System.Drawing.Point(440, 187);
            this.txtWzrost.Name = "txtWzrost";
            this.txtWzrost.Size = new System.Drawing.Size(101, 20);
            this.txtWzrost.TabIndex = 7;
            // 
            // txtWaga
            // 
            this.txtWaga.Location = new System.Drawing.Point(440, 161);
            this.txtWaga.Name = "txtWaga";
            this.txtWaga.Size = new System.Drawing.Size(101, 20);
            this.txtWaga.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "DataUr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kraj";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Wzrost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Waga";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(440, 135);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(101, 20);
            this.dtpData.TabIndex = 16;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(440, 213);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 17;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(553, 212);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnEdytuj.TabIndex = 18;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(440, 277);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 19;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // chbListKolumny
            // 
            this.chbListKolumny.FormattingEnabled = true;
            this.chbListKolumny.Items.AddRange(new object[] {
            "Imie",
            "Nazwisko",
            "Kraj",
            "Data",
            "Waga",
            "Wzrost"});
            this.chbListKolumny.Location = new System.Drawing.Point(553, 54);
            this.chbListKolumny.Name = "chbListKolumny";
            this.chbListKolumny.Size = new System.Drawing.Size(148, 124);
            this.chbListKolumny.TabIndex = 20;
            // 
            // tbcTabeka
            // 
            this.tbcTabeka.Controls.Add(this.tabPage1);
            this.tbcTabeka.Controls.Add(this.tabPage2);
            this.tbcTabeka.Controls.Add(this.tabPage3);
            this.tbcTabeka.Location = new System.Drawing.Point(12, 12);
            this.tbcTabeka.Name = "tbcTabeka";
            this.tbcTabeka.SelectedIndex = 0;
            this.tbcTabeka.Size = new System.Drawing.Size(885, 414);
            this.tbcTabeka.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbDane);
            this.tabPage1.Controls.Add(this.chbListKolumny);
            this.tabPage1.Controls.Add(this.btnWczytaj);
            this.tabPage1.Controls.Add(this.btnUsun);
            this.tabPage1.Controls.Add(this.txtImie);
            this.tabPage1.Controls.Add(this.btnEdytuj);
            this.tabPage1.Controls.Add(this.txtNazwisko);
            this.tabPage1.Controls.Add(this.btnZapisz);
            this.tabPage1.Controls.Add(this.txtKraj);
            this.tabPage1.Controls.Add(this.dtpData);
            this.tabPage1.Controls.Add(this.txtWaga);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtWzrost);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(877, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zawodnicy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.blTrenerzy);
            this.tabPage2.Controls.Add(this.chbListTrenerzy);
            this.tabPage2.Controls.Add(this.btnWczytaj_Trenerzy);
            this.tabPage2.Controls.Add(this.btnUsun_Trenerzy);
            this.tabPage2.Controls.Add(this.txtImie_Trenerzy);
            this.tabPage2.Controls.Add(this.btnEdytuj_Trenerzy);
            this.tabPage2.Controls.Add(this.txtNazwisko_Trenerzy);
            this.tabPage2.Controls.Add(this.btnZapisz_Trenerzy);
            this.tabPage2.Controls.Add(this.dtpData_Trenerzy);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(877, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trenerzy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // blTrenerzy
            // 
            this.blTrenerzy.FormattingEnabled = true;
            this.blTrenerzy.Location = new System.Drawing.Point(6, 51);
            this.blTrenerzy.Name = "blTrenerzy";
            this.blTrenerzy.Size = new System.Drawing.Size(362, 303);
            this.blTrenerzy.TabIndex = 21;
            this.blTrenerzy.SelectedIndexChanged += new System.EventHandler(this.blTrenerzy_SelectedIndexChanged);
            // 
            // chbListTrenerzy
            // 
            this.chbListTrenerzy.FormattingEnabled = true;
            this.chbListTrenerzy.Items.AddRange(new object[] {
            "Imie",
            "Nazwisko",
            "Data"});
            this.chbListTrenerzy.Location = new System.Drawing.Point(553, 48);
            this.chbListTrenerzy.Name = "chbListTrenerzy";
            this.chbListTrenerzy.Size = new System.Drawing.Size(148, 124);
            this.chbListTrenerzy.TabIndex = 38;
            // 
            // btnWczytaj_Trenerzy
            // 
            this.btnWczytaj_Trenerzy.Location = new System.Drawing.Point(6, 6);
            this.btnWczytaj_Trenerzy.Name = "btnWczytaj_Trenerzy";
            this.btnWczytaj_Trenerzy.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj_Trenerzy.TabIndex = 22;
            this.btnWczytaj_Trenerzy.Text = "Wczytaj";
            this.btnWczytaj_Trenerzy.UseVisualStyleBackColor = true;
            this.btnWczytaj_Trenerzy.Click += new System.EventHandler(this.btnWczytaj_Trenerzy_Click);
            // 
            // btnUsun_Trenerzy
            // 
            this.btnUsun_Trenerzy.Location = new System.Drawing.Point(440, 271);
            this.btnUsun_Trenerzy.Name = "btnUsun_Trenerzy";
            this.btnUsun_Trenerzy.Size = new System.Drawing.Size(75, 23);
            this.btnUsun_Trenerzy.TabIndex = 37;
            this.btnUsun_Trenerzy.Text = "Usuń";
            this.btnUsun_Trenerzy.UseVisualStyleBackColor = true;
            this.btnUsun_Trenerzy.Click += new System.EventHandler(this.btnUsun_Trenerzy_Click);
            // 
            // txtImie_Trenerzy
            // 
            this.txtImie_Trenerzy.Location = new System.Drawing.Point(440, 51);
            this.txtImie_Trenerzy.Name = "txtImie_Trenerzy";
            this.txtImie_Trenerzy.Size = new System.Drawing.Size(101, 20);
            this.txtImie_Trenerzy.TabIndex = 23;
            // 
            // btnEdytuj_Trenerzy
            // 
            this.btnEdytuj_Trenerzy.Location = new System.Drawing.Point(553, 206);
            this.btnEdytuj_Trenerzy.Name = "btnEdytuj_Trenerzy";
            this.btnEdytuj_Trenerzy.Size = new System.Drawing.Size(75, 23);
            this.btnEdytuj_Trenerzy.TabIndex = 36;
            this.btnEdytuj_Trenerzy.Text = "Edytuj";
            this.btnEdytuj_Trenerzy.UseVisualStyleBackColor = true;
            this.btnEdytuj_Trenerzy.Click += new System.EventHandler(this.btnEdytuj_Trenerzy_Click);
            // 
            // txtNazwisko_Trenerzy
            // 
            this.txtNazwisko_Trenerzy.Location = new System.Drawing.Point(440, 77);
            this.txtNazwisko_Trenerzy.Name = "txtNazwisko_Trenerzy";
            this.txtNazwisko_Trenerzy.Size = new System.Drawing.Size(101, 20);
            this.txtNazwisko_Trenerzy.TabIndex = 24;
            // 
            // btnZapisz_Trenerzy
            // 
            this.btnZapisz_Trenerzy.Location = new System.Drawing.Point(440, 207);
            this.btnZapisz_Trenerzy.Name = "btnZapisz_Trenerzy";
            this.btnZapisz_Trenerzy.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz_Trenerzy.TabIndex = 35;
            this.btnZapisz_Trenerzy.Text = "Zapisz";
            this.btnZapisz_Trenerzy.UseVisualStyleBackColor = true;
            this.btnZapisz_Trenerzy.Click += new System.EventHandler(this.btnZapisz_Trenerzy_Click);
            // 
            // dtpData_Trenerzy
            // 
            this.dtpData_Trenerzy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData_Trenerzy.Location = new System.Drawing.Point(440, 103);
            this.dtpData_Trenerzy.Name = "dtpData_Trenerzy";
            this.dtpData_Trenerzy.Size = new System.Drawing.Size(101, 20);
            this.dtpData_Trenerzy.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Imie";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "DataUr";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(384, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Nazwisko";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbSkocznie);
            this.tabPage3.Controls.Add(this.chbListSkocznie);
            this.tabPage3.Controls.Add(this.btnWczytaj_Skocznie);
            this.tabPage3.Controls.Add(this.btnUsun_Skocznie);
            this.tabPage3.Controls.Add(this.txtIdMiasta);
            this.tabPage3.Controls.Add(this.btnEdytuj_Skocznie);
            this.tabPage3.Controls.Add(this.txtNazwa_Skoczni);
            this.tabPage3.Controls.Add(this.btnZapisz_Skocznie);
            this.tabPage3.Controls.Add(this.txtK);
            this.tabPage3.Controls.Add(this.txtSedz);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txtKraj_Skoczni);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(877, 388);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Skocznie";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbSkocznie
            // 
            this.lbSkocznie.FormattingEnabled = true;
            this.lbSkocznie.Location = new System.Drawing.Point(6, 51);
            this.lbSkocznie.Name = "lbSkocznie";
            this.lbSkocznie.Size = new System.Drawing.Size(362, 303);
            this.lbSkocznie.TabIndex = 21;
            this.lbSkocznie.SelectedIndexChanged += new System.EventHandler(this.lbSkocznie_SelectedIndexChanged);
            // 
            // chbListSkocznie
            // 
            this.chbListSkocznie.FormattingEnabled = true;
            this.chbListSkocznie.Items.AddRange(new object[] {
            "Id_Miasta",
            "Nazwa_Skoczni",
            "K",
            "Sedz",
            "Kraj_Skoczni"});
            this.chbListSkocznie.Location = new System.Drawing.Point(608, 48);
            this.chbListSkocznie.Name = "chbListSkocznie";
            this.chbListSkocznie.Size = new System.Drawing.Size(148, 124);
            this.chbListSkocznie.TabIndex = 38;
            // 
            // btnWczytaj_Skocznie
            // 
            this.btnWczytaj_Skocznie.Location = new System.Drawing.Point(6, 6);
            this.btnWczytaj_Skocznie.Name = "btnWczytaj_Skocznie";
            this.btnWczytaj_Skocznie.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj_Skocznie.TabIndex = 22;
            this.btnWczytaj_Skocznie.Text = "Wczytaj";
            this.btnWczytaj_Skocznie.UseVisualStyleBackColor = true;
            this.btnWczytaj_Skocznie.Click += new System.EventHandler(this.btnWczytaj_Skocznie_Click);
            // 
            // btnUsun_Skocznie
            // 
            this.btnUsun_Skocznie.Location = new System.Drawing.Point(495, 271);
            this.btnUsun_Skocznie.Name = "btnUsun_Skocznie";
            this.btnUsun_Skocznie.Size = new System.Drawing.Size(75, 23);
            this.btnUsun_Skocznie.TabIndex = 37;
            this.btnUsun_Skocznie.Text = "Usuń";
            this.btnUsun_Skocznie.UseVisualStyleBackColor = true;
            this.btnUsun_Skocznie.Click += new System.EventHandler(this.btnUsun_Skocznie_Click);
            // 
            // txtIdMiasta
            // 
            this.txtIdMiasta.Location = new System.Drawing.Point(495, 51);
            this.txtIdMiasta.Name = "txtIdMiasta";
            this.txtIdMiasta.Size = new System.Drawing.Size(101, 20);
            this.txtIdMiasta.TabIndex = 23;
            // 
            // btnEdytuj_Skocznie
            // 
            this.btnEdytuj_Skocznie.Location = new System.Drawing.Point(608, 206);
            this.btnEdytuj_Skocznie.Name = "btnEdytuj_Skocznie";
            this.btnEdytuj_Skocznie.Size = new System.Drawing.Size(75, 23);
            this.btnEdytuj_Skocznie.TabIndex = 36;
            this.btnEdytuj_Skocznie.Text = "Edytuj";
            this.btnEdytuj_Skocznie.UseVisualStyleBackColor = true;
            this.btnEdytuj_Skocznie.Click += new System.EventHandler(this.btnEdytuj_Skocznie_Click);
            // 
            // txtNazwa_Skoczni
            // 
            this.txtNazwa_Skoczni.Location = new System.Drawing.Point(495, 77);
            this.txtNazwa_Skoczni.Name = "txtNazwa_Skoczni";
            this.txtNazwa_Skoczni.Size = new System.Drawing.Size(101, 20);
            this.txtNazwa_Skoczni.TabIndex = 24;
            // 
            // btnZapisz_Skocznie
            // 
            this.btnZapisz_Skocznie.Location = new System.Drawing.Point(495, 207);
            this.btnZapisz_Skocznie.Name = "btnZapisz_Skocznie";
            this.btnZapisz_Skocznie.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz_Skocznie.TabIndex = 35;
            this.btnZapisz_Skocznie.Text = "Zapisz";
            this.btnZapisz_Skocznie.UseVisualStyleBackColor = true;
            this.btnZapisz_Skocznie.Click += new System.EventHandler(this.btnZapisz_Skocznie_Click);
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(495, 103);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(101, 20);
            this.txtK.TabIndex = 25;
            // 
            // txtSedz
            // 
            this.txtSedz.Location = new System.Drawing.Point(495, 129);
            this.txtSedz.Name = "txtSedz";
            this.txtSedz.Size = new System.Drawing.Size(101, 20);
            this.txtSedz.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(384, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Kraj_Skoczni";
            // 
            // txtKraj_Skoczni
            // 
            this.txtKraj_Skoczni.Location = new System.Drawing.Point(495, 155);
            this.txtKraj_Skoczni.Name = "txtKraj_Skoczni";
            this.txtKraj_Skoczni.Size = new System.Drawing.Size(101, 20);
            this.txtKraj_Skoczni.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(384, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Sedz";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(384, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Id_Miasta";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(384, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Nazwa_Skoczni";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(384, 106);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "K";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 431);
            this.Controls.Add(this.tbcTabeka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcTabeka.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.TextBox txtWzrost;
        private System.Windows.Forms.TextBox txtWaga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.CheckedListBox chbListKolumny;
        private System.Windows.Forms.TabControl tbcTabeka;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox blTrenerzy;
        private System.Windows.Forms.CheckedListBox chbListTrenerzy;
        private System.Windows.Forms.Button btnWczytaj_Trenerzy;
        private System.Windows.Forms.Button btnUsun_Trenerzy;
        private System.Windows.Forms.TextBox txtImie_Trenerzy;
        private System.Windows.Forms.Button btnEdytuj_Trenerzy;
        private System.Windows.Forms.TextBox txtNazwisko_Trenerzy;
        private System.Windows.Forms.Button btnZapisz_Trenerzy;
        private System.Windows.Forms.DateTimePicker dtpData_Trenerzy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbSkocznie;
        private System.Windows.Forms.CheckedListBox chbListSkocznie;
        private System.Windows.Forms.Button btnWczytaj_Skocznie;
        private System.Windows.Forms.Button btnUsun_Skocznie;
        private System.Windows.Forms.TextBox txtIdMiasta;
        private System.Windows.Forms.Button btnEdytuj_Skocznie;
        private System.Windows.Forms.TextBox txtNazwa_Skoczni;
        private System.Windows.Forms.Button btnZapisz_Skocznie;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtSedz;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKraj_Skoczni;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

