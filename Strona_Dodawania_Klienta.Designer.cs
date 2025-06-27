namespace System_Magazynowy
{
    partial class Strona_Dodawania_Klienta
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
            this.dodaj_klienta = new System.Windows.Forms.Button();
            this.zamknij_dodawanie_klienta = new System.Windows.Forms.Button();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tytul_dodaj_klienta = new System.Windows.Forms.Label();
            this.imie_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.miejscowoscTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firmaTextBox = new System.Windows.Forms.TextBox();
            this.dat2 = new System.Windows.Forms.DateTimePicker();
            this.dat1 = new System.Windows.Forms.Label();
            this.prz2 = new System.Windows.Forms.TextBox();
            this.prz1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dodaj_klienta
            // 
            this.dodaj_klienta.BackColor = System.Drawing.Color.PapayaWhip;
            this.dodaj_klienta.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj_klienta.ForeColor = System.Drawing.Color.Peru;
            this.dodaj_klienta.Location = new System.Drawing.Point(58, 366);
            this.dodaj_klienta.Name = "dodaj_klienta";
            this.dodaj_klienta.Size = new System.Drawing.Size(221, 35);
            this.dodaj_klienta.TabIndex = 6;
            this.dodaj_klienta.Text = "dodaj";
            this.dodaj_klienta.UseCompatibleTextRendering = true;
            this.dodaj_klienta.UseVisualStyleBackColor = false;
            this.dodaj_klienta.Click += new System.EventHandler(this.dodaj_klienta_Click);
            // 
            // zamknij_dodawanie_klienta
            // 
            this.zamknij_dodawanie_klienta.BackColor = System.Drawing.Color.PapayaWhip;
            this.zamknij_dodawanie_klienta.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zamknij_dodawanie_klienta.ForeColor = System.Drawing.Color.Peru;
            this.zamknij_dodawanie_klienta.Location = new System.Drawing.Point(497, 366);
            this.zamknij_dodawanie_klienta.Name = "zamknij_dodawanie_klienta";
            this.zamknij_dodawanie_klienta.Size = new System.Drawing.Size(234, 35);
            this.zamknij_dodawanie_klienta.TabIndex = 5;
            this.zamknij_dodawanie_klienta.Text = "anuluj";
            this.zamknij_dodawanie_klienta.UseCompatibleTextRendering = true;
            this.zamknij_dodawanie_klienta.UseVisualStyleBackColor = false;
            this.zamknij_dodawanie_klienta.Click += new System.EventHandler(this.zamknij_dodawanie_klienta_Click);
            // 
            // imieTextBox
            // 
            this.imieTextBox.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imieTextBox.Location = new System.Drawing.Point(28, 180);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(120, 32);
            this.imieTextBox.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Peru;
            this.checkBox1.Location = new System.Drawing.Point(36, 283);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 28);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "opcje";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tytul_dodaj_klienta
            // 
            this.tytul_dodaj_klienta.AutoSize = true;
            this.tytul_dodaj_klienta.Font = new System.Drawing.Font("Monotxt_IV25", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tytul_dodaj_klienta.ForeColor = System.Drawing.Color.Peru;
            this.tytul_dodaj_klienta.Location = new System.Drawing.Point(48, 44);
            this.tytul_dodaj_klienta.Name = "tytul_dodaj_klienta";
            this.tytul_dodaj_klienta.Size = new System.Drawing.Size(439, 53);
            this.tytul_dodaj_klienta.TabIndex = 12;
            this.tytul_dodaj_klienta.Text = "Dodaj Klienta";
            // 
            // imie_label
            // 
            this.imie_label.AutoSize = true;
            this.imie_label.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imie_label.ForeColor = System.Drawing.Color.Peru;
            this.imie_label.Location = new System.Drawing.Point(53, 156);
            this.imie_label.Name = "imie_label";
            this.imie_label.Size = new System.Drawing.Size(74, 24);
            this.imie_label.TabIndex = 13;
            this.imie_label.Text = "imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(202, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "nazwisko";
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazwiskoTextBox.Location = new System.Drawing.Point(195, 180);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(154, 32);
            this.nazwiskoTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(418, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "miejscowość";
            // 
            // miejscowoscTextBox
            // 
            this.miejscowoscTextBox.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miejscowoscTextBox.Location = new System.Drawing.Point(411, 180);
            this.miejscowoscTextBox.Name = "miejscowoscTextBox";
            this.miejscowoscTextBox.Size = new System.Drawing.Size(198, 32);
            this.miejscowoscTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Peru;
            this.label4.Location = new System.Drawing.Point(660, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "firma";
            // 
            // firmaTextBox
            // 
            this.firmaTextBox.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firmaTextBox.Location = new System.Drawing.Point(653, 180);
            this.firmaTextBox.Name = "firmaTextBox";
            this.firmaTextBox.Size = new System.Drawing.Size(118, 32);
            this.firmaTextBox.TabIndex = 18;
            // 
            // dat2
            // 
            this.dat2.Font = new System.Drawing.Font("Monotxt_IV25", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dat2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dat2.Location = new System.Drawing.Point(224, 293);
            this.dat2.Name = "dat2";
            this.dat2.Size = new System.Drawing.Size(209, 30);
            this.dat2.TabIndex = 21;
            this.dat2.Visible = false;
            // 
            // dat1
            // 
            this.dat1.AutoSize = true;
            this.dat1.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dat1.ForeColor = System.Drawing.Color.Peru;
            this.dat1.Location = new System.Drawing.Point(231, 266);
            this.dat1.Name = "dat1";
            this.dat1.Size = new System.Drawing.Size(202, 24);
            this.dat1.TabIndex = 22;
            this.dat1.Text = "data dodania";
            this.dat1.Visible = false;
            // 
            // prz2
            // 
            this.prz2.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prz2.Location = new System.Drawing.Point(487, 295);
            this.prz2.Name = "prz2";
            this.prz2.Size = new System.Drawing.Size(262, 32);
            this.prz2.TabIndex = 23;
            this.prz2.Text = "0";
            this.prz2.Visible = false;
            // 
            // prz1
            // 
            this.prz1.AutoSize = true;
            this.prz1.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prz1.ForeColor = System.Drawing.Color.Peru;
            this.prz1.Location = new System.Drawing.Point(484, 268);
            this.prz1.Name = "prz1";
            this.prz1.Size = new System.Drawing.Size(266, 24);
            this.prz1.TabIndex = 24;
            this.prz1.Text = "przychód klienta";
            this.prz1.Visible = false;
            // 
            // Strona_Dodawania_Klienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prz1);
            this.Controls.Add(this.prz2);
            this.Controls.Add(this.dat1);
            this.Controls.Add(this.dat2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firmaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.miejscowoscTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(this.imie_label);
            this.Controls.Add(this.tytul_dodaj_klienta);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(this.dodaj_klienta);
            this.Controls.Add(this.zamknij_dodawanie_klienta);
            this.ForeColor = System.Drawing.Color.PapayaWhip;
            this.Name = "Strona_Dodawania_Klienta";
            this.Text = "Strona_Dodawania_Klienta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodaj_klienta;
        private System.Windows.Forms.Button zamknij_dodawanie_klienta;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label tytul_dodaj_klienta;
        private System.Windows.Forms.Label imie_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox miejscowoscTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firmaTextBox;
        private System.Windows.Forms.DateTimePicker dat2;
        private System.Windows.Forms.Label dat1;
        private System.Windows.Forms.TextBox prz2;
        private System.Windows.Forms.Label prz1;
    }
}