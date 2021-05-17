using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class FormSelectareFacultati : Form
    {
        Candidat candidat;
        public FormSelectareFacultati(Candidat c)
        {
            InitializeComponent();
            this.candidat=c;
        }

        public void metodaMeaOptiuni()
        {
            string optiune1 = cbOptiune1.Text;
            string optiune2 = cbOptiune2.Text;
            string optiune3 = cbOptiune3.Text;
            
            candidat[0] = optiune1;
            candidat[1] = optiune2;
            candidat[2] = optiune3;
            MessageBox.Show(candidat.ToString());
            /*  try
              {
                  string optiune1=cbOptiune1.Text;
                  string optiune2= cbOptiune2.Text; 
                  string optiune3= cbOptiune3.Text;
                  candidat[0] = optiune1;
                  candidat[1] = optiune2;
                  candidat[2] = optiune3;
                  MessageBox.Show(candidat.ToString());
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }
              finally
              {
                  cbOptiune1.Text = "";
                  cbOptiune2.Text = "";
                  cbOptiune3.Text = "";
              }*/
        }
        private void btnFinalizeazaInscrierea_Click(object sender, EventArgs e)
        {
            metodaMeaOptiuni();
            FormMeniuPrincipal form = new FormMeniuPrincipal();
            form.Show();
            this.Hide();
        }
    }
}
