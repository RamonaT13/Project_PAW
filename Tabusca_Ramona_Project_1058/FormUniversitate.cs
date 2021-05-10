using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabusca_Ramona_Project_1058
{
    public partial class FormUniversitate : Form
    {
        public FormUniversitate()
        {
            InitializeComponent();
        }

        private void buttonFacultate1_Click(object sender, EventArgs e)
        {
            base.Hide();
            new FormFacultate1().Show();

        }

        private void buttonFacultate2_Click(object sender, EventArgs e)
        {
            base.Hide();
            new FormFacultate2().Show();

        }

        private void buttonFacultate3_Click(object sender, EventArgs e)
        {
            base.Hide();
            new FormFacultate3().Show();

        }

        private void buttonFacultate4_Click(object sender, EventArgs e)
        {
            base.Hide();
            new FormFacultate4().Show();

        }

        private void buttonFacultate5_Click(object sender, EventArgs e)
        {
            base.Hide();
            new FormFacultate5().Show();

        }

        private void buttonFacultate6_Click(object sender, EventArgs e)
        {
            base.Hide();
            new FormFacultate6().Show();

        }

        private void buttonInscriere_Click(object sender, EventArgs e)
        {
            new InscriereCandidat().Show();

        }
    }
}
