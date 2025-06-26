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
            this.cofnij_do_strony_glownej = new System.Windows.Forms.Button();
            this.lista_klientow = new System.Windows.Forms.CheckedListBox();
            this.tytul_klienci = new System.Windows.Forms.Label();
            this.dodaj_klienta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cofnij_do_strony_glownej
            // 
            this.cofnij_do_strony_glownej.BackColor = System.Drawing.Color.PapayaWhip;
            this.cofnij_do_strony_glownej.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cofnij_do_strony_glownej.ForeColor = System.Drawing.Color.Peru;
            this.cofnij_do_strony_glownej.Location = new System.Drawing.Point(578, 455);
            this.cofnij_do_strony_glownej.Name = "cofnij_do_strony_glownej";
            this.cofnij_do_strony_glownej.Size = new System.Drawing.Size(234, 35);
            this.cofnij_do_strony_glownej.TabIndex = 0;
            this.cofnij_do_strony_glownej.Text = "wróć";
            this.cofnij_do_strony_glownej.UseCompatibleTextRendering = true;
            this.cofnij_do_strony_glownej.UseVisualStyleBackColor = false;
            this.cofnij_do_strony_glownej.Click += new System.EventHandler(this.cofnij_do_strony_glownej_Click);
            // 
            // lista_klientow
            // 
            this.lista_klientow.BackColor = System.Drawing.Color.Bisque;
            this.lista_klientow.CheckOnClick = true;
            this.lista_klientow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lista_klientow.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_klientow.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lista_klientow.FormattingEnabled = true;
            this.lista_klientow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lista_klientow.IntegralHeight = false;
            this.lista_klientow.Location = new System.Drawing.Point(21, 98);
            this.lista_klientow.Name = "lista_klientow";
            this.lista_klientow.ScrollAlwaysVisible = true;
            this.lista_klientow.Size = new System.Drawing.Size(825, 315);
            this.lista_klientow.TabIndex = 2;
            this.lista_klientow.ThreeDCheckBoxes = true;
            this.lista_klientow.UseCompatibleTextRendering = true;
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
            // dodaj_klienta
            // 
            this.dodaj_klienta.BackColor = System.Drawing.Color.PapayaWhip;
            this.dodaj_klienta.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj_klienta.ForeColor = System.Drawing.Color.Peru;
            this.dodaj_klienta.Location = new System.Drawing.Point(45, 455);
            this.dodaj_klienta.Name = "dodaj_klienta";
            this.dodaj_klienta.Size = new System.Drawing.Size(400, 35);
            this.dodaj_klienta.TabIndex = 4;
            this.dodaj_klienta.Text = "dodaj nowego klienta";
            this.dodaj_klienta.UseCompatibleTextRendering = true;
            this.dodaj_klienta.UseVisualStyleBackColor = false;
            this.dodaj_klienta.Click += new System.EventHandler(this.dodaj_klienta_Click);
            // 
            // Strona_Klientow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(880, 528);
            this.Controls.Add(this.dodaj_klienta);
            this.Controls.Add(this.tytul_klienci);
            this.Controls.Add(this.lista_klientow);
            this.Controls.Add(this.cofnij_do_strony_glownej);
            this.Name = "Strona_Klientow";
            this.Text = "Strona_Klientow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cofnij_do_strony_glownej;
        private System.Windows.Forms.CheckedListBox lista_klientow;
        private System.Windows.Forms.Label tytul_klienci;
        private System.Windows.Forms.Button dodaj_klienta;
    }
}