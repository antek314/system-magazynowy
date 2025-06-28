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
        private int id_klienta = 0;
        private String imie_klienta;
        private String nazwisko_klienta;
        private String firma_klienta;
        private String miejscowosc_klienta;
        private float wartosc_dochodu;
        private string data_dodania_klienta;
        private static int liczba_klientow;
        private SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\anton\OneDrive\Desktop\Informatics\Visual Studio\System_Magazynowy\DataBaseSystem.mdf"";Integrated Security=True");
        private SqlCommand cmd;

        private void DodajDoBazyDanych()
        {

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
        private void DopiszNumerId()
        {
            string zapytanie = "Select Top 1 id_klienta From Klienci Order By id_klienta DESC";
            cmd = new SqlCommand(zapytanie, conn);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("data", data_dodania_klienta);

            conn.Open();

            id_klienta = (int)cmd.ExecuteScalar();
            conn.Close();
        }
        private void UaktualnijLiczbeKlientow()
        {
            string zapytanie = "Select COUNT(*) From Klienci";
            cmd = new SqlCommand(zapytanie, conn);
            cmd.Parameters.Clear();
            conn.Open();
            liczba_klientow = (Int32)cmd.ExecuteScalar();
            conn.Close();
        }


        public Klient(string a, string b, string c, string d, int e, string f)
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
