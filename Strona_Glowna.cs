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
    public partial class Strona_Glowna : Form
    {
        public Strona_Glowna()
        {
            InitializeComponent();
        }

        private void przejdz_do_strony_klientow_Click(object sender, EventArgs e)
        {
            Strona_Klientow klient = new Strona_Klientow();
            klient.Show();
            this.Hide();

        }

        private void zamknij_Click(object sender, EventArgs e)
        {
            // wylogowanie sie itp.
            Application.Exit();
        }

        private void przejdz_do_strony_dostawcow_Click(object sender, EventArgs e)
        {
            Strona_Dostawcow klient = new Strona_Dostawcow();
            klient.Show();
            this.Hide();
        }
    }
}
