namespace System_Magazynowy
{
    partial class Strona_Dostawcow
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
            this.tytul_dostawcy = new System.Windows.Forms.Label();
            this.przycisk_usun_rekord_klienta = new System.Windows.Forms.Button();
            this.dodaj_nowego_dostawce = new System.Windows.Forms.Button();
            this.cofnij_do_strony_glownej = new System.Windows.Forms.Button();
            this.tabela_dostawcow = new System.Windows.Forms.DataGridView();
            this.dataBaseSystemDostawcy = new System_Magazynowy.DataBaseSystemDostawcy();
            this.dostawcyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dostawcyTableAdapter = new System_Magazynowy.DataBaseSystemDostawcyTableAdapters.DostawcyTableAdapter();
            this.a = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iddostawcyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosztyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczbatransakcjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datadodaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataostatniejtransakcjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_dostawcow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseSystemDostawcy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawcyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tytul_dostawcy
            // 
            this.tytul_dostawcy.AutoSize = true;
            this.tytul_dostawcy.Font = new System.Drawing.Font("Monotxt_IV25", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tytul_dostawcy.ForeColor = System.Drawing.Color.Peru;
            this.tytul_dostawcy.Location = new System.Drawing.Point(60, 22);
            this.tytul_dostawcy.Name = "tytul_dostawcy";
            this.tytul_dostawcy.Size = new System.Drawing.Size(535, 53);
            this.tytul_dostawcy.TabIndex = 4;
            this.tytul_dostawcy.Text = "Strona Dostawców";
            // 
            // przycisk_usun_rekord_klienta
            // 
            this.przycisk_usun_rekord_klienta.BackColor = System.Drawing.Color.PapayaWhip;
            this.przycisk_usun_rekord_klienta.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.przycisk_usun_rekord_klienta.ForeColor = System.Drawing.Color.Peru;
            this.przycisk_usun_rekord_klienta.Location = new System.Drawing.Point(543, 631);
            this.przycisk_usun_rekord_klienta.Name = "przycisk_usun_rekord_klienta";
            this.przycisk_usun_rekord_klienta.Size = new System.Drawing.Size(234, 35);
            this.przycisk_usun_rekord_klienta.TabIndex = 13;
            this.przycisk_usun_rekord_klienta.Text = "usuń";
            this.przycisk_usun_rekord_klienta.UseCompatibleTextRendering = true;
            this.przycisk_usun_rekord_klienta.UseVisualStyleBackColor = false;
            // 
            // dodaj_nowego_dostawce
            // 
            this.dodaj_nowego_dostawce.BackColor = System.Drawing.Color.PapayaWhip;
            this.dodaj_nowego_dostawce.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj_nowego_dostawce.ForeColor = System.Drawing.Color.Peru;
            this.dodaj_nowego_dostawce.Location = new System.Drawing.Point(55, 631);
            this.dodaj_nowego_dostawce.Name = "dodaj_nowego_dostawce";
            this.dodaj_nowego_dostawce.Size = new System.Drawing.Size(400, 35);
            this.dodaj_nowego_dostawce.TabIndex = 12;
            this.dodaj_nowego_dostawce.Text = "dodaj nowego dostawce";
            this.dodaj_nowego_dostawce.UseCompatibleTextRendering = true;
            this.dodaj_nowego_dostawce.UseVisualStyleBackColor = false;
            this.dodaj_nowego_dostawce.Click += new System.EventHandler(this.dodaj_nowego_dostawce_Click);
            // 
            // cofnij_do_strony_glownej
            // 
            this.cofnij_do_strony_glownej.BackColor = System.Drawing.Color.PapayaWhip;
            this.cofnij_do_strony_glownej.Font = new System.Drawing.Font("Monotxt_IV25", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cofnij_do_strony_glownej.ForeColor = System.Drawing.Color.Peru;
            this.cofnij_do_strony_glownej.Location = new System.Drawing.Point(860, 631);
            this.cofnij_do_strony_glownej.Name = "cofnij_do_strony_glownej";
            this.cofnij_do_strony_glownej.Size = new System.Drawing.Size(234, 35);
            this.cofnij_do_strony_glownej.TabIndex = 11;
            this.cofnij_do_strony_glownej.Text = "wróć";
            this.cofnij_do_strony_glownej.UseCompatibleTextRendering = true;
            this.cofnij_do_strony_glownej.UseVisualStyleBackColor = false;
            this.cofnij_do_strony_glownej.Click += new System.EventHandler(this.cofnij_do_strony_glownej_Click);
            // 
            // tabela_dostawcow
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tabela_dostawcow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabela_dostawcow.AutoGenerateColumns = false;
            this.tabela_dostawcow.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.tabela_dostawcow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabela_dostawcow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabela_dostawcow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela_dostawcow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabela_dostawcow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_dostawcow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.iddostawcyDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.firmaDataGridViewTextBoxColumn,
            this.kosztyDataGridViewTextBoxColumn,
            this.liczbatransakcjiDataGridViewTextBoxColumn,
            this.datadodaniaDataGridViewTextBoxColumn,
            this.dataostatniejtransakcjiDataGridViewTextBoxColumn,
            this.miejscowoscDataGridViewTextBoxColumn});
            this.tabela_dostawcow.DataSource = this.dostawcyBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabela_dostawcow.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabela_dostawcow.EnableHeadersVisualStyles = false;
            this.tabela_dostawcow.Location = new System.Drawing.Point(33, 100);
            this.tabela_dostawcow.Name = "tabela_dostawcow";
            this.tabela_dostawcow.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela_dostawcow.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tabela_dostawcow.RowHeadersVisible = false;
            this.tabela_dostawcow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tabela_dostawcow.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tabela_dostawcow.RowTemplate.Height = 24;
            this.tabela_dostawcow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela_dostawcow.Size = new System.Drawing.Size(1342, 464);
            this.tabela_dostawcow.TabIndex = 14;
            // 
            // dataBaseSystemDostawcy
            // 
            this.dataBaseSystemDostawcy.DataSetName = "DataBaseSystemDostawcy";
            this.dataBaseSystemDostawcy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dostawcyBindingSource
            // 
            this.dostawcyBindingSource.DataMember = "Dostawcy";
            this.dostawcyBindingSource.DataSource = this.dataBaseSystemDostawcy;
            // 
            // dostawcyTableAdapter
            // 
            this.dostawcyTableAdapter.ClearBeforeFill = true;
            // 
            // a
            // 
            this.a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.a.HeaderText = "*";
            this.a.MinimumWidth = 6;
            this.a.Name = "a";
            this.a.Width = 30;
            // 
            // iddostawcyDataGridViewTextBoxColumn
            // 
            this.iddostawcyDataGridViewTextBoxColumn.DataPropertyName = "Id_dostawcy";
            this.iddostawcyDataGridViewTextBoxColumn.HeaderText = "Id";
            this.iddostawcyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iddostawcyDataGridViewTextBoxColumn.Name = "iddostawcyDataGridViewTextBoxColumn";
            this.iddostawcyDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddostawcyDataGridViewTextBoxColumn.Width = 45;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "imie";
            this.imieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.Width = 140;
            // 
            // firmaDataGridViewTextBoxColumn
            // 
            this.firmaDataGridViewTextBoxColumn.DataPropertyName = "firma";
            this.firmaDataGridViewTextBoxColumn.HeaderText = "firma";
            this.firmaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firmaDataGridViewTextBoxColumn.Name = "firmaDataGridViewTextBoxColumn";
            this.firmaDataGridViewTextBoxColumn.Width = 110;
            // 
            // kosztyDataGridViewTextBoxColumn
            // 
            this.kosztyDataGridViewTextBoxColumn.DataPropertyName = "koszty";
            this.kosztyDataGridViewTextBoxColumn.HeaderText = "koszty";
            this.kosztyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kosztyDataGridViewTextBoxColumn.Name = "kosztyDataGridViewTextBoxColumn";
            this.kosztyDataGridViewTextBoxColumn.Width = 110;
            // 
            // liczbatransakcjiDataGridViewTextBoxColumn
            // 
            this.liczbatransakcjiDataGridViewTextBoxColumn.DataPropertyName = "liczba_transakcji";
            this.liczbatransakcjiDataGridViewTextBoxColumn.HeaderText = "transakcje";
            this.liczbatransakcjiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.liczbatransakcjiDataGridViewTextBoxColumn.Name = "liczbatransakcjiDataGridViewTextBoxColumn";
            this.liczbatransakcjiDataGridViewTextBoxColumn.Width = 180;
            // 
            // datadodaniaDataGridViewTextBoxColumn
            // 
            this.datadodaniaDataGridViewTextBoxColumn.DataPropertyName = "data_dodania";
            this.datadodaniaDataGridViewTextBoxColumn.HeaderText = "dodane";
            this.datadodaniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datadodaniaDataGridViewTextBoxColumn.Name = "datadodaniaDataGridViewTextBoxColumn";
            this.datadodaniaDataGridViewTextBoxColumn.Width = 120;
            // 
            // dataostatniejtransakcjiDataGridViewTextBoxColumn
            // 
            this.dataostatniejtransakcjiDataGridViewTextBoxColumn.DataPropertyName = "data_ostatniej_transakcji";
            this.dataostatniejtransakcjiDataGridViewTextBoxColumn.HeaderText = "ostatnia transakcja";
            this.dataostatniejtransakcjiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataostatniejtransakcjiDataGridViewTextBoxColumn.Name = "dataostatniejtransakcjiDataGridViewTextBoxColumn";
            this.dataostatniejtransakcjiDataGridViewTextBoxColumn.Width = 200;
            // 
            // miejscowoscDataGridViewTextBoxColumn
            // 
            this.miejscowoscDataGridViewTextBoxColumn.DataPropertyName = "miejscowosc";
            this.miejscowoscDataGridViewTextBoxColumn.HeaderText = "miejscowosc";
            this.miejscowoscDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.miejscowoscDataGridViewTextBoxColumn.Name = "miejscowoscDataGridViewTextBoxColumn";
            this.miejscowoscDataGridViewTextBoxColumn.Width = 180;
            // 
            // Strona_Dostawcow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1403, 714);
            this.Controls.Add(this.tabela_dostawcow);
            this.Controls.Add(this.przycisk_usun_rekord_klienta);
            this.Controls.Add(this.dodaj_nowego_dostawce);
            this.Controls.Add(this.cofnij_do_strony_glownej);
            this.Controls.Add(this.tytul_dostawcy);
            this.Name = "Strona_Dostawcow";
            this.Text = "StronaDostawcow";
            this.Load += new System.EventHandler(this.Strona_Dostawcow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_dostawcow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseSystemDostawcy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawcyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tytul_dostawcy;
        private System.Windows.Forms.Button przycisk_usun_rekord_klienta;
        private System.Windows.Forms.Button dodaj_nowego_dostawce;
        private System.Windows.Forms.Button cofnij_do_strony_glownej;
        private System.Windows.Forms.DataGridView tabela_dostawcow;
        private DataBaseSystemDostawcy dataBaseSystemDostawcy;
        private System.Windows.Forms.BindingSource dostawcyBindingSource;
        private DataBaseSystemDostawcyTableAdapters.DostawcyTableAdapter dostawcyTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddostawcyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosztyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczbatransakcjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datadodaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataostatniejtransakcjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejscowoscDataGridViewTextBoxColumn;
    }
}