using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Wohnhaus : Gebaeude
	{
        public int AnzahlBewohner { get; set; }
        public int DaemmungStaerke { get; set; }

        //MUSS-Implementierung der abstracten Methode
        public override double BerechneEnergiekosten()
        {
            return (GrundEnergieKosten + (GrundEnergieKosten * AnzahlBewohner * 0.03))
                / DaemmungStaerke;

        }

        //KANN-Implementierung der virtuellen Methode
        //Erweiterung der Methode der Basisklasse
        public override double ErstelleMietkosten()
        {
            double baseMK = base.ErstelleMietkosten();
            double ruecklage = 122.34;
            return baseMK + AnzahlBewohner * ruecklage;
        }
    }
}
