using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabusca_Ramona_Project_1058
{
    public partial class InscriereCandidat : Form
    {
        DataSet DSCandidati = new DataSet();

        string stringConexiune = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=DB_Project;Integrated Security=True";

        string SelectCommand = "select * from dbo.Candidati";

        public InscriereCandidat()
        {
            InitializeComponent();
            string[] specializari = new string[] {"Administrarea afacerilor","Administrație publică", "Artă sacră","Artele spectacolului (Actorie)","Asistență socială",
            "Autovehciule rutiere","Biologie","Calculatoare","Chimie","Chimie medicala","Contabilitate şi informatică de gestiune","Drept", "Economia comerțului, turismului şi serviciilor",
                "Educatie fizica si sportiva","Electromecanică","Electronică aplicată","Finanțe şi bănci","Informatica","Ingineria transporturilor şi a traficului","Inginerie economică industrială",
                "Inginerie electrică și calculatoare (la Râmnicu Vâlcea)","Istorie","Jurnalism","Limba şi literatura engleză - O limbă şi literatură modernă(franceză, spaniolă, germană)","Limba şi literatura franceză - Limba şi literatura engleză",
                "Limba şi literatura română - O limbă şi literatură modernă(franceză, engleză)","Limbi moderne aplicate","Management","Marketing","Matematica","Muzică","Pedagogia învățământului primar şi preșcolar",
                "Pedagogia învățământului primar şi preșcolar(la Slatina)","Psihologie","Resurse umane","Rețele şi software de telecomunicații","Tehnologia construcțiilor de mașini", "Teologie ortodoxă asistență socială" };
            listBoxSpecializari.Items.AddRange(specializari);
        }

        private void listBoxDrop_DragDrop(object sender, DragEventArgs e)
        {
            if (listBoxDrop.Items.Count < 3)
            {
                listBoxDrop.AllowDrop = true;
                listBoxDrop.Items.Add(e.Data.GetData(DataFormats.Text).ToString());
            }
            else
            {
                listBoxDrop.AllowDrop = false;
                errorProvider3.SetError(listBoxDrop, "Nu se pot alege mai mult de 3 specializari!");
            }
        }

        private void listBoxDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else 
                e.Effect = DragDropEffects.None;
        }

        private void listBoxSpecializari_MouseDown(object sender, MouseEventArgs e)
        {if( listBoxSpecializari.SelectedItems.Count>0)
           listBoxSpecializari.DoDragDrop(listBoxSpecializari.SelectedItems[0], DragDropEffects.Copy);
        }

        private void textBoxCNP_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxCNP, "");
        }

        private void textBoxCNP_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxCNP.Text.Length < 12)
            {
                errorProvider2.SetError(textBoxCNP, "CNP-ul nu este corect!");
                e.Cancel = true;
            }
            foreach (char c in textBoxCNP.Text)
            {
                if (c < '0' || c > '9')
                {
                    errorProvider2.SetError(textBoxCNP, "CNP-ul trebuie sa fie format doar din cifre!");
                    e.Cancel = true;
                }
            }
        }

        private void textBoxNumePrenume_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxNumePrenume, "");
        }

        private void textBoxNumePrenume_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxNumePrenume.Text.Length < 5)
            {
                errorProvider1.SetError(textBoxNumePrenume, "Numele si prenumele nu sunt corecte");
                e.Cancel = true;
            }
        }

        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxFacultate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFacultate.SelectedItem.Equals(""))
            {
                comboBoxSpecializare.Items.Clear();
            }
            else if (comboBoxFacultate.SelectedItem == "Facultatea de Științe, Educație Fizică și Informatică")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Text = "Alege specializarea...";
                string[] items = new string[] { "Alege specializarea...", "Biologie", "Chimie", "Chimie medicala", "Educatie fizica si sportiva", "Informatica", "Matematica" };
                comboBoxSpecializare.Items.AddRange(items);
            }
            else if (comboBoxFacultate.SelectedItem == "Facultatea de Mecanică și Tehnologie")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Text = "Alege specializarea...";
                string[] items = new string[] { "Alege specializarea...", "Autovehciule rutiere", "Ingineria transporturilor şi a traficului", "Tehnologia construcțiilor de mașini", "Inginerie economică industrială" };
                comboBoxSpecializare.Items.AddRange(items);
            }
            else if (this.comboBoxFacultate.SelectedItem == "Facultatea de Electronică, Comunicații şi Calculatoare")
            {
                this.comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Text = "Alege specializarea...";
                string[] items = new string[] { "Alege specializarea...", "Calculatoare", "Electromecanică", "Inginerie electrică și calculatoare (la R\x00e2mnicu V\x00e2lcea)", "Electronică aplicată", "Rețele şi software de telecomunicații" };
                comboBoxSpecializare.Items.AddRange(items);
            }
            else if (this.comboBoxFacultate.SelectedItem == "Facultatea de Științe Economice și Drept")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Text = "Alege specializarea...";
                string[] items = new string[] { "Alege specializarea...",
                 "Administrarea afacerilor",
                 "Economia comerțului, turismului şi serviciilor",
                "Contabilitate şi informatică de gestiune ",
                "Finanțe şi bănci",
                 "Management",
                 "Marketing",
                "Drept",
                "Administrație publică"};
               
                comboBoxSpecializare.Items.AddRange(items);
            }
            else if (comboBoxFacultate.SelectedItem == "Facultatea de Științe ale Educatiei, Științe Sociale şi Psihologie")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Text = "Alege specializarea...";
                string[] items = new string[] { "Alege specializarea...", "Pedagogia \x00eenvățăm\x00e2ntului primar şi preșcolar", "Pedagogia \x00eenvățăm\x00e2ntului primar şi preșcolar(la Slatina)", "Asistență socială", "Psihologie", "Jurnalism", "Resurse umane" };
                comboBoxSpecializare.Items.AddRange(items);
            }
            else if (comboBoxFacultate.SelectedItem == "Facultatea de Teologie, Litere, Istorie și Arte")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Text = "Alege specializarea...";
                string[] items = new string[] {"Alege specializarea...",
                "Teologie ortodoxă asistență socială",
                "Limba şi literatura franceză - Limba şi literatura engleză",
                 "Limba şi literatura rom\x00e2nă - O limbă şi literatură modernă(franceză, engleză)",
                 "Limba şi literatura engleză - O limbă şi literatură modernă(franceză, spaniolă, germană)",
                "Limbi moderne aplicate",
                 "Istorie",
                 "Muzică",
                "Artă sacră",
               "Artele spectacolului (Actorie)" };
                comboBoxSpecializare.Items.AddRange(items);
            }
        }

        private void IncarcaDate()
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter(SelectCommand, conexiune);
            adaptor.Fill(DSCandidati, "Candidati");
            DSCandidati.Tables["Candidati"].PrimaryKey = new DataColumn[1]
                {DSCandidati.Tables["Candidati"].Columns["IdCandidati"]};
            conexiune.Close();

            textBoxNumePrenume.DataBindings.Add("Text", DSCandidati.Tables["Candidati"], "NumePrenume");
            textBoxMedie.DataBindings.Add("Text", DSCandidati.Tables["Candidati"], "Medie");
            textBoxNota.DataBindings.Add("Text", DSCandidati.Tables["Candidati"], "notaDepartajare");
            textBoxCNP.DataBindings.Add("Text", DSCandidati.Tables["Candidati"], "CNP");
        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();
            SqlCommand cmd = new SqlCommand("insert into Candidati (NumePrenume, CNP, Medie, notaDepartajare, facultateAleasa, specializareAleasa) values (@NumePrenume,@Cnp,@Medie,@notaDepartajare,@facultateAleasa,@specializareAleasa)", conexiune);
            cmd.Parameters.Add("@NumePrenume", textBoxNumePrenume.Text);
            cmd.Parameters.Add("@Cnp", textBoxCNP.Text);
            cmd.Parameters.Add("@Medie", textBoxMedie.Text);
            cmd.Parameters.Add("@notaDepartajare", textBoxNota.Text);
            cmd.Parameters.Add("@facultateAleasa", comboBoxFacultate.SelectedItem);
            cmd.Parameters.Add("@specializareAleasa", comboBoxSpecializare.SelectedItem);
            cmd.ExecuteNonQuery();

            FormBazaCandidati f1 = new FormBazaCandidati();
            f1.Show();
            this.Hide();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Numele/prenumele candidatului si media: " + textBoxNumePrenume.Text+" " + textBoxMedie.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(25, 100));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
