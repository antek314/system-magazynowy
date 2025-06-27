using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace System_Magazynowy
{
    internal class Klient
    {
        private
            int id_klienta = 0;
        String imie_klienta;
        String nazwisko_klienta;
        String firma_klienta;
        String miejscowosc_klienta;
        int wartosc_dochodu;
        string data_dodania_klienta;
        static int liczba_klientow;

        void DodajDoBazyDanych()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\anton\OneDrive\Desktop\Informatics\Visual Studio\System_Magazynowy\DataBaseSystem.mdf"";Integrated Security=True");
            SqlCommand cmd;
            string zapytanie = "Insert Into Klienci(imie,nazwisko,miejscowosc,firma,dochod,data)Values(@imie,@nazwisko,@miejscowosc,@firma,@dochod,@data)";
            cmd = new SqlCommand(zapytanie, conn);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("imie", imie_klienta);
            cmd.Parameters.AddWithValue("nazwisko", nazwisko_klienta);
            cmd.Parameters.AddWithValue("miejscowosc", miejscowosc_klienta);
            cmd.Parameters.AddWithValue("firma", firma_klienta);
            cmd.Parameters.AddWithValue("dochod", wartosc_dochodu);
            cmd.Parameters.AddWithValue("data", data_dodania_klienta.ToString());

            conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        void DopiszNumerId()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\anton\OneDrive\Desktop\Informatics\Visual Studio\System_Magazynowy\DataBaseSystem.mdf"";Integrated Security=True");
            SqlCommand cmd;
            string zapytanie = "Select Top 1 id_klienta From Klienci Order By id_klienta DESC";
            cmd = new SqlCommand(zapytanie, conn);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("data", data_dodania_klienta);

            conn.Open();

            id_klienta = (int)cmd.ExecuteScalar();
            conn.Close();
        }
        void UaktualnijLiczbeKlientow()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\anton\OneDrive\Desktop\Informatics\Visual Studio\System_Magazynowy\DataBaseSystem.mdf"";Integrated Security=True");
            SqlCommand cmd;
            string zapytanie = "Select COUNT(*) From Klienci";
            cmd = new SqlCommand(zapytanie, conn);
            cmd.Parameters.Clear();
            conn.Open();
            liczba_klientow = (Int32)cmd.ExecuteScalar();
            conn.Close();
        }


        public
            Klient(string a, string b, string c, string d, int e, string f)
        {
            imie_klienta = a;
            nazwisko_klienta = b;
            firma_klienta = c;
            miejscowosc_klienta = d;
            wartosc_dochodu = e;
            data_dodania_klienta = f;
            DodajDoBazyDanych();
            DopiszNumerId();
            UaktualnijLiczbeKlientow();
        }
        public int ZwrocLiczbeKlientow()
        {
            return liczba_klientow;
        }
    }
}
