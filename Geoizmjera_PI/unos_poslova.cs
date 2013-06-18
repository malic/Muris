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
    public partial class unos_poslova : Form
    {
        public unos_poslova()
        {
            InitializeComponent();
        }

        private void klijentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klijentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);

        }

        private void unos_poslova_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'postgresDataSet1.VrstaPosla' table. You can move, or remove it, as needed.
            this.vrstaPoslaTableAdapter.Fill(this.postgresDataSet1.VrstaPosla);
            // TODO: This line of code loads data into the 'postgresDataSet1.MBROpcine' table. You can move, or remove it, as needed.
            this.mBROpcineTableAdapter.Fill(this.postgresDataSet1.MBROpcine);
            // TODO: This line of code loads data into the 'postgresDataSet.Cestice' table. You can move, or remove it, as needed.
            this.cesticeTableAdapter.Fill(this.postgresDataSet.Cestice);
            // TODO: This line of code loads data into the 'postgresDataSet.Posao' table. You can move, or remove it, as needed.
            this.posaoTableAdapter.Fill(this.postgresDataSet.Posao);

            for (int i = 8; i < 20; i++)
            {
                cmbVrijeme1.Items.Add(i);
            }

            
                cmbVrijeme2.Items.Add(00);
                cmbVrijeme2.Items.Add(15);
                cmbVrijeme2.Items.Add(30);
                cmbVrijeme2.Items.Add(45);
            
        }

        int pom;
        

        private void button1_Click(object sender, EventArgs e)
        {
            long pom2 = long.Parse(textBox1.Text);
            this.klijentTableAdapter.FillByOIB(this.postgresDataSet.Klijent, pom2);
            pom = this.klijentTableAdapter.FillByOIB(this.postgresDataSet.Klijent, pom2);
            if (pom == 1)
            {
                label4.Text = "Osoba pronađena";
                button2.Visible = false;
                

            }
            
           
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string pom = cmbVrijeme1.Text +":"+ cmbVrijeme2.Text +":00";

            int bla = Convert.ToInt32(cmbVrstaPosla.SelectedValue);
            
           

            int bla2 = Convert.ToInt32(cmbNazivOpcine.SelectedValue.ToString());
           

            long bla3 = long.Parse(tbOIB.Text);
          



            this.posaoTableAdapter.InsertQueryPosao(dtpDatumNarudzbe.Value, 
                dtpDatumTerena.Value, Convert.ToDateTime(pom), Convert.ToDecimal(tbCijena.Text), tbNapomena.Text,
               bla, bla3, bla2);

            MessageBox.Show("Posao uspješno uneseni");

            this.Close();
        }

        

        
        
        

    }
}
