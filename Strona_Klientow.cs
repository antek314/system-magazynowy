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

        void ZapelnijTabeleDanymi()
        {
            string sql = "SELECT * FROM Klienci";
            using (conn)
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(sql, conn))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        tabela_klientow.DataSource = dt;
                    }
                }
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
            ZapelnijTabeleDanymi();
        }

        private void przycisk_usun_rekord_klienta_Click(object sender, EventArgs e)
        {

        }
    }
}
