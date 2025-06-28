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

        private void prz2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dat1_Click(object sender, EventArgs e)
        {

        }

        private void dat2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void firmaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void miejscowoscTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nazwiskoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void imie_label_Click(object sender, EventArgs e)
        {

        }

        private void tytul_dodaj_klienta_Click(object sender, EventArgs e)
        {

        }

        private void imieTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prz1_Click(object sender, EventArgs e)
        {

        }
    }
}
