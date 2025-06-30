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
        private string zapytanie = "SELECT * FROM Produkty";

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
            System_Zachowan_Stron zaladuj_tabele = new System_Zachowan_Stron();
            zaladuj_tabele.ZapelnijTabeleDanymi(ref tabela_produktow, zapytanie);
        }

        private void dodaj_nowy_produkt_Click(object sender, EventArgs e)
        {
            Strona_Dodawania_Produktu dodaj = new Strona_Dodawania_Produktu();
            dodaj.PrzekazReferencjeTabeli(ref tabela_produktow, zapytanie);
            dodaj.Show();
        }

        private void przycisk_usun_rekord_produktu_Click(object sender, EventArgs e)
        {
            string usun = "Delete From Produkty Where id_produktu = @indeks";

            System_Zachowan_Stron usuwanie = new System_Zachowan_Stron();
            usuwanie.Usun_Z_Tabeli(ref tabela_produktow, usun);
        }

        private void Tu(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void Kliknieto(object sender, DataGridViewCellEventArgs e)
        {
            int index = int.Parse(e.RowIndex.ToString());
            int id = int.Parse(this.tabela_produktow.Rows[index].Cells[1].Value.ToString());
            Szczegoly_Produktu dodaj = new Szczegoly_Produktu();
            dodaj.PrzekazId(id);
            dodaj.Show();
        }
    }
}
