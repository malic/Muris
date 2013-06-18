namespace Geoizmjera_PI
{
    partial class unos_poslova
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.postgresDataSet = new Geoizmjera_PI.postgresDataSet();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klijentTableAdapter = new Geoizmjera_PI.postgresDataSetTableAdapters.KlijentTableAdapter();
            this.tableAdapterManager = new Geoizmjera_PI.postgresDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewKlijent = new System.Windows.Forms.DataGridView();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojTelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojMobitelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.posaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posaoTableAdapter = new Geoizmjera_PI.postgresDataSetTableAdapters.PosaoTableAdapter();
            this.cesticeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cesticeTableAdapter = new Geoizmjera_PI.postgresDataSetTableAdapters.CesticeTableAdapter();
            this.mBROpcineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postgresDataSet1 = new Geoizmjera_PI.postgresDataSet();
            this.mBROpcineTableAdapter = new Geoizmjera_PI.postgresDataSetTableAdapters.MBROpcineTableAdapter();
            this.vrstaPoslaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vrstaPoslaTableAdapter = new Geoizmjera_PI.postgresDataSetTableAdapters.VrstaPoslaTableAdapter();
            this.lblDatumTerena = new System.Windows.Forms.Label();
            this.lblVrijemeTerena = new System.Windows.Forms.Label();
            this.lblVrstaPosla = new System.Windows.Forms.Label();
            this.lblNazivOpcine = new System.Windows.Forms.Label();
            this.lblDatumNarudzbe = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.lblOIB = new System.Windows.Forms.Label();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.cmbVrijeme1 = new System.Windows.Forms.ComboBox();
            this.cmbVrijeme2 = new System.Windows.Forms.ComboBox();
            this.dtpDatumTerena = new System.Windows.Forms.DateTimePicker();
            this.cmbVrstaPosla = new System.Windows.Forms.ComboBox();
            this.cmbNazivOpcine = new System.Windows.Forms.ComboBox();
            this.dtpDatumNarudzbe = new System.Windows.Forms.DateTimePicker();
            this.tbOIB = new System.Windows.Forms.TextBox();
            this.tbCijena = new System.Windows.Forms.TextBox();
            this.tbNapomena = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlijent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesticeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBROpcineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaPoslaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pretraga osobe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "OIB";
            // 
            // postgresDataSet
            // 
            this.postgresDataSet.DataSetName = "postgresDataSet";
            this.postgresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataMember = "Klijent";
            this.klijentBindingSource.DataSource = this.postgresDataSet;
            // 
            // klijentTableAdapter
            // 
            this.klijentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CesticeTableAdapter = null;
            this.tableAdapterManager.KlijentTableAdapter = this.klijentTableAdapter;
            this.tableAdapterManager.MBROpcineTableAdapter = null;
            this.tableAdapterManager.PosaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Geoizmjera_PI.postgresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VrstaPoslaTableAdapter = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pretraži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewKlijent
            // 
            this.dataGridViewKlijent.AutoGenerateColumns = false;
            this.dataGridViewKlijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKlijent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oIBDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.brojTelefonaDataGridViewTextBoxColumn,
            this.brojMobitelaDataGridViewTextBoxColumn});
            this.dataGridViewKlijent.DataSource = this.klijentBindingSource1;
            this.dataGridViewKlijent.Location = new System.Drawing.Point(15, 119);
            this.dataGridViewKlijent.Name = "dataGridViewKlijent";
            this.dataGridViewKlijent.RowTemplate.Height = 24;
            this.dataGridViewKlijent.Size = new System.Drawing.Size(644, 75);
            this.dataGridViewKlijent.TabIndex = 6;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // brojTelefonaDataGridViewTextBoxColumn
            // 
            this.brojTelefonaDataGridViewTextBoxColumn.DataPropertyName = "BrojTelefona";
            this.brojTelefonaDataGridViewTextBoxColumn.HeaderText = "BrojTelefona";
            this.brojTelefonaDataGridViewTextBoxColumn.Name = "brojTelefonaDataGridViewTextBoxColumn";
            // 
            // brojMobitelaDataGridViewTextBoxColumn
            // 
            this.brojMobitelaDataGridViewTextBoxColumn.DataPropertyName = "BrojMobitela";
            this.brojMobitelaDataGridViewTextBoxColumn.HeaderText = "BrojMobitela";
            this.brojMobitelaDataGridViewTextBoxColumn.Name = "brojMobitelaDataGridViewTextBoxColumn";
            // 
            // klijentBindingSource1
            // 
            this.klijentBindingSource1.DataMember = "Klijent";
            this.klijentBindingSource1.DataSource = this.postgresDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Osoba nije pronađena, unesite novu osobu ovdje -->";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Unos osobe";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // posaoBindingSource
            // 
            this.posaoBindingSource.DataMember = "Posao";
            this.posaoBindingSource.DataSource = this.postgresDataSet;
            // 
            // posaoTableAdapter
            // 
            this.posaoTableAdapter.ClearBeforeFill = true;
            // 
            // cesticeBindingSource
            // 
            this.cesticeBindingSource.DataMember = "Cestice_IDPosla_fkey";
            this.cesticeBindingSource.DataSource = this.posaoBindingSource;
            // 
            // cesticeTableAdapter
            // 
            this.cesticeTableAdapter.ClearBeforeFill = true;
            // 
            // mBROpcineBindingSource
            // 
            this.mBROpcineBindingSource.DataMember = "MBROpcine";
            this.mBROpcineBindingSource.DataSource = this.postgresDataSet1;
            // 
            // postgresDataSet1
            // 
            this.postgresDataSet1.DataSetName = "postgresDataSet";
            this.postgresDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mBROpcineTableAdapter
            // 
            this.mBROpcineTableAdapter.ClearBeforeFill = true;
            // 
            // vrstaPoslaBindingSource
            // 
            this.vrstaPoslaBindingSource.DataMember = "VrstaPosla";
            this.vrstaPoslaBindingSource.DataSource = this.postgresDataSet1;
            // 
            // vrstaPoslaTableAdapter
            // 
            this.vrstaPoslaTableAdapter.ClearBeforeFill = true;
            // 
            // lblDatumTerena
            // 
            this.lblDatumTerena.AutoSize = true;
            this.lblDatumTerena.Location = new System.Drawing.Point(12, 257);
            this.lblDatumTerena.Name = "lblDatumTerena";
            this.lblDatumTerena.Size = new System.Drawing.Size(94, 17);
            this.lblDatumTerena.TabIndex = 9;
            this.lblDatumTerena.Text = "Datum terena";
            // 
            // lblVrijemeTerena
            // 
            this.lblVrijemeTerena.AutoSize = true;
            this.lblVrijemeTerena.Location = new System.Drawing.Point(12, 294);
            this.lblVrijemeTerena.Name = "lblVrijemeTerena";
            this.lblVrijemeTerena.Size = new System.Drawing.Size(100, 17);
            this.lblVrijemeTerena.TabIndex = 10;
            this.lblVrijemeTerena.Text = "Vrijeme terena";
            // 
            // lblVrstaPosla
            // 
            this.lblVrstaPosla.AutoSize = true;
            this.lblVrstaPosla.Location = new System.Drawing.Point(12, 331);
            this.lblVrstaPosla.Name = "lblVrstaPosla";
            this.lblVrstaPosla.Size = new System.Drawing.Size(79, 17);
            this.lblVrstaPosla.TabIndex = 11;
            this.lblVrstaPosla.Text = "Vrsta posla";
            // 
            // lblNazivOpcine
            // 
            this.lblNazivOpcine.AutoSize = true;
            this.lblNazivOpcine.Location = new System.Drawing.Point(12, 373);
            this.lblNazivOpcine.Name = "lblNazivOpcine";
            this.lblNazivOpcine.Size = new System.Drawing.Size(89, 17);
            this.lblNazivOpcine.TabIndex = 12;
            this.lblNazivOpcine.Text = "Naziv općine";
            // 
            // lblDatumNarudzbe
            // 
            this.lblDatumNarudzbe.AutoSize = true;
            this.lblDatumNarudzbe.Location = new System.Drawing.Point(388, 257);
            this.lblDatumNarudzbe.Name = "lblDatumNarudzbe";
            this.lblDatumNarudzbe.Size = new System.Drawing.Size(113, 17);
            this.lblDatumNarudzbe.TabIndex = 13;
            this.lblDatumNarudzbe.Text = "Datum narudžbe";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(388, 331);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(47, 17);
            this.lblCijena.TabIndex = 14;
            this.lblCijena.Text = "Cijena";
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Location = new System.Drawing.Point(388, 294);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(31, 17);
            this.lblOIB.TabIndex = 15;
            this.lblOIB.Text = "OIB";
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(388, 373);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(77, 17);
            this.lblNapomena.TabIndex = 16;
            this.lblNapomena.Text = "Napomena";
            // 
            // cmbVrijeme1
            // 
            this.cmbVrijeme1.FormattingEnabled = true;
            this.cmbVrijeme1.Location = new System.Drawing.Point(141, 291);
            this.cmbVrijeme1.Name = "cmbVrijeme1";
            this.cmbVrijeme1.Size = new System.Drawing.Size(85, 24);
            this.cmbVrijeme1.TabIndex = 17;
            // 
            // cmbVrijeme2
            // 
            this.cmbVrijeme2.FormattingEnabled = true;
            this.cmbVrijeme2.Location = new System.Drawing.Point(258, 291);
            this.cmbVrijeme2.Name = "cmbVrijeme2";
            this.cmbVrijeme2.Size = new System.Drawing.Size(83, 24);
            this.cmbVrijeme2.TabIndex = 18;
            // 
            // dtpDatumTerena
            // 
            this.dtpDatumTerena.Location = new System.Drawing.Point(141, 257);
            this.dtpDatumTerena.Name = "dtpDatumTerena";
            this.dtpDatumTerena.Size = new System.Drawing.Size(200, 22);
            this.dtpDatumTerena.TabIndex = 19;
            // 
            // cmbVrstaPosla
            // 
            this.cmbVrstaPosla.DataSource = this.vrstaPoslaBindingSource;
            this.cmbVrstaPosla.DisplayMember = "Naziv";
            this.cmbVrstaPosla.FormattingEnabled = true;
            this.cmbVrstaPosla.Location = new System.Drawing.Point(140, 331);
            this.cmbVrstaPosla.Name = "cmbVrstaPosla";
            this.cmbVrstaPosla.Size = new System.Drawing.Size(201, 24);
            this.cmbVrstaPosla.TabIndex = 20;
            this.cmbVrstaPosla.ValueMember = "IDVrstaPosla";
            // 
            // cmbNazivOpcine
            // 
            this.cmbNazivOpcine.DataSource = this.mBROpcineBindingSource;
            this.cmbNazivOpcine.DisplayMember = "ImeOpcine";
            this.cmbNazivOpcine.FormattingEnabled = true;
            this.cmbNazivOpcine.Location = new System.Drawing.Point(140, 373);
            this.cmbNazivOpcine.Name = "cmbNazivOpcine";
            this.cmbNazivOpcine.Size = new System.Drawing.Size(201, 24);
            this.cmbNazivOpcine.TabIndex = 21;
            this.cmbNazivOpcine.ValueMember = "IDMBROpcine";
            // 
            // dtpDatumNarudzbe
            // 
            this.dtpDatumNarudzbe.Location = new System.Drawing.Point(523, 257);
            this.dtpDatumNarudzbe.Name = "dtpDatumNarudzbe";
            this.dtpDatumNarudzbe.Size = new System.Drawing.Size(200, 22);
            this.dtpDatumNarudzbe.TabIndex = 22;
            // 
            // tbOIB
            // 
            this.tbOIB.Location = new System.Drawing.Point(523, 293);
            this.tbOIB.Name = "tbOIB";
            this.tbOIB.Size = new System.Drawing.Size(200, 22);
            this.tbOIB.TabIndex = 23;
            // 
            // tbCijena
            // 
            this.tbCijena.Location = new System.Drawing.Point(523, 333);
            this.tbCijena.Name = "tbCijena";
            this.tbCijena.Size = new System.Drawing.Size(200, 22);
            this.tbCijena.TabIndex = 24;
            // 
            // tbNapomena
            // 
            this.tbNapomena.Location = new System.Drawing.Point(523, 373);
            this.tbNapomena.Multiline = true;
            this.tbNapomena.Name = "tbNapomena";
            this.tbNapomena.Size = new System.Drawing.Size(200, 59);
            this.tbNapomena.TabIndex = 25;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(894, 331);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(203, 74);
            this.btnSpremi.TabIndex = 26;
            this.btnSpremi.Text = "Spremi posao";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // unos_poslova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 499);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.tbNapomena);
            this.Controls.Add(this.tbCijena);
            this.Controls.Add(this.tbOIB);
            this.Controls.Add(this.dtpDatumNarudzbe);
            this.Controls.Add(this.cmbNazivOpcine);
            this.Controls.Add(this.cmbVrstaPosla);
            this.Controls.Add(this.dtpDatumTerena);
            this.Controls.Add(this.cmbVrijeme2);
            this.Controls.Add(this.cmbVrijeme1);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.lblOIB);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblDatumNarudzbe);
            this.Controls.Add(this.lblNazivOpcine);
            this.Controls.Add(this.lblVrstaPosla);
            this.Controls.Add(this.lblVrijemeTerena);
            this.Controls.Add(this.lblDatumTerena);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewKlijent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "unos_poslova";
            this.Text = "Unos poslova";
            this.Load += new System.EventHandler(this.unos_poslova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlijent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesticeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBROpcineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaPoslaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private postgresDataSet postgresDataSet;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private postgresDataSetTableAdapters.KlijentTableAdapter klijentTableAdapter;
        private postgresDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewKlijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojTelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojMobitelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource klijentBindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource posaoBindingSource;
        private postgresDataSetTableAdapters.PosaoTableAdapter posaoTableAdapter;
        private System.Windows.Forms.BindingSource cesticeBindingSource;
        private postgresDataSetTableAdapters.CesticeTableAdapter cesticeTableAdapter;
        private postgresDataSet postgresDataSet1;
        private System.Windows.Forms.BindingSource mBROpcineBindingSource;
        private postgresDataSetTableAdapters.MBROpcineTableAdapter mBROpcineTableAdapter;
        private System.Windows.Forms.BindingSource vrstaPoslaBindingSource;
        private postgresDataSetTableAdapters.VrstaPoslaTableAdapter vrstaPoslaTableAdapter;
        private System.Windows.Forms.Label lblDatumTerena;
        private System.Windows.Forms.Label lblVrijemeTerena;
        private System.Windows.Forms.Label lblVrstaPosla;
        private System.Windows.Forms.Label lblNazivOpcine;
        private System.Windows.Forms.Label lblDatumNarudzbe;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.ComboBox cmbVrijeme1;
        private System.Windows.Forms.ComboBox cmbVrijeme2;
        private System.Windows.Forms.DateTimePicker dtpDatumTerena;
        private System.Windows.Forms.ComboBox cmbVrstaPosla;
        private System.Windows.Forms.ComboBox cmbNazivOpcine;
        private System.Windows.Forms.DateTimePicker dtpDatumNarudzbe;
        private System.Windows.Forms.TextBox tbOIB;
        private System.Windows.Forms.TextBox tbCijena;
        private System.Windows.Forms.TextBox tbNapomena;
        private System.Windows.Forms.Button btnSpremi;
    }
}