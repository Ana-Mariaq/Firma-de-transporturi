using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    internal class Soferi
    {
        public int IdSofer;
        public string Nume;
        public int Experienta;
        public int idSofer
        {
            get { return IdSofer; }
            set { IdSofer = value; }
        }
        public string nume
        {
            get { return Nume; }
            set { Nume = value; }
        }
        public int experienta
        {
            get { return Experienta; }
            set { Experienta = value; }
        }

        public Soferi(int _IdSofer=0, string _Nume=" ", int _Experienta = 0) {
         this.IdSofer = _IdSofer;
         this.Nume = _Nume;
         this.Experienta = _Experienta;
        }
    }
}
