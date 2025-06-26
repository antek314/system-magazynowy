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
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\anton\OneDrive\Desktop\Informatics\Visual Studio\System_Magazynowy\DataBaseSystem.mdf"";Integrated Security=True");
            SqlCommand cmd;
            string zapytanie = "Insert Into Klienci(imie,nazwisko,miejscowosc,firma,dochod,data)Values(@imie,@nazwisko,@miejscowosc,@firma,@dochod,@data)";
            cmd = new SqlCommand(zapytanie, conn);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("imie", imieTextBox.Text);
            cmd.Parameters.AddWithValue("nazwisko", nazwiskoTextBox.Text);
            cmd.Parameters.AddWithValue("miejscowosc", miejscowoscTextBox.Text);
            cmd.Parameters.AddWithValue("firma", firmaTextBox.Text);
            cmd.Parameters.AddWithValue("dochod", prz2.Text);
            cmd.Parameters.AddWithValue("data", dat2.Value);

            conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();
            MessageBox.Show("Dodano nowego klienta " + this.imieTextBox.Text + " " + this.nazwiskoTextBox.Text);
        }
    }
}
