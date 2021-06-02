using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabusca_Ramona_Project_1058
{
    public partial class FormBazaFacultati : Form
    {
        public FormBazaFacultati()
        {
            InitializeComponent();
        }

        private void FormBazaFacultati_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_ProjectDataSet2.Facultati' table. You can move, or remove it, as needed.
            this.facultatiTableAdapter1.Fill(this.dB_ProjectDataSet2.Facultati);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
