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
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\anton\OneDrive\Desktop\Informatics\Visual Studio\System_Magazynowy\DataBaseSystem.mdf"";Integrated Security=True");
        SqlCommand cmd;

        void ZapelnijTabeleDanymi()
        {
            string sql = "SELECT * FROM Dostawcy";
            using (conn)
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(sql, conn))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        tabela_dostawcow.DataSource = dt;
                    }
                }
            }

        }


        public Strona_Dostawcow()
        {
            InitializeComponent();
        }

        private void dodaj_nowego_dostawce_Click(object sender, EventArgs e)
        {
            Strona_Dodawania_Dostawcy dodaj = new Strona_Dodawania_Dostawcy();
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
            ZapelnijTabeleDanymi();
        }

    }
}
