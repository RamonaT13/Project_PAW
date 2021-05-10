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
    public partial class FormFacultate1 : Form
    {
        private Facultate f1 = new Facultate("Biologie", "Biologie", 8.3, 6.5, 60, 3);
        private Facultate f2 = new Facultate("Chimie", "Chimie", 8.9, 7.44, 0x19, 3);
        private Facultate f3 = new Facultate("Chimie", "Chimie medicala", 8.07, 6.34, 0x19, 3);
        private Facultate f4 = new Facultate("Educație fizică și sport", "Educație fizică și sportivă", 7.86, 6.01, 0x4b, 3);
        private Facultate f5 = new Facultate("Informatică", "Informatică", 9.21, 7.89, 100, 3);
        private Facultate f6 = new Facultate("Matematică", "Matematică", 9.02, 7.55, 30, 3);
        public FormFacultate1()
        {
            InitializeComponent();
            treeViewFac1.Nodes.Add(new TreeNode("Departamentul: " + this.f1.NumeDepartament));
            treeViewFac1.Nodes[0].Nodes.Add(new TreeNode("Specializarea: " + this.f1.Specializare));
            treeViewFac1.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.f1.NumarlocuriTotal.ToString()));
            treeViewFac1.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.f1.AniStudiu.ToString()));
            treeViewFac1.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.f1.MedieMinBuget.ToString()));
            treeViewFac1.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.f1.MedieMinTaxa.ToString()));

            treeViewFac1.Nodes.Add(new TreeNode("Departamentul: " + this.f2.NumeDepartament));
            treeViewFac1.Nodes[1].Nodes.Add(new TreeNode("Specializarea: " + this.f2.Specializare));
            treeViewFac1.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.f2.NumarlocuriTotal.ToString()));
            treeViewFac1.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.f2.AniStudiu.ToString()));
            treeViewFac1.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.f2.MedieMinBuget.ToString()));
            treeViewFac1.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.f2.MedieMinTaxa.ToString()));
            treeViewFac1.Nodes[1].Nodes.Add(new TreeNode("Specializarea: " + this.f3.Specializare));
            treeViewFac1.Nodes[1].Nodes[1].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.f3.NumarlocuriTotal.ToString()));
            treeViewFac1.Nodes[1].Nodes[1].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.f3.AniStudiu.ToString()));
            treeViewFac1.Nodes[1].Nodes[1].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.f3.MedieMinBuget.ToString()));
            treeViewFac1.Nodes[1].Nodes[1].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.f3.MedieMinTaxa.ToString()));

            treeViewFac1.Nodes.Add(new TreeNode("Departamentul: " + this.f4.NumeDepartament));
            treeViewFac1.Nodes[2].Nodes.Add(new TreeNode("Specializarea: " + this.f4.Specializare));
            treeViewFac1.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.f4.NumarlocuriTotal.ToString()));
            treeViewFac1.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.f4.AniStudiu.ToString()));
            treeViewFac1.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.f4.MedieMinBuget.ToString()));
            treeViewFac1.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.f4.MedieMinTaxa.ToString()));

            treeViewFac1.Nodes.Add(new TreeNode("Departamentul: " + this.f5.NumeDepartament));
            treeViewFac1.Nodes[3].Nodes.Add(new TreeNode("Specializarea: " + this.f5.Specializare));
            treeViewFac1.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.f5.NumarlocuriTotal.ToString()));
            treeViewFac1.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.f5.AniStudiu.ToString()));
            treeViewFac1.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.f5.MedieMinBuget.ToString()));
            treeViewFac1.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.f5.MedieMinTaxa.ToString()));

            treeViewFac1.Nodes.Add(new TreeNode("Departamentul: " + this.f6.NumeDepartament));
            treeViewFac1.Nodes[4].Nodes.Add(new TreeNode("Specializarea: " + this.f6.Specializare));
            treeViewFac1.Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.f6.NumarlocuriTotal.ToString()));
            treeViewFac1.Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.f6.AniStudiu.ToString()));
            treeViewFac1.Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.f6.MedieMinBuget.ToString()));
            treeViewFac1.Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.f6.MedieMinTaxa.ToString()));

        }

        private void buttonInchidere1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormUniversitate().Show();

        }
    }
}
