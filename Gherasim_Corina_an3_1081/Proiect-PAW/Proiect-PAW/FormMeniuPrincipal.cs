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
    public partial class FormMeniuPrincipal : Form
    {
        public FormMeniuPrincipal()
        {
            InitializeComponent();
        }

        private void btnInscriere_Click(object sender, EventArgs e)
        {
            FormDateCandidat frm = new FormDateCandidat();
            frm.Show();
            this.Hide();
        }

        private void btnCandidatiInscrisi_Click(object sender, EventArgs e)
        {
            FormCandidatiInscrisi frmCandidati = new FormCandidatiInscrisi();
            frmCandidati.Show();
            this.Hide();
        }

        private void btnPrezentareFacultati_Click(object sender, EventArgs e)
        {
            FormPrezentareFacultati frmPrezentare = new FormPrezentareFacultati();
            frmPrezentare.Show();
            this.Hide();
        }
    }
}
