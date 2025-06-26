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
            this.tytul_systemu = new System.Windows.Forms.Label();
            this.przejdz_do_strony_klientow = new System.Windows.Forms.Button();
            this.zamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tytul_systemu
            // 
            this.tytul_systemu.AutoSize = true;
            this.tytul_systemu.Font = new System.Drawing.Font("Monotxt_IV25", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tytul_systemu.ForeColor = System.Drawing.Color.Peru;
            this.tytul_systemu.Location = new System.Drawing.Point(12, 9);
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
            this.przejdz_do_strony_klientow.Location = new System.Drawing.Point(32, 117);
            this.przejdz_do_strony_klientow.Name = "przejdz_do_strony_klientow";
            this.przejdz_do_strony_klientow.Size = new System.Drawing.Size(115, 90);
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
            this.zamknij.Location = new System.Drawing.Point(832, 442);
            this.zamknij.Name = "zamknij";
            this.zamknij.Size = new System.Drawing.Size(110, 40);
            this.zamknij.TabIndex = 2;
            this.zamknij.Text = "zamknij";
            this.zamknij.UseCompatibleTextRendering = true;
            this.zamknij.UseVisualStyleBackColor = true;
            this.zamknij.Click += new System.EventHandler(this.zamknij_Click);
            // 
            // Strona_Glowna
            // 
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(966, 494);
            this.Controls.Add(this.zamknij);
            this.Controls.Add(this.przejdz_do_strony_klientow);
            this.Controls.Add(this.tytul_systemu);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Name = "Strona_Glowna";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label tytul_systemu;
        private System.Windows.Forms.Button przejdz_do_strony_klientow;
        private System.Windows.Forms.Button zamknij;
    }
}

