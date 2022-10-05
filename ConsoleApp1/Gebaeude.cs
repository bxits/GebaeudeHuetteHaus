using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Gebaeude
    {
        public int Grundflaeche { get; set; }
        public double GrundEnergieKosten { get; set; }
        public double MieteProQM { get; set; }

        //Gibt vor, dass ableitende Klassen diese Methode implementieren MÜSSEN. (Design by Contract!)
        public abstract double BerechneEnergiekosten();

        //Implementiert Grundfunktionalität der Basisklasse
        public virtual double ErstelleMietkosten()
        {
            return Grundflaeche * MieteProQM;
        }
    }
}
