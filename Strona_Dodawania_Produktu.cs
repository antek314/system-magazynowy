using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace System_Magazynowy
{
    public partial class Strona_Dodawania_Produktu : Form
    {
        public Strona_Dodawania_Produktu()
        {
            InitializeComponent();
        }

        private void Strona_Dodawania_Produktu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBaseSystemDostawcy.Dostawcy' table. You can move, or remove it, as needed.
            this.dostawcyTableAdapter.Fill(this.dataBaseSystemDostawcy.Dostawcy);

        }

        private void zamknij_dodawanie_dostawcy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void opcje_CheckedChanged(object sender, EventArgs e)
        {
            this.dat1.Visible = opcje.Checked;
            this.dat2.Visible = opcje.Checked;
        }

        private void dodaj_dostawce_Click(object sender, EventArgs e)
        {
            string data = DateTime.Now.ToShortDateString();
            if (dat2.Text != "")
            {
                data = dat2.Text;
            }
            Produkt dostawca = new Produkt(nazwaTextBox.Text, wybierz_dostawce.Text, Int32.Parse(wpisz_liczbe.Text), float.Parse(wpisz_cene.Text), float.Parse(wpisz_cene_hurtowa.Text), wpisz_opis.Text, wpisz_kod.Text, float.Parse(wpisz_wage.Text), wpisz_wymiary.Text, data);
            string a = wybierz_dostawce.Text;
            string b = nazwaTextBox.Text;
            string c = wpisz_liczbe.ToString();
            this.Close();
            MessageBox.Show("Dostawca " + a + " dostarczył produkt " + b + ". Teraz w bazie jest " + c + " sztuk " + nazwaTextBox + ".");
        }
    }
}
