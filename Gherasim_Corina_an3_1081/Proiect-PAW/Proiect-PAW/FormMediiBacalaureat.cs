using Proiect1;
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
    public partial class FormMediiBacalaureat : Form
    {
        Candidat candidat;

        public FormMediiBacalaureat(Candidat candidat)
        {
            InitializeComponent();
            this.candidat = candidat;
        }
        public void calculeazaMedie()
        {
            try {
                float medieAdmitere;
                float nota1 = (float)Convert.ToDouble(tbNotaMaterie1.Text);
                float nota2 = (float)Convert.ToDouble(tbNotaMaterie2.Text); ;
                float nota3 = (float)Convert.ToDouble(tbNotaMaterie3.Text); ;
                float notaLiceu = (float)Convert.ToDouble(tbNotaAniLiceu.Text);

                medieAdmitere = ((nota1 + nota2 + nota3) / 3 * 70 + notaLiceu * 30) / 100;
                candidat.Medie = medieAdmitere;
                MessageBox.Show(candidat.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); }
            finally{
                tbMaterie1.Clear();
                tbNotaMaterie1.Clear();
                tbMaterie2.Clear();
                tbNotaMaterie2.Clear();
                tbMaterie3.Clear();
                tbNotaMaterie3.Clear();
                tbNotaAniLiceu.Clear();
            }
           
        }
        private void btnEtapa3_Click(object sender, EventArgs e)
        {
            calculeazaMedie();
            FormSelectareFacultati form = new FormSelectareFacultati(candidat);
            form.Show();
            this.Hide();
        }
    }
}
