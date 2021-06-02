using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabusca_Ramona_Project_1058
{
    [Serializable]
    public class Candidat
    {
        private int idCandidat;
        public string NumePrenume;
        public double medie;
        public double notaDepartajare;
        public string Cnp;
        private string facultateAleasa, specializareAleasa;

        public Candidat(string _numePrenume, double _medie, double _notaDepartajare, string _Cnp)
        {
            this.NumePrenume = _numePrenume;
            this.medie = _medie;
            this.notaDepartajare = _notaDepartajare;
            this.Cnp = _Cnp;
        }

        public Candidat(int idCandidat, string numePrenume, double medie, double notaDepartajare, string cnp, string facultateAleasa, string specializareAleasa)
        {
            this.idCandidat = idCandidat;
            NumePrenume = numePrenume;
            this.medie = medie;
            this.notaDepartajare = notaDepartajare;
            Cnp = cnp;
            this.facultateAleasa = facultateAleasa;
            this.specializareAleasa = specializareAleasa;
        }

        public int IdCandidat
        {
            get => this.idCandidat;
            set => this.idCandidat = value;
        }
        public string numePrenume
        {
            get => this.NumePrenume;
            set => this.NumePrenume = value;
        }
        public string cnp
        {
            get => this.Cnp;
            set => this.Cnp = value;
        }
        public string FacultateAleasa
        {
            get => this.facultateAleasa;
            set => this.facultateAleasa = value;
        }
        public string SpecializareAleasa
        {
            get => this.specializareAleasa;
            set => this.specializareAleasa = value;
        }
        public double Medie
        {
            get => this.medie;
            set => this.medie = value;
        }
        public double NotaDepartajare
        {
            get => this.notaDepartajare;
            set => this.notaDepartajare = value;
        }

    }
}
