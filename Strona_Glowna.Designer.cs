namespace System_Magazynowy
{
    partial class Strona_Glowna
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tytul_systemu = new System.Windows.Forms.Label();
            this.przejdz_do_strony_klientow = new System.Windows.Forms.Button();
            this.zamknij = new System.Windows.Forms.Button();
            this.przycisk_usun_rekord_produktu = new System.Windows.Forms.Button();
            this.dodaj_nowy_produkt = new System.Windows.Forms.Button();
            this.tytul_klienci = new System.Windows.Forms.Label();
            this.przejdz_do_strony_dostawcow = new System.Windows.Forms.Button();
            this.przejdz_do_strony_zamowien = new System.Windows.Forms.Button();
            this.tabela_produktow = new System.Windows.Forms.DataGridView();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseSystemProdukty = new System_Magazynowy.DataBaseSystemProdukty();
            this.produktyTableAdapter = new System_Magazynowy.DataBaseSystemProduktyTableAdapters.ProduktyTableAdapter();
            this.a = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idproduktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostawcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pulkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczbaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenahurtowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wartoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_produktow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseSystemProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // tytul_systemu
            // 
            this.tytul_systemu.AutoSize = true;
            this.tytul_systemu.Font = new System.Drawing.Font("Monotxt_IV25", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tytul_systemu.ForeColor = System.Drawing.Color.Peru;
            this.tytul_systemu.Location = new System.Drawing.Point(66, 21);
            this.tytul_systemu.Name = "tytul_systemu";
            this.tytul_systemu.Size = new System.Drawing.Size(567, 53);
            this.tytul_systemu.TabIndex = 0;
            this.tytul_systemu.Text = "System Magazynowy";
            // 
            // przejdz_do_strony_klientow
            // 
            this.przejdz_do_strony_klientow.AllowDrop = true;
            this.przejdz_do_strony_klientow.AutoEllipsis = true;
            this.przejdz_do_strony_klientow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.przejdz_do_strony_klientow.BackColor = System.Drawing.Color.LavenderBlush;
            this.przejdz_do_strony_klientow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.przejdz_do_strony_klientow.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.przejdz_do_strony_klientow.ForeColor = System.Drawing.Color.Peru;
            this.przejdz_do_strony_klientow.Location = new System.Drawing.Point(32, 97);
            this.przejdz_do_strony_klientow.Name = "przejdz_do_strony_klientow";
            this.przejdz_do_strony_klientow.Size = new System.Drawing.Size(148, 97);
            this.przejdz_do_strony_klientow.TabIndex = 1;
            this.przejdz_do_strony_klientow.Text = "Klienci";
            this.przejdz_do_strony_klientow.UseVisualStyleBackColor = true;
            this.przejdz_do_strony_klientow.Click += new System.EventHandler(this.przejdz_do_strony_klientow_Click);
            // 
            // zamknij
            // 
            this.zamknij.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zamknij.Font = new System.Drawing.Font("Monotxt_IV25", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zamknij.ForeColor = System.Drawing.Color.Peru;
            this.zamknij.Location = new System.Drawing.Point(1082, 702);
            this.zamknij.Name = "zamknij";
            this.zamknij.Size = new System.Drawing.Size(137, 47);
            this.zamknij.TabIndex = 2;
            this.zamknij.Text = "zamknij";
            this.zamknij.UseCompatibleTextRendering = true;
            this.zamknij.UseVisualStyleBackColor = true;
            this.zamknij.Click += new System.EventHandler(this.zamknij_Click);
            // 
            // przycisk_usun_rekord_produktu
            // 
            this.przycisk_usun_rekord_produktu.BackColor = System.Drawing.Color.Snow;
            this.przycisk_usun_rekord_produktu.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.przycisk_usun_rekord_produktu.ForeColor = System.Drawing.Color.Peru;
            this.przycisk_usun_rekord_produktu.Location = new System.Drawing.Point(865, 702);
            this.przycisk_usun_rekord_produktu.Name = "przycisk_usun_rekord_produktu";
            this.przycisk_usun_rekord_produktu.Size = new System.Drawing.Size(142, 47);
            this.przycisk_usun_rekord_produktu.TabIndex = 15;
            this.przycisk_usun_rekord_produktu.Text = "usuń";
            this.przycisk_usun_rekord_produktu.UseCompatibleTextRendering = true;
            this.przycisk_usun_rekord_produktu.UseVisualStyleBackColor = false;
            this.przycisk_usun_rekord_produktu.Click += new System.EventHandler(this.przycisk_usun_rekord_produktu_Click);
            // 
            // dodaj_nowy_produkt
            // 
            this.dodaj_nowy_produkt.BackColor = System.Drawing.Color.Snow;
            this.dodaj_nowy_produkt.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj_nowy_produkt.ForeColor = System.Drawing.Color.Peru;
            this.dodaj_nowy_produkt.Location = new System.Drawing.Point(593, 702);
            this.dodaj_nowy_produkt.Name = "dodaj_nowy_produkt";
            this.dodaj_nowy_produkt.Size = new System.Drawing.Size(195, 47);
            this.dodaj_nowy_produkt.TabIndex = 13;
            this.dodaj_nowy_produkt.Text = "dodaj nowy produkt";
            this.dodaj_nowy_produkt.UseCompatibleTextRendering = true;
            this.dodaj_nowy_produkt.UseVisualStyleBackColor = false;
            this.dodaj_nowy_produkt.Click += new System.EventHandler(this.dodaj_nowy_produkt_Click);
            // 
            // tytul_klienci
            // 
            this.tytul_klienci.AutoSize = true;
            this.tytul_klienci.Font = new System.Drawing.Font("Monotxt_IV25", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tytul_klienci.ForeColor = System.Drawing.Color.Peru;
            this.tytul_klienci.Location = new System.Drawing.Point(113, -45);
            this.tytul_klienci.Name = "tytul_klienci";
            this.tytul_klienci.Size = new System.Drawing.Size(503, 53);
            this.tytul_klienci.TabIndex = 12;
            this.tytul_klienci.Text = "Strona Klientów";
            // 
            // przejdz_do_strony_dostawcow
            // 
            this.przejdz_do_strony_dostawcow.AllowDrop = true;
            this.przejdz_do_strony_dostawcow.AutoEllipsis = true;
            this.przejdz_do_strony_dostawcow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.przejdz_do_strony_dostawcow.BackColor = System.Drawing.Color.LavenderBlush;
            this.przejdz_do_strony_dostawcow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.przejdz_do_strony_dostawcow.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.przejdz_do_strony_dostawcow.ForeColor = System.Drawing.Color.Peru;
            this.przejdz_do_strony_dostawcow.Location = new System.Drawing.Point(32, 231);
            this.przejdz_do_strony_dostawcow.Name = "przejdz_do_strony_dostawcow";
            this.przejdz_do_strony_dostawcow.Size = new System.Drawing.Size(148, 99);
            this.przejdz_do_strony_dostawcow.TabIndex = 16;
            this.przejdz_do_strony_dostawcow.Text = "Dostawcy";
            this.przejdz_do_strony_dostawcow.UseVisualStyleBackColor = true;
            this.przejdz_do_strony_dostawcow.Click += new System.EventHandler(this.przejdz_do_strony_dostawcow_Click);
            // 
            // przejdz_do_strony_zamowien
            // 
            this.przejdz_do_strony_zamowien.AllowDrop = true;
            this.przejdz_do_strony_zamowien.AutoEllipsis = true;
            this.przejdz_do_strony_zamowien.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.przejdz_do_strony_zamowien.BackColor = System.Drawing.Color.LavenderBlush;
            this.przejdz_do_strony_zamowien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.przejdz_do_strony_zamowien.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.przejdz_do_strony_zamowien.ForeColor = System.Drawing.Color.Peru;
            this.przejdz_do_strony_zamowien.Location = new System.Drawing.Point(32, 370);
            this.przejdz_do_strony_zamowien.Name = "przejdz_do_strony_zamowien";
            this.przejdz_do_strony_zamowien.Size = new System.Drawing.Size(148, 103);
            this.przejdz_do_strony_zamowien.TabIndex = 17;
            this.przejdz_do_strony_zamowien.Text = "Zamówienia";
            this.przejdz_do_strony_zamowien.UseVisualStyleBackColor = true;
            // 
            // tabela_produktow
            // 
            this.tabela_produktow.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tabela_produktow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabela_produktow.AutoGenerateColumns = false;
            this.tabela_produktow.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.tabela_produktow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabela_produktow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabela_produktow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela_produktow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabela_produktow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_produktow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.idproduktuDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.dostawcaDataGridViewTextBoxColumn,
            this.pulkaDataGridViewTextBoxColumn,
            this.liczbaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.cenahurtowaDataGridViewTextBoxColumn,
            this.marzaDataGridViewTextBoxColumn,
            this.wartoscDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.tabela_produktow.DataSource = this.produktyBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabela_produktow.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabela_produktow.EnableHeadersVisualStyles = false;
            this.tabela_produktow.Location = new System.Drawing.Point(207, 97);
            this.tabela_produktow.Name = "tabela_produktow";
            this.tabela_produktow.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela_produktow.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tabela_produktow.RowHeadersVisible = false;
            this.tabela_produktow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tabela_produktow.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tabela_produktow.RowTemplate.Height = 24;
            this.tabela_produktow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela_produktow.Size = new System.Drawing.Size(1163, 552);
            this.tabela_produktow.TabIndex = 18;
            this.tabela_produktow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Kliknieto);
            // 
            // produktyBindingSource
            // 
            this.produktyBindingSource.DataMember = "Produkty";
            this.produktyBindingSource.DataSource = this.dataBaseSystemProdukty;
            // 
            // dataBaseSystemProdukty
            // 
            this.dataBaseSystemProdukty.DataSetName = "DataBaseSystemProdukty";
            this.dataBaseSystemProdukty.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produktyTableAdapter
            // 
            this.produktyTableAdapter.ClearBeforeFill = true;
            // 
            // a
            // 
            this.a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.a.HeaderText = "*";
            this.a.MinimumWidth = 6;
            this.a.Name = "a";
            this.a.Width = 30;
            // 
            // idproduktuDataGridViewTextBoxColumn
            // 
            this.idproduktuDataGridViewTextBoxColumn.DataPropertyName = "Id_produktu";
            this.idproduktuDataGridViewTextBoxColumn.HeaderText = "id";
            this.idproduktuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idproduktuDataGridViewTextBoxColumn.Name = "idproduktuDataGridViewTextBoxColumn";
            this.idproduktuDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproduktuDataGridViewTextBoxColumn.Width = 25;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dostawcaDataGridViewTextBoxColumn
            // 
            this.dostawcaDataGridViewTextBoxColumn.DataPropertyName = "dostawca";
            this.dostawcaDataGridViewTextBoxColumn.HeaderText = "dostawca";
            this.dostawcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dostawcaDataGridViewTextBoxColumn.Name = "dostawcaDataGridViewTextBoxColumn";
            this.dostawcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pulkaDataGridViewTextBoxColumn
            // 
            this.pulkaDataGridViewTextBoxColumn.DataPropertyName = "polka";
            this.pulkaDataGridViewTextBoxColumn.HeaderText = "półka";
            this.pulkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pulkaDataGridViewTextBoxColumn.Name = "pulkaDataGridViewTextBoxColumn";
            this.pulkaDataGridViewTextBoxColumn.Width = 125;
            // 
            // liczbaDataGridViewTextBoxColumn
            // 
            this.liczbaDataGridViewTextBoxColumn.DataPropertyName = "liczba";
            this.liczbaDataGridViewTextBoxColumn.HeaderText = "liczba";
            this.liczbaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.liczbaDataGridViewTextBoxColumn.Name = "liczbaDataGridViewTextBoxColumn";
            this.liczbaDataGridViewTextBoxColumn.Width = 125;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "cena";
            this.cenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // cenahurtowaDataGridViewTextBoxColumn
            // 
            this.cenahurtowaDataGridViewTextBoxColumn.DataPropertyName = "cena_hurtowa";
            this.cenahurtowaDataGridViewTextBoxColumn.HeaderText = "hurt";
            this.cenahurtowaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenahurtowaDataGridViewTextBoxColumn.Name = "cenahurtowaDataGridViewTextBoxColumn";
            this.cenahurtowaDataGridViewTextBoxColumn.Width = 125;
            // 
            // marzaDataGridViewTextBoxColumn
            // 
            this.marzaDataGridViewTextBoxColumn.DataPropertyName = "marza";
            this.marzaDataGridViewTextBoxColumn.HeaderText = "marza";
            this.marzaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marzaDataGridViewTextBoxColumn.Name = "marzaDataGridViewTextBoxColumn";
            this.marzaDataGridViewTextBoxColumn.Width = 125;
            // 
            // wartoscDataGridViewTextBoxColumn
            // 
            this.wartoscDataGridViewTextBoxColumn.DataPropertyName = "wartosc";
            this.wartoscDataGridViewTextBoxColumn.HeaderText = "wartosc";
            this.wartoscDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wartoscDataGridViewTextBoxColumn.Name = "wartoscDataGridViewTextBoxColumn";
            this.wartoscDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "kod";
            this.kodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // Strona_Glowna
            // 
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1400, 789);
            this.Controls.Add(this.tabela_produktow);
            this.Controls.Add(this.przejdz_do_strony_zamowien);
            this.Controls.Add(this.przejdz_do_strony_dostawcow);
            this.Controls.Add(this.przycisk_usun_rekord_produktu);
            this.Controls.Add(this.dodaj_nowy_produkt);
            this.Controls.Add(this.tytul_klienci);
            this.Controls.Add(this.zamknij);
            this.Controls.Add(this.przejdz_do_strony_klientow);
            this.Controls.Add(this.tytul_systemu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Strona_Glowna";
            this.Load += new System.EventHandler(this.Strona_Glowna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_produktow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseSystemProdukty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tytul_systemu;
        private System.Windows.Forms.Button przejdz_do_strony_klientow;
        private System.Windows.Forms.Button zamknij;
        private System.Windows.Forms.Button przycisk_usun_rekord_produktu;
        private System.Windows.Forms.Button dodaj_nowy_produkt;
        private System.Windows.Forms.Label tytul_klienci;
        private System.Windows.Forms.Button przejdz_do_strony_dostawcow;
        private System.Windows.Forms.Button przejdz_do_strony_zamowien;
        private System.Windows.Forms.DataGridView tabela_produktow;
        private DataBaseSystemProdukty dataBaseSystemProdukty;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private DataBaseSystemProduktyTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostawcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pulkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczbaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenahurtowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
    }
}

