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
    public partial class FormFacultate6 : Form
    {
        Facultate e1 = new Facultate("Teologie", "Teologie ortodoxă asistență socială", 7.25, 6.22, 50, 3);
        Facultate e2 = new Facultate("Limbă şi literatură", "Limba şi literatura franceză - Limba şi literatura engleză", 8.25, 6.59, 50, 3);
        Facultate e3 = new Facultate("Limbă şi literatură", "Limba şi literatura română - O limbă şi literatură modernă(franceză, engleză)", 8.22, 7.5, 100, 3);
        Facultate e4 = new Facultate("Limbă şi literatură", "Limba şi literatura engleză - O limbă şi literatură modernă(franceză, spaniolă, germană)", 8.21, 7.86, 75, 3);
        Facultate e5 = new Facultate("Limbi moderne aplicate", "Limbi moderne aplicate", 8.19, 7.72, 50, 3);
        Facultate e6 = new Facultate("Istorie", "Istorie", 8.4, 6.84, 30, 3);
        Facultate e7 = new Facultate("Muzică", "Muzică", 8.11, 6.99, 40, 3);
        Facultate e8 = new Facultate("Arte vizuale", "Artă sacră", 8.11, 6.99, 20, 3);
        Facultate e9 = new Facultate("Teatru și artele spectacolului", "Artele spectacolului (Actorie)", 8.11, 8.0, 10, 3);
        public FormFacultate6()
        {
            InitializeComponent();
            treeViewFac6.Nodes.Add(new TreeNode("Departamentul: " + this.e1.NumeDepartament));
            treeViewFac6.Nodes[0].Nodes.Add(new TreeNode("Specializarea: " + this.e1.Specializare));
            treeViewFac6.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.e1.NumarlocuriTotal.ToString()));
            treeViewFac6.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.e1.AniStudiu.ToString()));
            treeViewFac6.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.e1.MedieMinBuget.ToString()));
            treeViewFac6.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.e1.MedieMinTaxa.ToString()));

            treeViewFac6.Nodes.Add(new TreeNode("Departamentul: " + this.e2.NumeDepartament));
            treeViewFac6.Nodes[1].Nodes.Add(new TreeNode("Specializarea: " + this.e2.Specializare));
            treeViewFac6.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.e2.NumarlocuriTotal.ToString()));
            treeViewFac6.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.e2.AniStudiu.ToString()));
            treeViewFac6.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.e2.MedieMinBuget.ToString()));
            treeViewFac6.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.e2.MedieMinTaxa.ToString()));
            treeViewFac6.Nodes[1].Nodes.Add(new TreeNode("Specializarea: " + this.e3.Specializare));
            treeViewFac6.Nodes[1].Nodes[1].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.e3.NumarlocuriTotal.ToString()));
            treeViewFac6.Nodes[1].Nodes[1].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.e3.AniStudiu.ToString()));
            treeViewFac6.Nodes[1].Nodes[1].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.e3.MedieMinBuget.ToString()));
            treeViewFac6.Nodes[1].Nodes[1].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.e3.MedieMinTaxa.ToString()));
            treeViewFac6.Nodes[1].Nodes.Add(new TreeNode("Specializarea: " + this.e4.Specializare));
            treeViewFac6.Nodes[1].Nodes[2].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.e4.NumarlocuriTotal.ToString()));
            treeViewFac6.Nodes[1].Nodes[2].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.e4.AniStudiu.ToString()));
            treeViewFac6.Nodes[1].Nodes[2].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.e4.MedieMinBuget.ToString()));
            treeViewFac6.Nodes[1].Nodes[2].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.e4.MedieMinTaxa.ToString()));

            treeViewFac6.Nodes.Add(new TreeNode("Departamentul: " + this.e5.NumeDepartament));
            treeViewFac6.Nodes[2].Nodes.Add(new TreeNode("Specializarea: " + this.e5.Specializare));
            treeViewFac6.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.e5.NumarlocuriTotal.ToString()));
            treeViewFac6.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.e5.AniStudiu.ToString()));
            treeViewFac6.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.e5.MedieMinBuget.ToString()));
            treeViewFac6.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.e5.MedieMinTaxa.ToString()));

            treeViewFac6.Nodes.Add(new TreeNode("Departamentul: " + this.e6.NumeDepartament));
            treeViewFac6.Nodes[3].Nodes.Add(new TreeNode("Specializarea: " + this.e6.Specializare));
            treeViewFac6.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.e6.NumarlocuriTotal.ToString()));
            treeViewFac6.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.e6.AniStudiu.ToString()));
            treeViewFac6.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.e6.MedieMinBuget.ToString()));
            treeViewFac6.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.e6.MedieMinTaxa.ToString()));

            treeViewFac6.Nodes.Add(new TreeNode("Departamentul: " + this.e7.NumeDepartament));
            treeViewFac6.Nodes[4].Nodes.Add(new TreeNode("Specializarea: " + this.e7.Specializare));
            treeViewFac6.Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.e7.NumarlocuriTotal.ToString()));
            treeViewFac6.Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.e7.AniStudiu.ToString()));
            treeViewFac6.Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.e7.MedieMinBuget.ToString()));
            treeViewFac6.Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.e7.MedieMinTaxa.ToString()));

            treeViewFac6.Nodes.Add(new TreeNode("Departamentul: " + this.e8.NumeDepartament));
            treeViewFac6.Nodes[5].Nodes.Add(new TreeNode("Specializarea: " + this.e8.Specializare));
            treeViewFac6.Nodes[5].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.e8.NumarlocuriTotal.ToString()));
            treeViewFac6.Nodes[5].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.e8.AniStudiu.ToString()));
            treeViewFac6.Nodes[5].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.e8.MedieMinBuget.ToString()));
            treeViewFac6.Nodes[5].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.e8.MedieMinTaxa.ToString()));

            treeViewFac6.Nodes.Add(new TreeNode("Departamentul: " + this.e9.NumeDepartament));
            treeViewFac6.Nodes[6].Nodes.Add(new TreeNode("Specializarea: " + this.e9.Specializare));
            treeViewFac6.Nodes[6].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + this.e9.NumarlocuriTotal.ToString()));
            treeViewFac6.Nodes[6].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + this.e9.AniStudiu.ToString()));
            treeViewFac6.Nodes[6].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + this.e9.MedieMinBuget.ToString()));
            treeViewFac6.Nodes[6].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + this.e9.MedieMinTaxa.ToString()));
        }

        private void buttonInchidere6_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormUniversitate().Show();
        }
    }
}
