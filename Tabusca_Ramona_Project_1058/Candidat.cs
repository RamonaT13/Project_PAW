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
        public string NumePrenume;
        public double medie;
        public double notaDepartajare;
        public string Cnp;

        public Candidat(string _numePrenume, double _medie, double _notaDepartajare, string _Cnp)
        {
            this.NumePrenume = _numePrenume;
            this.medie = _medie;
            this.notaDepartajare = _notaDepartajare;
            this.Cnp = _Cnp;
        }
    }
}
