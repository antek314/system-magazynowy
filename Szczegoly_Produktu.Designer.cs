namespace System_Magazynowy
{
    partial class Szczegoly_Produktu
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
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nazwa_label = new System.Windows.Forms.Label();
            this.tytul_szczegoly_produktu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Peru;
            this.label8.Location = new System.Drawing.Point(511, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 24);
            this.label8.TabIndex = 84;
            this.label8.Text = "opis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(235, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 81;
            this.label1.Text = "cena hurtowa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Peru;
            this.label4.Location = new System.Drawing.Point(83, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 78;
            this.label4.Text = "cena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(232, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 77;
            this.label2.Text = "dostawca";
            // 
            // nazwa_label
            // 
            this.nazwa_label.AutoSize = true;
            this.nazwa_label.Font = new System.Drawing.Font("Monotxt_IV25", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazwa_label.ForeColor = System.Drawing.Color.Peru;
            this.nazwa_label.Location = new System.Drawing.Point(77, 145);
            this.nazwa_label.Name = "nazwa_label";
            this.nazwa_label.Size = new System.Drawing.Size(90, 24);
            this.nazwa_label.TabIndex = 76;
            this.nazwa_label.Text = "nazwa";
            // 
            // tytul_szczegoly_produktu
            // 
            this.tytul_szczegoly_produktu.AutoSize = true;
            this.tytul_szczegoly_produktu.Font = new System.Drawing.Font("Monotxt_IV25", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tytul_szczegoly_produktu.ForeColor = System.Drawing.Color.Peru;
            this.tytul_szczegoly_produktu.Location = new System.Drawing.Point(47, 44);
            this.tytul_szczegoly_produktu.Name = "tytul_szczegoly_produktu";
            this.tytul_szczegoly_produktu.Size = new System.Drawing.Size(599, 53);
            this.tytul_szczegoly_produktu.TabIndex = 75;
            this.tytul_szczegoly_produktu.Text = "Szczegóły Produktu";
            // 
            // Szczegoly_Produktu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1106, 609);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazwa_label);
            this.Controls.Add(this.tytul_szczegoly_produktu);
            this.Name = "Szczegoly_Produktu";
            this.Text = "Szczegoly_Produktu";
            this.Load += new System.EventHandler(this.Szczegoly_Produktu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nazwa_label;
        private System.Windows.Forms.Label tytul_szczegoly_produktu;
    }
}