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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tytul_systemu = new System.Windows.Forms.Label();
            this.przejdz_do_strony_klientow = new System.Windows.Forms.Button();
            this.zamknij = new System.Windows.Forms.Button();
            this.przycisk_usun_rekord_produktu = new System.Windows.Forms.Button();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dodaj_nowy_produkt = new System.Windows.Forms.Button();
            this.tytul_klienci = new System.Windows.Forms.Label();
            this.przejdz_do_strony_dostawcow = new System.Windows.Forms.Button();
            this.przejdz_do_strony_zamowien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
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
            this.zamknij.Location = new System.Drawing.Point(760, 426);
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
            this.przycisk_usun_rekord_produktu.Location = new System.Drawing.Point(543, 426);
            this.przycisk_usun_rekord_produktu.Name = "przycisk_usun_rekord_produktu";
            this.przycisk_usun_rekord_produktu.Size = new System.Drawing.Size(142, 47);
            this.przycisk_usun_rekord_produktu.TabIndex = 15;
            this.przycisk_usun_rekord_produktu.Text = "usuń";
            this.przycisk_usun_rekord_produktu.UseCompatibleTextRendering = true;
            this.przycisk_usun_rekord_produktu.UseVisualStyleBackColor = false;
            // 
            // tabela
            // 
            this.tabela.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.tabela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabela.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabela.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabela.DefaultCellStyle = dataGridViewCellStyle4;
            this.tabela.EnableHeadersVisualStyles = false;
            this.tabela.Location = new System.Drawing.Point(228, 97);
            this.tabela.Name = "tabela";
            this.tabela.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabela.RowHeadersVisible = false;
            this.tabela.RowHeadersWidth = 51;
            this.tabela.RowTemplate.Height = 24;
            this.tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela.Size = new System.Drawing.Size(685, 282);
            this.tabela.TabIndex = 14;
            // 
            // a
            // 
            this.a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.a.HeaderText = "*";
            this.a.MinimumWidth = 6;
            this.a.Name = "a";
            this.a.Width = 30;
            // 
            // dodaj_nowy_produkt
            // 
            this.dodaj_nowy_produkt.BackColor = System.Drawing.Color.Snow;
            this.dodaj_nowy_produkt.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj_nowy_produkt.ForeColor = System.Drawing.Color.Peru;
            this.dodaj_nowy_produkt.Location = new System.Drawing.Point(271, 426);
            this.dodaj_nowy_produkt.Name = "dodaj_nowy_produkt";
            this.dodaj_nowy_produkt.Size = new System.Drawing.Size(195, 47);
            this.dodaj_nowy_produkt.TabIndex = 13;
            this.dodaj_nowy_produkt.Text = "dodaj nowy produkt";
            this.dodaj_nowy_produkt.UseCompatibleTextRendering = true;
            this.dodaj_nowy_produkt.UseVisualStyleBackColor = false;
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
            // Strona_Glowna
            // 
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(966, 494);
            this.Controls.Add(this.przejdz_do_strony_zamowien);
            this.Controls.Add(this.przejdz_do_strony_dostawcow);
            this.Controls.Add(this.przycisk_usun_rekord_produktu);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.dodaj_nowy_produkt);
            this.Controls.Add(this.tytul_klienci);
            this.Controls.Add(this.zamknij);
            this.Controls.Add(this.przejdz_do_strony_klientow);
            this.Controls.Add(this.tytul_systemu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Name = "Strona_Glowna";
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tytul_systemu;
        private System.Windows.Forms.Button przejdz_do_strony_klientow;
        private System.Windows.Forms.Button zamknij;
        private System.Windows.Forms.Button przycisk_usun_rekord_produktu;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.DataGridViewCheckBoxColumn a;
        private System.Windows.Forms.Button dodaj_nowy_produkt;
        private System.Windows.Forms.Label tytul_klienci;
        private System.Windows.Forms.Button przejdz_do_strony_dostawcow;
        private System.Windows.Forms.Button przejdz_do_strony_zamowien;
    }
}

