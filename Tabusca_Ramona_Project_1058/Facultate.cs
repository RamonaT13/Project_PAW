using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabusca_Ramona_Project_1058
{
        [Serializable]
        public class Facultate
        {
        private int idFacultate;
        private string numeFacultate;
            private string numeDepartament;
            private string specializare;
            private double medieMinBuget;
            private double medieMinTaxa;
            private int numarlocuriTotal;
            private int aniStudiu;

            public Facultate()
            {
                this.idFacultate = 0;
                this.numeDepartament = " ";
                this.specializare = " ";
                this.medieMinBuget = 0.0;
                this.medieMinTaxa = 0.0;
                this.numarlocuriTotal = 0;
                this.aniStudiu = 0;
            }

            public Facultate(string _numeDepartament, string _specializare, double _medieMinBuget, double _medieMinTaxa, int _numarlocuriTotal, int _aniStudiu)
            {
                this.numeDepartament = _numeDepartament;
                this.specializare = _specializare;
                this.medieMinBuget = _medieMinBuget;
                this.medieMinTaxa = _medieMinTaxa;
                this.numarlocuriTotal = _numarlocuriTotal;
                this.aniStudiu = _aniStudiu;
            }

        public int IdFacultate
        {
            get =>
                this.idFacultate;
            set =>
                this.idFacultate = value;
        }
        public string NumeFacultate
        {
            get =>
                this.numeFacultate;
            set =>
                this.numeFacultate = value;
        }

        public string NumeDepartament
            {
                get =>
                    this.numeDepartament;
                set =>
                    this.numeDepartament = value;
            }

            public string Specializare
            {
                get =>
                    this.specializare;
                set =>
                    this.specializare = value;
            }

            public double MedieMinBuget
            {
                get =>
                    this.medieMinBuget;
                set =>
                    this.medieMinBuget = value;
            }

            public double MedieMinTaxa
            {
                get =>
                    this.medieMinTaxa;
                set =>
                    this.medieMinTaxa = value;
            }

            public int NumarlocuriTotal
            {
                get =>
                    this.numarlocuriTotal;
                set =>
                    this.numarlocuriTotal = value;
            }

            public int AniStudiu
            {
                get =>
                    this.aniStudiu;
                set =>
                    this.aniStudiu = value;
            }
        }
 }

