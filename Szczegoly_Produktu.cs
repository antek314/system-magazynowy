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
        private int id_produktu;
        public Szczegoly_Produktu()
        {
            InitializeComponent();
        }

        public void PrzekazId(int i)
        {
            id_produktu = i;
        }

        private void Szczegoly_Produktu_Load(object sender, EventArgs e)
        {

        }
    }
}
