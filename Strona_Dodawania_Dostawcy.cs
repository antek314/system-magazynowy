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
    public partial class Strona_Dodawania_Dostawcy : Form
    {
        public Strona_Dodawania_Dostawcy()
        {
            InitializeComponent();
        }

        private void dodaj_dostawce_Click(object sender, EventArgs e)
        {
            string data = DateTime.Now.ToShortDateString();
            if (dat2.Text != "")
            {
                data = dat2.Text;
            }
            Dostawca dostawca = new Dostawca(imieTextBox.Text, nazwiskoTextBox.Text, miejscowoscTextBox.Text, firmaTextBox.Text, Int32.Parse(ko2.Text), Int32.Parse(tr2.Text), data);
            string a = imieTextBox.Text;
            string b = nazwiskoTextBox.Text;
            this.Close();
            MessageBox.Show("Dodano nowego dostawce " + a + " " + b + ". Teraz w bazie jest " + dostawca.ZwrocLiczbeDostawcow() + " dostawców.");
        }

        private void zamknij_dodawanie_klienta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.dat1.Visible = checkBox1.Checked;
            this.dat2.Visible = checkBox1.Checked;
            this.ko1.Visible = checkBox1.Checked;
            this.ko2.Visible = checkBox1.Checked;
            this.tr1.Visible = checkBox1.Checked;
            this.tr2.Visible = checkBox1.Checked;

        }
    }
}
