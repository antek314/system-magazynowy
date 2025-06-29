using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace System_Magazynowy
{
    internal class Produkt
    {
        private int id_produktu = 0;
        private string nazwa;

        private string dostawca;
        private Dostawca dostawca_;
        private string kod;
        private float cena;
        private int liczba;
        private string data_dodania;
        private float cena_hurtowa;
        private float marza;
        private float wartosc;
        private float waga;
        private string wymiary;
        private string opis;
        private static int liczba_roznych_produktow;
        private SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\anton\OneDrive\Desktop\Informatics\Visual Studio\System_Magazynowy\DataBaseSystem.mdf"";Integrated Security=True");
        private SqlCommand cmd;

        private void DodajDoBazyDanych()
        {
            marza = cena - cena_hurtowa;
            wartosc = liczba * cena;

            string zapytanie = "Insert Into Produkty(nazwa,dostawca,liczba,cena,cena_hurtowa,marza,wartosc,opis,kod,waga,wymiary,data)Values(@nazwa,@dostawca,@liczba,@cena,@cena_hurtowa,@marza,@wartosc,@opis,@kod,@waga,@wymiary,@data_dodania)";
            cmd = new SqlCommand(zapytanie, conn);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("nazwa", nazwa);
            cmd.Parameters.AddWithValue("dostawca", dostawca);
            cmd.Parameters.AddWithValue("liczba", liczba);
            cmd.Parameters.AddWithValue("cena", cena);
            cmd.Parameters.AddWithValue("cena_hurtowa", cena_hurtowa);

            cmd.Parameters.AddWithValue("marza", marza);
            cmd.Parameters.AddWithValue("wartosc", wartosc);

            cmd.Parameters.AddWithValue("opis", opis);
            cmd.Parameters.AddWithValue("kod", kod);
            cmd.Parameters.AddWithValue("waga", waga);
            cmd.Parameters.AddWithValue("wymiary", wymiary);
            cmd.Parameters.AddWithValue("data_dodania", data_dodania);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void DopiszNumerId()
        {
            string zapytanie = "Select Top 1 id_produktu From Produkty Order By id_produktu DESC";
            cmd = new SqlCommand(zapytanie, conn);
            cmd.Parameters.Clear();

            conn.Open();

            id_produktu = (int)cmd.ExecuteScalar();
            conn.Close();
        }
        private void UaktualnijLiczbeDostawcow()
        {
            string zapytanie = "Select COUNT(*) From Produkty";
            cmd = new SqlCommand(zapytanie, conn);
            cmd.Parameters.Clear();
            conn.Open();
            liczba_roznych_produktow = (Int32)cmd.ExecuteScalar();
            conn.Close();
        }

        public Produkt(string a, string b, int c, float d, float e, string f, string g, float h, string i, string j)
        {
            dostawca_= new Dostawca(b);
            nazwa = a;
            dostawca = b;
            liczba = c;
            cena = d;
            cena_hurtowa = e;

            opis = f;
            kod = g;
            waga = h;
            wymiary = i;
            data_dodania = j;

            DodajDoBazyDanych();
            DopiszNumerId();
            UaktualnijLiczbeDostawcow();
        }
        public int ZwrocLiczbeDostawcow()
        {
            return liczba_roznych_produktow;
        }
    }
}
