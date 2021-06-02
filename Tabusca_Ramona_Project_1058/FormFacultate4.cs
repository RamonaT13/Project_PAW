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
    public partial class FormFacultate4 : Form
    {
        private Facultate c1 = new Facultate("Administrarea afacerilor", "Administrarea afacerilor", 8.45, 6.89, 50, 3);
        private Facultate c2 = new Facultate("Administrarea afacerilor", "Economia comerțului, turismului şi serviciilor", 7.55, 6.1, 60, 3);
        private Facultate c3 = new Facultate("Contabilitate", "Contabilitate şi informatică de gestiune", 8.55, 7.86, 90, 3);
        private Facultate c4 = new Facultate("Finante", "Finanțe şi bănci", 8.23, 7.02, 75, 3);
        private Facultate c5 = new Facultate("Management", "Management", 8.0, 6.54, 60, 3);
        private Facultate c6 = new Facultate("Marketing", "Marketing", 7.99, 6.78, 50, 3);
        private Facultate c7 = new Facultate("Drept", "Drept", 9.01, 8.65, 200, 4);
        private Facultate c8 = new Facultate("Științe administrative ", "Administrație publică", 7.86, 6.24, 75, 3);
        public FormFacultate4()
        {
            InitializeComponent();
            treeViewFac4.Nodes.Add(new TreeNode("Departamentul: " + this.c1.NumeDepartament));
            treeViewFac4.Nodes[0].Nodes.Add(new TreeNode("Specializarea: " + this.c1.Specializare));
            treeViewFac4.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.c1.NumarlocuriTotal.ToString()));
            treeViewFac4.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.c1.AniStudiu.ToString()));
            treeViewFac4.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.c1.MedieMinBuget.ToString()));
            treeViewFac4.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.c1.MedieMinTaxa.ToString()));
            treeViewFac4.Nodes[0].Nodes.Add(new TreeNode("Specializarea: " + this.c2.Specializare));
            treeViewFac4.Nodes[0].Nodes[1].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.c2.NumarlocuriTotal.ToString()));
            treeViewFac4.Nodes[0].Nodes[1].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.c2.AniStudiu.ToString()));
            treeViewFac4.Nodes[0].Nodes[1].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.c2.MedieMinBuget.ToString()));
            treeViewFac4.Nodes[0].Nodes[1].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.c2.MedieMinTaxa.ToString()));

            treeViewFac4.Nodes.Add(new TreeNode("Departamentul: " + this.c3.NumeDepartament));
            treeViewFac4.Nodes[1].Nodes.Add(new TreeNode("Specializarea: " + this.c3.Specializare));
            treeViewFac4.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.c3.NumarlocuriTotal.ToString()));
            treeViewFac4.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.c3.AniStudiu.ToString()));
            treeViewFac4.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.c3.MedieMinBuget.ToString()));
            treeViewFac4.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.c3.MedieMinTaxa.ToString()));

            treeViewFac4.Nodes.Add(new TreeNode("Departamentul: " + this.c4.NumeDepartament));
            treeViewFac4.Nodes[2].Nodes.Add(new TreeNode("Specializarea: " + this.c4.Specializare));
            treeViewFac4.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.c4.NumarlocuriTotal.ToString()));
            treeViewFac4.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.c4.AniStudiu.ToString()));
            treeViewFac4.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.c4.MedieMinBuget.ToString()));
            treeViewFac4.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.c4.MedieMinTaxa.ToString()));

            treeViewFac4.Nodes.Add(new TreeNode("Departamentul: " + this.c5.NumeDepartament));
            treeViewFac4.Nodes[3].Nodes.Add(new TreeNode("Specializarea: " + this.c5.Specializare));
            treeViewFac4.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.c5.NumarlocuriTotal.ToString()));
            treeViewFac4.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.c5.AniStudiu.ToString()));
            treeViewFac4.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.c5.MedieMinBuget.ToString()));
            treeViewFac4.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.c5.MedieMinTaxa.ToString()));

            treeViewFac4.Nodes.Add(new TreeNode("Departamentul: " + this.c6.NumeDepartament));
            treeViewFac4.Nodes[4].Nodes.Add(new TreeNode("Specializarea: " + this.c6.Specializare));
            treeViewFac4.Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.c6.NumarlocuriTotal.ToString()));
            treeViewFac4.Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.c6.AniStudiu.ToString()));
            treeViewFac4.Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.c6.MedieMinBuget.ToString()));
            treeViewFac4.Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.c6.MedieMinTaxa.ToString()));

            treeViewFac4.Nodes.Add(new TreeNode("Departamentul: " + this.c7.NumeDepartament));
            treeViewFac4.Nodes[5].Nodes.Add(new TreeNode("Specializarea: " + this.c7.Specializare));
            treeViewFac4.Nodes[5].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.c7.NumarlocuriTotal.ToString()));
            treeViewFac4.Nodes[5].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.c7.AniStudiu.ToString()));
            treeViewFac4.Nodes[5].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.c7.MedieMinBuget.ToString()));
            treeViewFac4.Nodes[5].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.c7.MedieMinTaxa.ToString()));

            treeViewFac4.Nodes.Add(new TreeNode("Departamentul: " + this.c8.NumeDepartament));
            treeViewFac4.Nodes[6].Nodes.Add(new TreeNode("Specializarea: " + this.c8.Specializare));
            treeViewFac4.Nodes[6].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.c8.NumarlocuriTotal.ToString()));
            treeViewFac4.Nodes[6].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.c8.AniStudiu.ToString()));
            treeViewFac4.Nodes[6].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.c8.MedieMinBuget.ToString()));
            treeViewFac4.Nodes[6].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.c8.MedieMinTaxa.ToString()));
        }

        private void buttonInchidere4_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormUniversitate().Show();
        }
    }
}
