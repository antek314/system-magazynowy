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
using System.Data.SqlTypes;

namespace System_Magazynowy
{
    public partial class Strona_Dodawania_Klienta : Form
    {
        public Strona_Dodawania_Klienta()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.dat1.Visible = checkBox1.Checked;
            this.dat2.Visible = checkBox1.Checked;
            this.prz1.Visible = checkBox1.Checked;
            this.prz2.Visible = checkBox1.Checked;
        }

        private void zamknij_dodawanie_klienta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodaj_klienta_Click(object sender, EventArgs e)
        {
            string data = DateTime.Now.ToShortDateString();
            if (dat2.Text != "")
            {
                data = dat2.Text;
            }
            Klient klient = new Klient(imieTextBox.Text, nazwiskoTextBox.Text, miejscowoscTextBox.Text, firmaTextBox.Text, Int32.Parse(prz2.Text), data);
            string a = imieTextBox.Text;
            string b = nazwiskoTextBox.Text;
            this.Close();
            MessageBox.Show("Dodano nowego klienta " + a + " " + b + ". Teraz w bazie jest " + klient.ZwrocLiczbeKlientow() + " klientow");
        }
    }
}
