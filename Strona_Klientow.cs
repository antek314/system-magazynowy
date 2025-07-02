using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace System_Magazynowy
{

    public partial class Strona_Klientow : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\anton\OneDrive\Desktop\Informatics\Visual Studio\System_Magazynowy\DataBaseSystem.mdf"";Integrated Security=True");
        SqlCommand cmd;

        string zapytanie = "SELECT * FROM Klienci";

        public Strona_Klientow()
        {
            InitializeComponent();
        }

        private void cofnij_do_strony_glownej_Click(object sender, EventArgs e)
        {
            Strona_Glowna glowna = new Strona_Glowna();
            glowna.Show();
            this.Hide();
        }

        private void dodaj_klienta_Click(object sender, EventArgs e)
        {
            Strona_Dodawania_Klienta dodaj = new Strona_Dodawania_Klienta();
            dodaj.system_zachowan_stron.PrzekazReferencjeTabeli(ref tabela_klientow, zapytanie);
            dodaj.Show();
        }

        private void Strona_Klientow_Load(object sender, EventArgs e)
        {
            System_Zachowan_Stron zaladuj_tabele = new System_Zachowan_Stron();
            zaladuj_tabele.ZapelnijTabeleDanymi(ref tabela_klientow, zapytanie);
        }

        private void przycisk_usun_rekord_klienta_Click(object sender, EventArgs e)
        {
            string zapytanie = "Delete From Klienci Where id_klienta = @indeks";

            System_Zachowan_Stron usuwanie = new System_Zachowan_Stron();
            usuwanie.Usun_Z_Tabeli(ref tabela_klientow, zapytanie);
        }
    }
}
