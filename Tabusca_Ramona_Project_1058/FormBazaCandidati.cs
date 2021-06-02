using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Tabusca_Ramona_Project_1058
{
    public partial class FormBazaCandidati : Form
    {
        public FormBazaCandidati()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_ProjectDataSet.Candidati' table. You can move, or remove it, as needed.
            try
            {
                this.candidatiTableAdapter.Fill(this.dB_ProjectDataSet.Candidati);
            }
            catch (Exception ex) { }
            
        }

        private void buttonIesi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable GetDataTableFromGVC(DataGridView dgvc)
        {
            var dt = new DataTable();
            foreach(DataGridViewColumn column in dgvc.Columns)
            {
                if(column.Visible)
                {
                    dt.Columns.Add();
                }
            }
            object[] cellValues = new object[dgvc.Columns.Count];
            foreach(DataGridViewRow row in dgvc.Rows)
            {
                for(int i=0;i<row.Cells.Count;i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            return dt;
        }

        private void salveazaXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = GetDataTableFromGVC(dataGridViewCandidati);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXml(File.OpenWrite(@"c:\\temp\\fisier.xml"));
            MessageBox.Show("Fisier generat cu succes!");
        }

    }
}
