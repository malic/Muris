using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geoizmjera_PI
{
    public partial class grid : Form
    {
        public grid()
        {
            InitializeComponent();
        }

        private void btnPutniNalog_Click(object sender, EventArgs e)
        {
            putni_nalog put_nalog = new putni_nalog();
            put_nalog.ShowDialog();
        }

        

        private void unosNoveOsobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unos_novih_osoba unos_osoba = new unos_novih_osoba();
            unos_osoba.ShowDialog();
        }

        private void posaoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // edit_posla unos_poslova = new edit_posla();
            //unos_poslova.ShowDialog();
        }

        private void rasporedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raspored rasp = new raspored();
            rasp.ShowDialog();
        }

        private void općineIMatičniBrojeviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mbo mbo_izbornik = new mbo();
            mbo_izbornik.ShowDialog();
        }

        private void pretragaPodatakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pretraga_osoba pretraga_osobe = new pretraga_osoba();
            pretraga_osobe.ShowDialog();
        }

        private void izmjenaPodatakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            podaci_o_osobama izmjena_podataka = new podaci_o_osobama();
            izmjena_podataka.ShowDialog();
        }

        private void btnUpisnik_Click(object sender, EventArgs e)
        {
            upisnik upisnik_izbornik = new upisnik();
            upisnik_izbornik.ShowDialog();
        }

        private void grid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'postgresDataSet.MBROpcine' table. You can move, or remove it, as needed.
            this.mBROpcineTableAdapter.Fill(this.postgresDataSet.MBROpcine);
            // TODO: This line of code loads data into the 'postgresDataSet.VrstaPosla' table. You can move, or remove it, as needed.
            this.vrstaPoslaTableAdapter.Fill(this.postgresDataSet.VrstaPosla);

            DateTime datum_danasnji = dateTimePicker1.Value;
           
            // TODO: This line of code loads data into the 'postgresDataSet.Posao' table. You can move, or remove it, as needed.
            this.posaoTableAdapter.FillByDDatum(this.postgresDataSet.Posao, datum_danasnji);

        }
      

        private void dataGridViewPosao_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPosao.RowCount > 0)
            {


              

                long PARAM1 = long.Parse(dataGridViewPosao.CurrentRow.Cells[6].Value.ToString());                
                this.klijentTableAdapter.FillByOIB(this.postgresDataSet.Klijent, PARAM1);

                int PARAM2 = int.Parse(dataGridViewPosao.CurrentRow.Cells[0].Value.ToString());
                this.cesticeTableAdapter.FillByIDPosla(this.postgresDataSet.Cestice, PARAM2);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime datum_odabrani = dateTimePicker1.Value;
            this.posaoTableAdapter.FillByExactDate(this.postgresDataSet.Posao, datum_odabrani);
        }

        private void btnSviTereni_Click(object sender, EventArgs e)
        {
            DateTime datum_danasnji = DateTime.Today;

            // TODO: This line of code loads data into the 'postgresDataSet.Posao' table. You can move, or remove it, as needed.
            this.posaoTableAdapter.FillByDDatum(this.postgresDataSet.Posao, datum_danasnji);
        }

        private void btnObrisiPosao_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridViewPosao.SelectedRows[0];
            var ID_posao = dr.Cells[0].Value.ToString();
            DialogResult rezultat = MessageBox.Show("Za brisanje cijelog posla odaberite \"YES\", za prekid brisanja odaberite \"NO\"? ", "Brisanje posla", MessageBoxButtons.YesNoCancel);
            if (rezultat == DialogResult.Yes)
            {
                int brisi = int.Parse(dataGridViewPosao.CurrentRow.Cells[0].Value.ToString());
                
                this.posaoTableAdapter.DeletePosao(brisi);

                DateTime datum_danasnji = dateTimePicker1.Value;

                // TODO: This line of code loads data into the 'postgresDataSet.Posao' table. You can move, or remove it, as needed.
                this.posaoTableAdapter.FillByDDatum(this.postgresDataSet.Posao, datum_danasnji);
                
                
            }
        }

        private void btnUnosPosla_Click(object sender, EventArgs e)
        {

            unos_poslova unosPoslova = new unos_poslova();
            unosPoslova.ShowDialog();


            
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Jeste li sigurni da zelite izaci iz programa? ", "Izlaz", MessageBoxButtons.YesNo);
            if (rezultat == DialogResult.Yes)
            {
                
                System.Windows.Forms.Application.Exit();
            }
        }


        

        

    }
}
