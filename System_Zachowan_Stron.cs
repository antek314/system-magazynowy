using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace System_Magazynowy
{
    internal class System_Zachowan_Stron
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\anton\OneDrive\Desktop\Informatics\Visual Studio\System_Magazynowy\DataBaseSystem.mdf"";Integrated Security=True");
        private SqlCommand cmd;

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

        public void OswiezDaneWTabeli(ref DataGridView tabela, string zapytanie)
        {
            tabela.ClearSelection();
            ZapelnijTabeleDanymi(ref tabela, zapytanie);
        }
    }
}
