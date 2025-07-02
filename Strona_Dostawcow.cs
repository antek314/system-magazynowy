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
    public partial class Strona_Dostawcow : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\anton\OneDrive\Desktop\Informatics\Visual Studio\System_Magazynowy\DataBaseSystem.mdf"";Integrated Security=True");
        private SqlCommand cmd;

        private string zapytanie = "SELECT * FROM Dostawcy";


        public Strona_Dostawcow()
        {
            InitializeComponent();
        }

        private void dodaj_nowego_dostawce_Click(object sender, EventArgs e)
        {
            Strona_Dodawania_Dostawcy dodaj = new Strona_Dodawania_Dostawcy();
            dodaj.system_zachowan_stron.PrzekazReferencjeTabeli(ref tabela_dostawcow, zapytanie);
            dodaj.Show();
        }

        private void cofnij_do_strony_glownej_Click(object sender, EventArgs e)
        {
            Strona_Glowna glowna = new Strona_Glowna();
            glowna.Show();
            this.Hide();
        }

        private void Strona_Dostawcow_Load(object sender, EventArgs e)
        {
            System_Zachowan_Stron zaladuj_tabele = new System_Zachowan_Stron();
            zaladuj_tabele.ZapelnijTabeleDanymi(ref tabela_dostawcow, zapytanie);
        }

        private void przycisk_usun_rekord_klienta_Click(object sender, EventArgs e)
        {
            string zapytanie = "Delete From Dostawcy Where id_dostawcy = @indeks";

            System_Zachowan_Stron usuwanie = new System_Zachowan_Stron();
            usuwanie.Usun_Z_Tabeli(ref tabela_dostawcow, zapytanie);
        }
    }
}
