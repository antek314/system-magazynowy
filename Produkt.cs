using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Win32;


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
        private string polka;
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

            string zapytanie = "Insert Into Produkty(nazwa,dostawca,liczba,cena,cena_hurtowa,marza,wartosc,opis,kod,waga,wymiary,data,polka)Values(@nazwa,@dostawca,@liczba,@cena,@cena_hurtowa,@marza,@wartosc,@opis,@kod,@waga,@wymiary,@data_dodania,@polka)";
            cmd = new SqlCommand(zapytanie, conn);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("nazwa", nazwa);
            cmd.Parameters.AddWithValue("dostawca", dostawca);
            cmd.Parameters.AddWithValue("liczba", liczba);
            cmd.Parameters.AddWithValue("cena", cena);
            cmd.Parameters.AddWithValue("cena_hurtowa", cena_hurtowa);

            cmd.Parameters.AddWithValue("marza", marza);
            cmd.Parameters.AddWithValue("wartosc", wartosc);

            cmd.Parameters.AddWithValue("polka", polka);
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

        public Produkt(string a, string b, int c, float d, float e, string f, string g, string h, float i, string j, string k)
        {
            dostawca_= new Dostawca(b);
            nazwa = a;
            dostawca = b;
            liczba = c;
            cena = d;
            cena_hurtowa = e;
            polka = f;

            opis = g;
            kod = h;
            waga = i;
            wymiary = j;
            data_dodania = k;

            DodajDoBazyDanych();
            DopiszNumerId();
            UaktualnijLiczbeDostawcow();
        }
        public int ZwrocLiczbeDostawcow()
        {
            return liczba_roznych_produktow;
        }
        public Produkt(ref Label a, ref Label b, ref Label c, ref Label d, ref Label e, ref Label f, ref Label g, ref Label h, ref Label i, ref Label j, ref Label k, ref Label l, ref Label m, int id)
        {
            string[] zapytanie = { "Select nazwa from Produkty Where id_produktu = @id",
            "Select dostawca from Produkty Where id_produktu = @id",
            "Select liczba from Produkty Where id_produktu = @id",
            "Select kod from Produkty Where id_produktu = @id",
            "Select cena from Produkty Where id_produktu = @id",
            "Select cena_hurtowa from Produkty Where id_produktu = @id",
            "Select marza from Produkty Where id_produktu = @id",
            "Select wartosc from Produkty Where id_produktu = @id",
            "Select waga from Produkty Where id_produktu = @id",
            "Select wymiary from Produkty Where id_produktu = @id",
            "Select polka from Produkty Where id_produktu = @id",
            "Select data from Produkty Where id_produktu = @id",
            "Select opis from Produkty Where id_produktu = @id"};

            string [] tablica = new string[zapytanie.Length];
            for (int r = 0; r < zapytanie.Length; r++)
            {
                cmd = new SqlCommand(zapytanie[r], conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                tablica[r] = cmd.ExecuteScalar().ToString();
                conn.Close();
            }
            a.Text = tablica[0];
            b.Text = tablica[1];
            c.Text = tablica[2];
            d.Text = tablica[3];
            e.Text = tablica[4];
            f.Text = tablica[5];
            g.Text = tablica[6];
            h.Text = tablica[7];
            i.Text = tablica[8];
            j.Text = tablica[9];
            k.Text = tablica[10];
            l.Text = tablica[11];
            m.Text = tablica[12];

        }
    }
}
