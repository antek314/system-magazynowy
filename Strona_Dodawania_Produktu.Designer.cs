namespace System_Magazynowy
{
    partial class Strona_Dodawania_Produktu
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
            this.dat1 = new System.Windows.Forms.Label();
            this.dat2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nazwa_label = new System.Windows.Forms.Label();
            this.tytul_dodaj_produkt = new System.Windows.Forms.Label();
            this.opcje = new System.Windows.Forms.CheckBox();
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.dodaj_dostawce = new System.Windows.Forms.Button();
            this.zamknij_dodawanie_dostawcy = new System.Windows.Forms.Button();
            this.wybierz_dostawce = new System.Windows.Forms.ComboBox();
            this.dostawcyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseSystemDostawcy = new System_Magazynowy.DataBaseSystemDostawcy();
            this.dostawcyTableAdapter = new System_Magazynowy.DataBaseSystemDostawcyTableAdapters.DostawcyTableAdapter();
            this.wpisz_liczbe = new System.Windows.Forms.TextBox();
            this.wpisz_cene = new System.Windows.Forms.TextBox();
            this.wpisz_cene_hurtowa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wpisz_opis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wpisz_kod = new System.Windows.Forms.TextBox();
            this.wpisz_wymiary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.wpisz_wage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dostawcyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseSystemDostawcy)).BeginInit();
            this.SuspendLayout();
            // 
            // dat1
            // 
            this.dat1.AutoSize = true;
            this.dat1.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dat1.ForeColor = System.Drawing.Color.Peru;
            this.dat1.Location = new System.Drawing.Point(201, 444);
            this.dat1.Name = "dat1";
            this.dat1.Size = new System.Drawing.Size(202, 24);
            this.dat1.TabIndex = 56;
            this.dat1.Text = "data dodania";
            this.dat1.Visible = false;
            // 
            // dat2
            // 
            this.dat2.Font = new System.Drawing.Font("Monotxt_IV25", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dat2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dat2.Location = new System.Drawing.Point(194, 471);
            this.dat2.Name = "dat2";
            this.dat2.Size = new System.Drawing.Size(209, 30);
            this.dat2.TabIndex = 55;
            this.dat2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Peru;
            this.label4.Location = new System.Drawing.Point(55, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 54;
            this.label4.Text = "cena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(460, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 52;
            this.label3.Text = "liczba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(204, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "dostawca";
            // 
            // nazwa_label
            // 
            this.nazwa_label.AutoSize = true;
            this.nazwa_label.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazwa_label.ForeColor = System.Drawing.Color.Peru;
            this.nazwa_label.Location = new System.Drawing.Point(49, 124);
            this.nazwa_label.Name = "nazwa_label";
            this.nazwa_label.Size = new System.Drawing.Size(90, 24);
            this.nazwa_label.TabIndex = 48;
            this.nazwa_label.Text = "nazwa";
            // 
            // tytul_dodaj_produkt
            // 
            this.tytul_dodaj_produkt.AutoSize = true;
            this.tytul_dodaj_produkt.Font = new System.Drawing.Font("Monotxt_IV25", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tytul_dodaj_produkt.ForeColor = System.Drawing.Color.Peru;
            this.tytul_dodaj_produkt.Location = new System.Drawing.Point(63, 28);
            this.tytul_dodaj_produkt.Name = "tytul_dodaj_produkt";
            this.tytul_dodaj_produkt.Size = new System.Drawing.Size(439, 53);
            this.tytul_dodaj_produkt.TabIndex = 47;
            this.tytul_dodaj_produkt.Text = "Dodaj Produkt";
            // 
            // opcje
            // 
            this.opcje.AutoSize = true;
            this.opcje.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcje.ForeColor = System.Drawing.Color.Peru;
            this.opcje.Location = new System.Drawing.Point(42, 449);
            this.opcje.Name = "opcje";
            this.opcje.Size = new System.Drawing.Size(112, 28);
            this.opcje.TabIndex = 46;
            this.opcje.Text = "opcje";
            this.opcje.UseVisualStyleBackColor = true;
            this.opcje.CheckedChanged += new System.EventHandler(this.opcje_CheckedChanged);
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazwaTextBox.Location = new System.Drawing.Point(16, 151);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(167, 32);
            this.nazwaTextBox.TabIndex = 45;
            // 
            // dodaj_dostawce
            // 
            this.dodaj_dostawce.BackColor = System.Drawing.Color.PapayaWhip;
            this.dodaj_dostawce.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj_dostawce.ForeColor = System.Drawing.Color.Peru;
            this.dodaj_dostawce.Location = new System.Drawing.Point(454, 471);
            this.dodaj_dostawce.Name = "dodaj_dostawce";
            this.dodaj_dostawce.Size = new System.Drawing.Size(192, 35);
            this.dodaj_dostawce.TabIndex = 44;
            this.dodaj_dostawce.Text = "dodaj";
            this.dodaj_dostawce.UseCompatibleTextRendering = true;
            this.dodaj_dostawce.UseVisualStyleBackColor = false;
            this.dodaj_dostawce.Click += new System.EventHandler(this.dodaj_dostawce_Click);
            // 
            // zamknij_dodawanie_dostawcy
            // 
            this.zamknij_dodawanie_dostawcy.BackColor = System.Drawing.Color.PapayaWhip;
            this.zamknij_dodawanie_dostawcy.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zamknij_dodawanie_dostawcy.ForeColor = System.Drawing.Color.Peru;
            this.zamknij_dodawanie_dostawcy.Location = new System.Drawing.Point(689, 471);
            this.zamknij_dodawanie_dostawcy.Name = "zamknij_dodawanie_dostawcy";
            this.zamknij_dodawanie_dostawcy.Size = new System.Drawing.Size(209, 35);
            this.zamknij_dodawanie_dostawcy.TabIndex = 43;
            this.zamknij_dodawanie_dostawcy.Text = "anuluj";
            this.zamknij_dodawanie_dostawcy.UseCompatibleTextRendering = true;
            this.zamknij_dodawanie_dostawcy.UseVisualStyleBackColor = false;
            this.zamknij_dodawanie_dostawcy.Click += new System.EventHandler(this.zamknij_dodawanie_dostawcy_Click);
            // 
            // wybierz_dostawce
            // 
            this.wybierz_dostawce.DataSource = this.dostawcyBindingSource;
            this.wybierz_dostawce.DisplayMember = "firma";
            this.wybierz_dostawce.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wybierz_dostawce.FormattingEnabled = true;
            this.wybierz_dostawce.Location = new System.Drawing.Point(208, 151);
            this.wybierz_dostawce.Name = "wybierz_dostawce";
            this.wybierz_dostawce.Size = new System.Drawing.Size(195, 32);
            this.wybierz_dostawce.TabIndex = 61;
            // 
            // dostawcyBindingSource
            // 
            this.dostawcyBindingSource.DataMember = "Dostawcy";
            this.dostawcyBindingSource.DataSource = this.dataBaseSystemDostawcy;
            // 
            // dataBaseSystemDostawcy
            // 
            this.dataBaseSystemDostawcy.DataSetName = "DataBaseSystemDostawcy";
            this.dataBaseSystemDostawcy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dostawcyTableAdapter
            // 
            this.dostawcyTableAdapter.ClearBeforeFill = true;
            // 
            // wpisz_liczbe
            // 
            this.wpisz_liczbe.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wpisz_liczbe.Location = new System.Drawing.Point(454, 151);
            this.wpisz_liczbe.Name = "wpisz_liczbe";
            this.wpisz_liczbe.Size = new System.Drawing.Size(135, 32);
            this.wpisz_liczbe.TabIndex = 62;
            this.wpisz_liczbe.Text = "0";
            // 
            // wpisz_cene
            // 
            this.wpisz_cene.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wpisz_cene.Location = new System.Drawing.Point(16, 246);
            this.wpisz_cene.Name = "wpisz_cene";
            this.wpisz_cene.Size = new System.Drawing.Size(167, 32);
            this.wpisz_cene.TabIndex = 63;
            this.wpisz_cene.Text = "0";
            // 
            // wpisz_cene_hurtowa
            // 
            this.wpisz_cene_hurtowa.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wpisz_cene_hurtowa.Location = new System.Drawing.Point(208, 246);
            this.wpisz_cene_hurtowa.Name = "wpisz_cene_hurtowa";
            this.wpisz_cene_hurtowa.Size = new System.Drawing.Size(198, 32);
            this.wpisz_cene_hurtowa.TabIndex = 65;
            this.wpisz_cene_hurtowa.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(207, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 64;
            this.label1.Text = "cena hurtowa";
            // 
            // wpisz_opis
            // 
            this.wpisz_opis.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wpisz_opis.Location = new System.Drawing.Point(454, 246);
            this.wpisz_opis.Multiline = true;
            this.wpisz_opis.Name = "wpisz_opis";
            this.wpisz_opis.Size = new System.Drawing.Size(444, 149);
            this.wpisz_opis.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Peru;
            this.label5.Location = new System.Drawing.Point(656, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 68;
            this.label5.Text = "kod";
            this.label5.Visible = false;
            // 
            // wpisz_kod
            // 
            this.wpisz_kod.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wpisz_kod.Location = new System.Drawing.Point(646, 151);
            this.wpisz_kod.Name = "wpisz_kod";
            this.wpisz_kod.Size = new System.Drawing.Size(252, 32);
            this.wpisz_kod.TabIndex = 67;
            this.wpisz_kod.Text = "0000 0000";
            // 
            // wpisz_wymiary
            // 
            this.wpisz_wymiary.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wpisz_wymiary.Location = new System.Drawing.Point(208, 363);
            this.wpisz_wymiary.Name = "wpisz_wymiary";
            this.wpisz_wymiary.Size = new System.Drawing.Size(195, 32);
            this.wpisz_wymiary.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Peru;
            this.label6.Location = new System.Drawing.Point(207, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 71;
            this.label6.Text = "wymiary";
            // 
            // wpisz_wage
            // 
            this.wpisz_wage.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wpisz_wage.Location = new System.Drawing.Point(16, 363);
            this.wpisz_wage.Name = "wpisz_wage";
            this.wpisz_wage.Size = new System.Drawing.Size(167, 32);
            this.wpisz_wage.TabIndex = 70;
            this.wpisz_wage.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Peru;
            this.label7.Location = new System.Drawing.Point(52, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 69;
            this.label7.Text = "waga";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Peru;
            this.label8.Location = new System.Drawing.Point(460, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 24);
            this.label8.TabIndex = 73;
            this.label8.Text = "opis";
            // 
            // Strona_Dodawania_Produktu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(927, 548);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.wpisz_wymiary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.wpisz_wage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wpisz_kod);
            this.Controls.Add(this.wpisz_opis);
            this.Controls.Add(this.wpisz_cene_hurtowa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wpisz_cene);
            this.Controls.Add(this.wpisz_liczbe);
            this.Controls.Add(this.wybierz_dostawce);
            this.Controls.Add(this.dat1);
            this.Controls.Add(this.dat2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazwa_label);
            this.Controls.Add(this.tytul_dodaj_produkt);
            this.Controls.Add(this.opcje);
            this.Controls.Add(this.nazwaTextBox);
            this.Controls.Add(this.dodaj_dostawce);
            this.Controls.Add(this.zamknij_dodawanie_dostawcy);
            this.Name = "Strona_Dodawania_Produktu";
            this.Text = "Strona_Dodawania_Produktu";
            this.Load += new System.EventHandler(this.Strona_Dodawania_Produktu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dostawcyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseSystemDostawcy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dat1;
        private System.Windows.Forms.DateTimePicker dat2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nazwa_label;
        private System.Windows.Forms.Label tytul_dodaj_produkt;
        private System.Windows.Forms.CheckBox opcje;
        private System.Windows.Forms.TextBox nazwaTextBox;
        private System.Windows.Forms.Button dodaj_dostawce;
        private System.Windows.Forms.Button zamknij_dodawanie_dostawcy;
        private System.Windows.Forms.ComboBox wybierz_dostawce;
        private DataBaseSystemDostawcy dataBaseSystemDostawcy;
        private System.Windows.Forms.BindingSource dostawcyBindingSource;
        private DataBaseSystemDostawcyTableAdapters.DostawcyTableAdapter dostawcyTableAdapter;
        private System.Windows.Forms.TextBox wpisz_liczbe;
        private System.Windows.Forms.TextBox wpisz_cene;
        private System.Windows.Forms.TextBox wpisz_cene_hurtowa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wpisz_opis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox wpisz_kod;
        private System.Windows.Forms.TextBox wpisz_wymiary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox wpisz_wage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}