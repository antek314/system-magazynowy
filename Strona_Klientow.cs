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
        void Odswiez(ListView tab)
        {

            string zapytaniee = "Select COUNT(*) From Klienci";
            cmd = new SqlCommand(zapytaniee, conn);
            cmd.Parameters.Clear();
            conn.Open();
            int liczba_rekordow = (Int32)cmd.ExecuteScalar();
            conn.Close();

            string [] zapytanie = { "Select id_klienta From Klienci Where id_klienta = @liczba", 
                "Select imie From Klienci Where id_klienta = @liczba", 
                "Select nazwisko From Klienci Where id_klienta = @liczba", 
                "Select miejscowosc From Klienci Where id_klienta = @liczba", 
                "Select firma From Klienci Where id_klienta = @liczba",
                "Select data From Klienci Where id_klienta = @liczba",
                "Select dochod From Klienci Where id_klienta = @liczba"};
            string [] tablica_wynikowa = new string[7];

            tabela_klientow.Items.Clear();

            for (int m = 1; m <= liczba_rekordow; m++)
            {
                for (int n = 0; n < zapytanie.Length; n++ )
                {
                    cmd = new SqlCommand(zapytanie[n], conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("liczba", m);
                    conn.Open();
                    tablica_wynikowa[n] = cmd.ExecuteScalar().ToString();
                    conn.Close();
                }
                ListViewItem list = new ListViewItem(tablica_wynikowa);
                tabela_klientow.Items.Add(list);

            }

        }
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
            dodaj.Show();
        }

        private void Strona_Klientow_Load(object sender, EventArgs e)
        {
            Odswiez(tabela_klientow);

            // TODO: This line of code loads data into the 'dataBaseSystemDataSet.Klienci' table. You can move, or remove it, as needed.
        }
    }
}
