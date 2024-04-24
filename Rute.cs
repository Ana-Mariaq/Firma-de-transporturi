using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    internal class Rute
    {
        public int IdRuta;
        public string Distanta;
        public string LocPlecare;
        public string LocSosire;
        public int idRuta
        {
            get { return IdRuta; }
            set { IdRuta = value; }
        }

        public string distanta
        {
            get { return Distanta; }
            set { Distanta = value; }
        }

        public string locPlecare
        {
            get { return LocPlecare; }
            set { LocPlecare = value; }
        }

        public string locSosire
        {
            get { return LocSosire; }
            set { LocSosire = value; }
        }
        public Rute(int _IdRuta = 0,string _Distanta = "", string _LocPlecare = "", string _LocSosire = "")
        {
            IdRuta = _IdRuta;
            Distanta = _Distanta;
            LocPlecare = _LocPlecare;
            LocSosire= _LocSosire;
        }

    }
}
