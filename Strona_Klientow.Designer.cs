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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cofnij_do_strony_glownej = new System.Windows.Forms.Button();
            this.tytul_klienci = new System.Windows.Forms.Label();
            this.dodaj_nowego_klienta = new System.Windows.Forms.Button();
            this.tabela_klientow = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idklientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dochodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseSystemKlienci = new System_Magazynowy.DataBaseSystemKlienci();
            this.przycisk_usun_rekord_klienta = new System.Windows.Forms.Button();
            this.klienciTableAdapter = new System_Magazynowy.DataBaseSystemKlienciTableAdapters.KlienciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_klientow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseSystemKlienci)).BeginInit();
            this.SuspendLayout();
            // 
            // cofnij_do_strony_glownej
            // 
            this.cofnij_do_strony_glownej.BackColor = System.Drawing.Color.PapayaWhip;
            this.cofnij_do_strony_glownej.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cofnij_do_strony_glownej.ForeColor = System.Drawing.Color.Peru;
            this.cofnij_do_strony_glownej.Location = new System.Drawing.Point(854, 508);
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
            this.tytul_klienci.Location = new System.Drawing.Point(57, 25);
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
            this.dodaj_nowego_klienta.Location = new System.Drawing.Point(49, 508);
            this.dodaj_nowego_klienta.Name = "dodaj_nowego_klienta";
            this.dodaj_nowego_klienta.Size = new System.Drawing.Size(400, 35);
            this.dodaj_nowego_klienta.TabIndex = 4;
            this.dodaj_nowego_klienta.Text = "dodaj nowego klienta";
            this.dodaj_nowego_klienta.UseCompatibleTextRendering = true;
            this.dodaj_nowego_klienta.UseVisualStyleBackColor = false;
            this.dodaj_nowego_klienta.Click += new System.EventHandler(this.dodaj_klienta_Click);
            // 
            // tabela_klientow
            // 
            this.tabela_klientow.AllowUserToAddRows = false;
            this.tabela_klientow.AutoGenerateColumns = false;
            this.tabela_klientow.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.tabela_klientow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabela_klientow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabela_klientow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela_klientow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabela_klientow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_klientow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.idklientaDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.miejscowoscDataGridViewTextBoxColumn,
            this.firmaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.dochodDataGridViewTextBoxColumn});
            this.tabela_klientow.DataSource = this.klienciBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabela_klientow.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabela_klientow.EnableHeadersVisualStyles = false;
            this.tabela_klientow.Location = new System.Drawing.Point(12, 99);
            this.tabela_klientow.Name = "tabela_klientow";
            this.tabela_klientow.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabela_klientow.RowHeadersVisible = false;
            this.tabela_klientow.RowHeadersWidth = 51;
            this.tabela_klientow.RowTemplate.Height = 24;
            this.tabela_klientow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela_klientow.Size = new System.Drawing.Size(1248, 390);
            this.tabela_klientow.TabIndex = 9;
            // 
            // a
            // 
            this.a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.a.HeaderText = "*";
            this.a.MinimumWidth = 6;
            this.a.Name = "a";
            this.a.Width = 30;
            // 
            // idklientaDataGridViewTextBoxColumn
            // 
            this.idklientaDataGridViewTextBoxColumn.DataPropertyName = "Id_klienta";
            this.idklientaDataGridViewTextBoxColumn.HeaderText = "id";
            this.idklientaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idklientaDataGridViewTextBoxColumn.Name = "idklientaDataGridViewTextBoxColumn";
            this.idklientaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idklientaDataGridViewTextBoxColumn.Width = 45;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "imie";
            this.imieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.Width = 140;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.Width = 140;
            // 
            // miejscowoscDataGridViewTextBoxColumn
            // 
            this.miejscowoscDataGridViewTextBoxColumn.DataPropertyName = "miejscowosc";
            this.miejscowoscDataGridViewTextBoxColumn.HeaderText = "miejscowość";
            this.miejscowoscDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.miejscowoscDataGridViewTextBoxColumn.Name = "miejscowoscDataGridViewTextBoxColumn";
            this.miejscowoscDataGridViewTextBoxColumn.Width = 200;
            // 
            // firmaDataGridViewTextBoxColumn
            // 
            this.firmaDataGridViewTextBoxColumn.DataPropertyName = "firma";
            this.firmaDataGridViewTextBoxColumn.HeaderText = "firma";
            this.firmaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firmaDataGridViewTextBoxColumn.Name = "firmaDataGridViewTextBoxColumn";
            this.firmaDataGridViewTextBoxColumn.Width = 160;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 140;
            // 
            // dochodDataGridViewTextBoxColumn
            // 
            this.dochodDataGridViewTextBoxColumn.DataPropertyName = "dochod";
            this.dochodDataGridViewTextBoxColumn.HeaderText = "dochod";
            this.dochodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dochodDataGridViewTextBoxColumn.Name = "dochodDataGridViewTextBoxColumn";
            this.dochodDataGridViewTextBoxColumn.Width = 125;
            // 
            // klienciBindingSource
            // 
            this.klienciBindingSource.DataMember = "Klienci";
            this.klienciBindingSource.DataSource = this.dataBaseSystemKlienci;
            // 
            // dataBaseSystemKlienci
            // 
            this.dataBaseSystemKlienci.DataSetName = "DataBaseSystemKlienci";
            this.dataBaseSystemKlienci.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // przycisk_usun_rekord_klienta
            // 
            this.przycisk_usun_rekord_klienta.BackColor = System.Drawing.Color.PapayaWhip;
            this.przycisk_usun_rekord_klienta.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.przycisk_usun_rekord_klienta.ForeColor = System.Drawing.Color.Peru;
            this.przycisk_usun_rekord_klienta.Location = new System.Drawing.Point(537, 508);
            this.przycisk_usun_rekord_klienta.Name = "przycisk_usun_rekord_klienta";
            this.przycisk_usun_rekord_klienta.Size = new System.Drawing.Size(234, 35);
            this.przycisk_usun_rekord_klienta.TabIndex = 10;
            this.przycisk_usun_rekord_klienta.Text = "usuń";
            this.przycisk_usun_rekord_klienta.UseCompatibleTextRendering = true;
            this.przycisk_usun_rekord_klienta.UseVisualStyleBackColor = false;
            this.przycisk_usun_rekord_klienta.Click += new System.EventHandler(this.przycisk_usun_rekord_klienta_Click);
            // 
            // klienciTableAdapter
            // 
            this.klienciTableAdapter.ClearBeforeFill = true;
            // 
            // Strona_Klientow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1272, 570);
            this.Controls.Add(this.przycisk_usun_rekord_klienta);
            this.Controls.Add(this.tabela_klientow);
            this.Controls.Add(this.dodaj_nowego_klienta);
            this.Controls.Add(this.tytul_klienci);
            this.Controls.Add(this.cofnij_do_strony_glownej);
            this.Name = "Strona_Klientow";
            this.Text = "Strona_Klientow";
            this.Load += new System.EventHandler(this.Strona_Klientow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_klientow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseSystemKlienci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cofnij_do_strony_glownej;
        private System.Windows.Forms.Label tytul_klienci;
        private System.Windows.Forms.Button dodaj_nowego_klienta;
        private DataGridView tabela_klientow;
        private Button przycisk_usun_rekord_klienta;
        private DataBaseSystemKlienci dataBaseSystemKlienci;
        private BindingSource klienciBindingSource;
        private DataBaseSystemKlienciTableAdapters.KlienciTableAdapter klienciTableAdapter;
        private DataGridViewCheckBoxColumn a;
        private DataGridViewTextBoxColumn idklientaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn miejscowoscDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firmaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dochodDataGridViewTextBoxColumn;
    }
}