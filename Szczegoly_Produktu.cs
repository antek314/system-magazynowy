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
    public partial class Szczegoly_Produktu : Form
    {
        public System_Zachowan_Stron system_zachowan_stron = new System_Zachowan_Stron();
        public Szczegoly_Produktu()
        {
            InitializeComponent();
        }

        private void Szczegoly_Produktu_Load(object sender, EventArgs e)
        {
            int id = system_zachowan_stron.ZwrocId();

            Produkt produkt = new Produkt(ref label_nazwa, ref label_dostawca, ref label_liczba, ref label_kod, ref label_cena, ref label_cena_hurtowa, ref label_marza, ref label_wartosc, ref label_waga, ref label_wymiary, ref label_polka, ref label_data_dodania, ref label_opis, id);
        }

        private void cofnij_do_strony_glownej_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
