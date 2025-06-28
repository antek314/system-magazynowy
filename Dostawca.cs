using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace System_Magazynowy
{
    internal class Dostawca
    {
        private int id_dostawcy = 0;
        private String imie_dostawcy;
        private String nazwisko_dostawcy;
        private String firma_dostawcy;
        private String miejscowosc_dostawcy;
        private float koszty;
        private int liczba_transakcji;
        private string data_dodania_dostawcy;
        private string data_ostatniej_transakcji;
        private static int liczba_dostawcow;
        private SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\anton\OneDrive\Desktop\Informatics\Visual Studio\System_Magazynowy\DataBaseSystem.mdf"";Integrated Security=True");
        private SqlCommand cmd;

        private void DodajDoBazyDanych()
        {
            string dat = "brak";
            string zapytanie = "Insert Into Dostawcy(imie,nazwisko,miejscowosc,firma,koszty,data_dodania,data_ostatniej_transakcji,liczba_transakcji)Values(@imie,@nazwisko,@miejscowosc,@firma,@koszty,@data_dodania,@data_ostatniej_transakcji,@liczba_transakcji)";
            cmd = new SqlCommand(zapytanie, conn);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("imie", imie_dostawcy);
            cmd.Parameters.AddWithValue("nazwisko", nazwisko_dostawcy);
            cmd.Parameters.AddWithValue("miejscowosc", miejscowosc_dostawcy);
            cmd.Parameters.AddWithValue("firma", firma_dostawcy);
            cmd.Parameters.AddWithValue("koszty", koszty);
            cmd.Parameters.AddWithValue("data_dodania", data_dodania_dostawcy);
            cmd.Parameters.AddWithValue("data_ostatniej_transakcji", dat);
            cmd.Parameters.AddWithValue("liczba_transakcji", liczba_transakcji);

            conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void DopiszNumerId()
        {
            string zapytanie = "Select Top 1 id_dostawcy From Dostawcy Order By id_dostawcy DESC";
            cmd = new SqlCommand(zapytanie, conn);
            cmd.Parameters.Clear();

            //cmd.Parameters.AddWithValue("data", data_dodania_dostawcy);

            conn.Open();

            id_dostawcy = (int)cmd.ExecuteScalar();
            conn.Close();
        }
        private void UaktualnijLiczbeDostawcow()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\anton\OneDrive\Desktop\Informatics\Visual Studio\System_Magazynowy\DataBaseSystem.mdf"";Integrated Security=True");
            SqlCommand cmd;
            string zapytanie = "Select COUNT(*) From Dostawcy";
            cmd = new SqlCommand(zapytanie, conn);
            cmd.Parameters.Clear();
            conn.Open();
            liczba_dostawcow = (Int32)cmd.ExecuteScalar();
            conn.Close();
        }


        public Dostawca(string a, string b, string c, string d, float e, int f, string g)
        {
            imie_dostawcy = a;
            nazwisko_dostawcy = b;
            firma_dostawcy = c;
            miejscowosc_dostawcy = d;
            koszty = e;
            liczba_transakcji = f;
            data_dodania_dostawcy = g;
            DodajDoBazyDanych();
            DopiszNumerId();
            UaktualnijLiczbeDostawcow();
        }
        public int ZwrocLiczbeDostawcow()
        {
            return liczba_dostawcow;
        }
    }
}
