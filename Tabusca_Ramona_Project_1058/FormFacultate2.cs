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
    public partial class FormFacultate2 : Form
    {
        private Facultate a1 = new Facultate("Ingineria autovehiculelor", "Autovehciule rutiere", 7.45, 6.11, 90, 4);
        private Facultate a2 = new Facultate("Ingineria transporturilor", " Ingineria transporturilor şi a traficului", 7.55, 6.1, 60, 4);
        private Facultate a3 = new Facultate("Inginerie industrială", "Tehnologia construcțiilor de mașini ", 8.01, 6.33, 75, 4);
        private Facultate a4 = new Facultate("Inginerie și management", "Inginerie economică industrială", 7.86, 6.24, 75, 4);
        public FormFacultate2()
        {
            InitializeComponent();
            treeViewFac2.Nodes.Add(new TreeNode("Departamentul: " + this.a1.NumeDepartament));
            treeViewFac2.Nodes[0].Nodes.Add(new TreeNode("Specializarea: " + this.a1.Specializare));
            treeViewFac2.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.a1.NumarlocuriTotal.ToString()));
            treeViewFac2.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.a1.AniStudiu.ToString()));
            treeViewFac2.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.a1.MedieMinBuget.ToString()));

            treeViewFac2.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.a1.MedieMinTaxa.ToString()));
            treeViewFac2.Nodes.Add(new TreeNode("Departamentul: " + this.a2.NumeDepartament));
            treeViewFac2.Nodes[1].Nodes.Add(new TreeNode("Specializarea: " + this.a2.Specializare));
            treeViewFac2.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.a2.NumarlocuriTotal.ToString()));
            treeViewFac2.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.a2.AniStudiu.ToString()));
            treeViewFac2.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.a2.MedieMinBuget.ToString()));
            treeViewFac2.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.a2.MedieMinTaxa.ToString()));

            treeViewFac2.Nodes.Add(new TreeNode("Departamentul: " + this.a3.NumeDepartament));
            treeViewFac2.Nodes[2].Nodes.Add(new TreeNode("Specializarea: " + this.a3.Specializare));
            treeViewFac2.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.a3.NumarlocuriTotal.ToString()));
            treeViewFac2.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.a3.AniStudiu.ToString()));
            treeViewFac2.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.a3.MedieMinBuget.ToString()));
            treeViewFac2.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.a3.MedieMinTaxa.ToString()));

            treeViewFac2.Nodes.Add(new TreeNode("Departamentul: " + this.a4.NumeDepartament));
            treeViewFac2.Nodes[3].Nodes.Add(new TreeNode("Specializarea: " + this.a4.Specializare));
            treeViewFac2.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.a4.NumarlocuriTotal.ToString()));
            treeViewFac2.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.a4.AniStudiu.ToString()));
            treeViewFac2.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.a4.MedieMinBuget.ToString()));
            treeViewFac2.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.a4.MedieMinTaxa.ToString()));
        }

        private void buttonInchidere2_Click(object sender, EventArgs e)
        {
            base.Close();
            new FormUniversitate().Show();
        }
    }
}
