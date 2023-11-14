using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EU2
{
    internal class Adatok
    {
        public string Orszag { get; set; }
        public string Fovaros{ get; set; }
        public string Csatlakozas { get; set; }
        public int Szavazat { get; set; }
        public double Valtas { get; set; }
        public string  Penznem{ get; set; }

        public Adatok(string r)
        {
            string []v=r.Split(";");
            Orszag = v[0];
            Fovaros = v[1];
            Csatlakozas = v[2];
            Szavazat=int.Parse(v[3]);
            Valtas = double.Parse(v[4]);
            Penznem = v[5]; 
        }
        public override string ToString()
        {
            return $"Orszag:{Orszag}, Foőváros:{Fovaros},Csatlakozás:{Csatlakozas},Szavazat:{Szavazat},Váltás:{Valtas},Pénznem";

        }
    }
    
 
}
