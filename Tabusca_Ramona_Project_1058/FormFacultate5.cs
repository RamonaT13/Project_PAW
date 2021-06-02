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
    public partial class FormFacultate5 : Form
    {
        private Facultate d1 = new Facultate("Științe ale educației", "Pedagogia învățământului primar şi preșcolar", 8.25, 6.49, 60, 3);
        private Facultate d2 = new Facultate("Științe ale educației", "Pedagogia învățământului primar şi preșcolar(la Slatina)", 7.22, 6.5, 60, 3);
        private Facultate d3 = new Facultate("Asistență socială", "Asistență socială", 9.21, 7.86, 75, 3);
        private Facultate d4 = new Facultate("Psihologie", "Psihologie", 8.49, 7.72, 100, 3);
        private Facultate d5 = new Facultate("Științe ale comunicării", "Jurnalism", 8.4, 6.84, 40, 3);
        private Facultate d6 = new Facultate("Sociologie", "Resurse umane", 8.11, 6.99, 50, 3);
        public FormFacultate5()
        {
            InitializeComponent();
            treeViewFac5.Nodes.Add(new TreeNode("Departamentul: " + this.d1.NumeDepartament));
            treeViewFac5.Nodes[0].Nodes.Add(new TreeNode("Specializarea: " + this.d1.Specializare));
            treeViewFac5.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.d1.NumarlocuriTotal.ToString()));
            treeViewFac5.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.d1.AniStudiu.ToString()));
            treeViewFac5.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.d1.MedieMinBuget.ToString()));
            treeViewFac5.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.d1.MedieMinTaxa.ToString()));
            treeViewFac5.Nodes[0].Nodes.Add(new TreeNode("Specializarea: " + this.d2.Specializare));
            treeViewFac5.Nodes[0].Nodes[1].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.d2.NumarlocuriTotal.ToString()));
            treeViewFac5.Nodes[0].Nodes[1].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.d2.AniStudiu.ToString()));
            treeViewFac5.Nodes[0].Nodes[1].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.d2.MedieMinBuget.ToString()));
            treeViewFac5.Nodes[0].Nodes[1].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.d2.MedieMinTaxa.ToString()));

            treeViewFac5.Nodes.Add(new TreeNode("Departamentul: " + this.d3.NumeDepartament));
            treeViewFac5.Nodes[1].Nodes.Add(new TreeNode("Specializarea: " + this.d3.Specializare));
            treeViewFac5.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.d3.NumarlocuriTotal.ToString()));
            treeViewFac5.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.d3.AniStudiu.ToString()));
            treeViewFac5.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.d3.MedieMinBuget.ToString()));
            treeViewFac5.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.d3.MedieMinTaxa.ToString()));

            treeViewFac5.Nodes.Add(new TreeNode("Departamentul: " + this.d4.NumeDepartament));
            treeViewFac5.Nodes[2].Nodes.Add(new TreeNode("Specializarea: " + this.d4.Specializare));
            treeViewFac5.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.d4.NumarlocuriTotal.ToString()));
            treeViewFac5.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.d4.AniStudiu.ToString()));
            treeViewFac5.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.d4.MedieMinBuget.ToString()));
            treeViewFac5.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.d4.MedieMinTaxa.ToString()));

            treeViewFac5.Nodes.Add(new TreeNode("Departamentul: " + this.d5.NumeDepartament));
            treeViewFac5.Nodes[3].Nodes.Add(new TreeNode("Specializarea: " + this.d5.Specializare));
            treeViewFac5.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.d5.NumarlocuriTotal.ToString()));
            treeViewFac5.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.d5.AniStudiu.ToString()));
            treeViewFac5.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.d5.MedieMinBuget.ToString()));
            treeViewFac5.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.d5.MedieMinTaxa.ToString()));

            treeViewFac5.Nodes.Add(new TreeNode("Departamentul: " + this.d6.NumeDepartament));
            treeViewFac5.Nodes[4].Nodes.Add(new TreeNode("Specializarea: " + this.d6.Specializare));
            treeViewFac5.Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.d6.NumarlocuriTotal.ToString()));
            treeViewFac5.Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.d6.AniStudiu.ToString()));
            treeViewFac5.Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.d6.MedieMinBuget.ToString()));
            treeViewFac5.Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.d6.MedieMinTaxa.ToString()));
        }

        private void buttonInchidere5_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormUniversitate().Show();
        }
    }
}
