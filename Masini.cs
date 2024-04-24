using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    internal class Masini
    {
        public string NrInmatriculare;
        public string Marca;
        public int Capacitate;

        public string nrInmatriculare
        {
            get { return NrInmatriculare; }
            set { NrInmatriculare = value; }
        }

        public string marca
        {
            get { return Marca; }
            set { Marca = value; }
        }

        public int capacitate
        {
            get { return Capacitate; }
            set { Capacitate = value; }
        }

        public Masini(string _NrInmatriculare = "", string _Marca = "", int _Capacitate = 0) { 
         this.NrInmatriculare=_NrInmatriculare;
         this.Marca = _Marca;
         this.Capacitate=_Capacitate;
        }
    }
}
