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
    public partial class FormFacultate3 : Form
    {
        Facultate b1 = new Facultate("Calculatoare și tehnologia informației", "Calculatoare", 9.3, 8.32, 100, 4);
        Facultate b2 = new Facultate("Inginerie electrică", "Electromecanică", 8.9, 7.86, 90, 4);
        Facultate b3 = new Facultate("Inginerie electrică", "Inginerie electrică și calculatoare (la Râmnicu Vâlcea)", 8.07, 7.21, 60, 4);
        Facultate b4 = new Facultate("Inginerie electronică, telecomunicații și tehnologii informaționale", "Electronică aplicată", 8.02, 7.2, 60, 4);
        Facultate b5 = new Facultate("Inginerie electronică, telecomunicații și tehnologii informaționale", "Rețele şi software de telecomunicații", 8.44, 7.03, 45, 4);
        public FormFacultate3()
        {
            InitializeComponent();
            treeViewFac3.Nodes.Add(new TreeNode("Departamentul: " + b1.NumeDepartament));
            treeViewFac3.Nodes[0].Nodes.Add(new TreeNode("Specializarea: " + b1.Specializare));
            treeViewFac3.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + b1.NumarlocuriTotal.ToString()));
            treeViewFac3.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + b1.AniStudiu.ToString()));
            treeViewFac3.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + b1.MedieMinBuget.ToString()));
            treeViewFac3.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + b1.MedieMinTaxa.ToString()));

            treeViewFac3.Nodes.Add(new TreeNode("Departamentul: " + b2.NumeDepartament));
            treeViewFac3.Nodes[1].Nodes.Add(new TreeNode("Specializarea: " + b2.Specializare));
            treeViewFac3.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + b2.NumarlocuriTotal.ToString()));
            treeViewFac3.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + b2.AniStudiu.ToString()));
            treeViewFac3.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + b2.MedieMinBuget.ToString()));
            treeViewFac3.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + b2.MedieMinTaxa.ToString()));
            treeViewFac3.Nodes[1].Nodes.Add(new TreeNode("Specializarea: " + b3.Specializare));
            treeViewFac3.Nodes[1].Nodes[1].Nodes.Add(new TreeNode("Numar de locuri totale: " + b3.NumarlocuriTotal.ToString()));
            treeViewFac3.Nodes[1].Nodes[1].Nodes.Add(new TreeNode("Numar ani de studiu: " + b3.AniStudiu.ToString()));
            treeViewFac3.Nodes[1].Nodes[1].Nodes.Add(new TreeNode("Media minima buget (2020): " + b3.MedieMinBuget.ToString()));
            treeViewFac3.Nodes[1].Nodes[1].Nodes.Add(new TreeNode("Media minima taxa (2020): " + b3.MedieMinTaxa.ToString()));

            treeViewFac3.Nodes.Add(new TreeNode("Departamentul: " + b4.NumeDepartament));
            treeViewFac3.Nodes[2].Nodes.Add(new TreeNode("Specializarea: " + b4.Specializare));
            treeViewFac3.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Numar de locuri totale: " + b4.NumarlocuriTotal.ToString()));
            treeViewFac3.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Numar ani de studiu: " + b4.AniStudiu.ToString()));
            treeViewFac3.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Media minima buget (2020): " + b4.MedieMinBuget.ToString()));
            treeViewFac3.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Media minima taxa (2020): " + b4.MedieMinTaxa.ToString()));
            treeViewFac3.Nodes[2].Nodes.Add(new TreeNode("Specializarea: " + b5.Specializare));
            treeViewFac3.Nodes[2].Nodes[1].Nodes.Add(new TreeNode("Numar de locuri totale: " + b5.NumarlocuriTotal.ToString()));
            treeViewFac3.Nodes[2].Nodes[1].Nodes.Add(new TreeNode("Numar ani de studiu: " + b5.AniStudiu.ToString()));
            treeViewFac3.Nodes[2].Nodes[1].Nodes.Add(new TreeNode("Media minima buget (2020): " + b5.MedieMinBuget.ToString()));
            treeViewFac3.Nodes[2].Nodes[1].Nodes.Add(new TreeNode("Media minima taxa (2020): " + b5.MedieMinTaxa.ToString()));
        }

        private void buttonInchidere3_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormUniversitate().Show();
        }
    }
}
