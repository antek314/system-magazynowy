using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace System_Magazynowy
{
    public class System_Zachowan_Stron
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\anton\OneDrive\Desktop\Informatics\Visual Studio\System_Magazynowy\DataBaseSystem.mdf"";Integrated Security=True");
        private SqlCommand cmd;

        private DataGridView tabela_do_zapelnienia; //wykorzystywane przy zapełnieniu tabel, aby wiedzieć która referencja tabeli ma się zapełnić
        private string zapytanie_do_przeslania; // wykorzystywane przy zapełnieniu tabel, aby wiadomo było z której bazy danych pobrać wartości

        private int id_produktu; // wykorzystywane przy szczegółach produktu, żeby wiedzieć jaki produkt pobrać z bazy danych

        public void Usun_Z_Tabeli(ref DataGridView tabela, string zapytanie)
        {
            foreach (DataGridViewRow row in tabela.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    int indeks = (int)row.Cells[1].Value;

                    tabela.Rows.RemoveAt(row.Index);

                    cmd = new SqlCommand(zapytanie, conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("indeks", indeks);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void ZapelnijTabeleDanymi(ref DataGridView tabela, string zapytanie)
        {
            using (conn)
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(zapytanie, conn))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        tabela.DataSource = dt;
                    }
                }
            }
        }

        public void ZapelnijComboboxDanymi(ref System.Windows.Forms.ComboBox combobox, string zapytanie)
        {
            combobox.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = conn.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Firma from Dostawcy";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd); da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                combobox.Items.Add(dr["Firma"].ToString());
                conn.Close();
            }
        }

        public void OswiezDaneWTabeli(ref DataGridView tabela, string zapytanie)
        {
            tabela.ClearSelection();
            ZapelnijTabeleDanymi(ref tabela, zapytanie);
        }

        public void PrzekazReferencjeTabeli(ref DataGridView t, string pytanie)
        {
            tabela_do_zapelnienia = t;
            zapytanie_do_przeslania = pytanie;
        }
        public ref DataGridView ZwrocTabele()
        {
            return ref tabela_do_zapelnienia;
        }
        public string ZwrocZapytanie()
        {
            return zapytanie_do_przeslania;
        }
        public void PrzekazId(int i)
        {
            id_produktu = i;
        }
        public int ZwrocId()
        {
            return id_produktu;
        }
    }
}