using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samostalna_vježba_4_labosa
{
    public partial class izrSvojstavaKruga : Form
    {
        public izrSvojstavaKruga()
        {
            InitializeComponent();
        }

        private void btnIzračunaj_Click(object sender, EventArgs e)
        {
            
            float polumjer = 0, opseg = 0, površina = 0;

            float.TryParse(txtPolumjer.Text, out polumjer);

            if (polumjer < 0)
            {
                polumjer = 0;
              
            }
            površina = polumjer * polumjer * (float)Math.PI;
            opseg = 2 * polumjer * (float)Math.PI;

            txtPolumjer.Text = polumjer.ToString();
            txtOpseg.Text = Math.Round(opseg, 2).ToString();
            txtPovršina.Text = Math.Round(površina, 2).ToString();

            if (checkDodajUListu.Checked == true)
            {
                listLista.Text = listLista.Items.Add(polumjer).ToString();
            }

        }

        private void btnOčisti_Click(object sender, EventArgs e)
        {
            txtOpseg.Text = "0,00".ToString();
            txtPolumjer.Text = "0,00".ToString();
            txtPovršina.Text = "0,00".ToString();

            listLista.Items.Clear();


        }

        private void listLista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            float polumjer = 0;
            //dohvaćanje vrijednosti iz list boxa i stavljanje u varijablu
            float.TryParse(listLista.SelectedItem.ToString(), out polumjer);
            //postavljanje vrijdenosti text boxa u varijablu
            txtPolumjer.Text = polumjer.ToString();
            btnIzračunaj_Click(null, null);

        }

      
    }
}
