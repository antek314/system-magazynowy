using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace System_Magazynowy
{
    public partial class Strona_Glowna : Form
    {
        public Strona_Glowna()
        {
            InitializeComponent();
        }

        private void przejdz_do_strony_klientow_Click(object sender, EventArgs e)
        {
            Strona_Klientow klient = new Strona_Klientow();
            klient.Show();
            this.Hide();

        }

        private void zamknij_Click(object sender, EventArgs e)
        {
            // wylogowanie sie itp.
            Application.Exit();
        }

        private void przejdz_do_strony_dostawcow_Click(object sender, EventArgs e)
        {
            Strona_Dostawcow klient = new Strona_Dostawcow();
            klient.Show();
            this.Hide();
        }

        private void Strona_Glowna_Load(object sender, EventArgs e)
        {
            string zapytanie = "SELECT * FROM Produkty";

            System_Zachowan_Stron zaladuj_tabele = new System_Zachowan_Stron();
            zaladuj_tabele.ZapelnijTabeleDanymi(ref tabela_produktow, zapytanie);
        }

        private void dodaj_nowy_produkt_Click(object sender, EventArgs e)
        {
            Strona_Dodawania_Produktu dodaj = new Strona_Dodawania_Produktu();
            dodaj.Show();
        }

        private void przycisk_usun_rekord_produktu_Click(object sender, EventArgs e)
        {
            string zapytanie = "Delete From Produkty Where id_produktu = @indeks";

            System_Zachowan_Stron usuwanie = new System_Zachowan_Stron();
            usuwanie.Usun_Z_Tabeli(ref tabela_produktow, zapytanie);
        }
    }
}
