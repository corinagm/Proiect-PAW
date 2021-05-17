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
    public partial class FormDateCandidat : Form
    {
        Candidat candidat = new Candidat();

        public FormDateCandidat()
        {
            InitializeComponent();
        }

        private void metodaMea()
        {
            try
            {
                string nume=tbNume.Text;
                string CNP=tbCNP.Text;
                int varsta=Convert.ToInt32(tbVarsta.Text);
                string email=tbEmail.Text;
                char sex=Convert.ToChar(cbSex.Text);
                candidat.Nume = nume;
                candidat.CNP1 = CNP;
                candidat.Varsta = varsta;
                candidat.Email = email;
                candidat.Sex = sex;

                MessageBox.Show(candidat.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbNume.Clear();
                tbCNP.Clear();
                tbVarsta.Text = "";
                tbEmail.Clear();
                cbSex.Text = "";

            }
        }

        private void btnEtapaUrmatoare_Click(object sender, EventArgs e)
        {
            metodaMea();
            FormMediiBacalaureat form = new FormMediiBacalaureat(candidat);
            form.Show();
            this.Hide();
        }

        private void FormDateCandidat_Load(object sender, EventArgs e)
        {

        }
    }
}
