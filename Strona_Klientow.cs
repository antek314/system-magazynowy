using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Magazynowy
{
    public partial class Strona_Klientow : Form
    {
        public Strona_Klientow()
        {
            InitializeComponent();
        }

        private void cofnij_do_strony_glownej_Click(object sender, EventArgs e)
        {
            this.Hide();
            Strona_Glowna glowna = new Strona_Glowna();
            glowna.Show();
        }

        private void dodaj_klienta_Click(object sender, EventArgs e)
        {

        }
    }
}
