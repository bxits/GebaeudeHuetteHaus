using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Ferienhuette : Gebaeude
	{
        public int BelegungsGrad { get; set; }

        //MUSS-Implementierung der abstracten Methode
        public override double BerechneEnergiekosten()
        {
            return GrundEnergieKosten * BelegungsGrad * 2.5;
        }

        //KANN-Implementierung der virtuellen Methode
        //Erweiterung der Methode der Basisklasse
        public override double ErstelleMietkosten()
        {
            double baseMK = base.ErstelleMietkosten();
            return baseMK * BelegungsGrad;
        }
    }
}
