using System.Windows.Forms;

namespace System_Magazynowy
{
    partial class Strona_Klientow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cofnij_do_strony_glownej = new System.Windows.Forms.Button();
            this.tytul_klienci = new System.Windows.Forms.Label();
            this.dodaj_nowego_klienta = new System.Windows.Forms.Button();
            this.dataBaseSystemDataSet = new System_Magazynowy.DataBaseSystemDataSet();
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klienciTableAdapter = new System_Magazynowy.DataBaseSystemDataSetTableAdapters.KlienciTableAdapter();
            this.tabela_klientow = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.miejscowosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dochod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cofnij_do_strony_glownej
            // 
            this.cofnij_do_strony_glownej.BackColor = System.Drawing.Color.PapayaWhip;
            this.cofnij_do_strony_glownej.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cofnij_do_strony_glownej.ForeColor = System.Drawing.Color.Peru;
            this.cofnij_do_strony_glownej.Location = new System.Drawing.Point(634, 508);
            this.cofnij_do_strony_glownej.Name = "cofnij_do_strony_glownej";
            this.cofnij_do_strony_glownej.Size = new System.Drawing.Size(234, 35);
            this.cofnij_do_strony_glownej.TabIndex = 0;
            this.cofnij_do_strony_glownej.Text = "wróć";
            this.cofnij_do_strony_glownej.UseCompatibleTextRendering = true;
            this.cofnij_do_strony_glownej.UseVisualStyleBackColor = false;
            this.cofnij_do_strony_glownej.Click += new System.EventHandler(this.cofnij_do_strony_glownej_Click);
            // 
            // tytul_klienci
            // 
            this.tytul_klienci.AutoSize = true;
            this.tytul_klienci.Font = new System.Drawing.Font("Monotxt_IV25", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tytul_klienci.ForeColor = System.Drawing.Color.Peru;
            this.tytul_klienci.Location = new System.Drawing.Point(12, 25);
            this.tytul_klienci.Name = "tytul_klienci";
            this.tytul_klienci.Size = new System.Drawing.Size(503, 53);
            this.tytul_klienci.TabIndex = 3;
            this.tytul_klienci.Text = "Strona Klientów";
            // 
            // dodaj_nowego_klienta
            // 
            this.dodaj_nowego_klienta.BackColor = System.Drawing.Color.PapayaWhip;
            this.dodaj_nowego_klienta.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj_nowego_klienta.ForeColor = System.Drawing.Color.Peru;
            this.dodaj_nowego_klienta.Location = new System.Drawing.Point(101, 508);
            this.dodaj_nowego_klienta.Name = "dodaj_nowego_klienta";
            this.dodaj_nowego_klienta.Size = new System.Drawing.Size(400, 35);
            this.dodaj_nowego_klienta.TabIndex = 4;
            this.dodaj_nowego_klienta.Text = "dodaj nowego klienta";
            this.dodaj_nowego_klienta.UseCompatibleTextRendering = true;
            this.dodaj_nowego_klienta.UseVisualStyleBackColor = false;
            this.dodaj_nowego_klienta.Click += new System.EventHandler(this.dodaj_klienta_Click);
            // 
            // dataBaseSystemDataSet
            // 
            this.dataBaseSystemDataSet.DataSetName = "DataBaseSystemDataSet";
            this.dataBaseSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klienciBindingSource
            // 
            this.klienciBindingSource.DataMember = "Klienci";
            this.klienciBindingSource.DataSource = this.dataBaseSystemDataSet;
            // 
            // klienciTableAdapter
            // 
            this.klienciTableAdapter.ClearBeforeFill = true;
            // 
            // tabela_klientow
            // 
            this.tabela_klientow.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabela_klientow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.imie,
            this.nazwisko,
            this.miejscowosc,
            this.firma,
            this.data,
            this.dochod});
            this.tabela_klientow.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabela_klientow.ForeColor = System.Drawing.Color.SaddleBrown;
            this.tabela_klientow.HideSelection = false;
            this.tabela_klientow.Location = new System.Drawing.Point(12, 104);
            this.tabela_klientow.Name = "tabela_klientow";
            this.tabela_klientow.Size = new System.Drawing.Size(1113, 283);
            this.tabela_klientow.TabIndex = 7;
            this.tabela_klientow.UseCompatibleStateImageBehavior = false;
            this.tabela_klientow.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id  ";
            this.id.Width = 77;
            // 
            // imie
            // 
            this.imie.Text = "imie      ";
            this.imie.Width = 143;
            // 
            // nazwisko
            // 
            this.nazwisko.Text = "nazwisko";
            this.nazwisko.Width = 201;
            // 
            // miejscowosc
            // 
            this.miejscowosc.Text = "miejscowość";
            this.miejscowosc.Width = 214;
            // 
            // firma
            // 
            this.firma.Text = "firma";
            this.firma.Width = 130;
            // 
            // data
            // 
            this.data.Text = "data";
            this.data.Width = 162;
            // 
            // dochod
            // 
            this.dochod.Text = "dochód";
            this.dochod.Width = 223;
            // 
            // Strona_Klientow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1194, 556);
            this.Controls.Add(this.tabela_klientow);
            this.Controls.Add(this.dodaj_nowego_klienta);
            this.Controls.Add(this.tytul_klienci);
            this.Controls.Add(this.cofnij_do_strony_glownej);
            this.Name = "Strona_Klientow";
            this.Text = "Strona_Klientow";
            this.Load += new System.EventHandler(this.Strona_Klientow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cofnij_do_strony_glownej;
        private System.Windows.Forms.Label tytul_klienci;
        private System.Windows.Forms.Button dodaj_nowego_klienta;
        private DataBaseSystemDataSet dataBaseSystemDataSet;
        private BindingSource klienciBindingSource;
        private DataBaseSystemDataSetTableAdapters.KlienciTableAdapter klienciTableAdapter;
        private ListView tabela_klientow;
        private ColumnHeader id;
        private ColumnHeader imie;
        private ColumnHeader nazwisko;
        private ColumnHeader miejscowosc;
        private ColumnHeader firma;
        private ColumnHeader data;
        private ColumnHeader dochod;
    }
}