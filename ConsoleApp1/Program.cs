using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
    {
        public static List<Gebaeude> alleGebäude = new List<Gebaeude>();
		static void Main(string[] args)
		{
			Ferienhuette huetteSchwarzwald = new Ferienhuette() { Grundflaeche = 20, MieteProQM = 50.33, BelegungsGrad = 76, GrundEnergieKosten = 299.0 };
			Ferienhuette amStrand = new Ferienhuette() { Grundflaeche = 50, MieteProQM = 170.40, BelegungsGrad = 40, GrundEnergieKosten = 734.43 };
			Ferienhuette eifel = new Ferienhuette() { Grundflaeche = 76, MieteProQM = 120.22, BelegungsGrad = 90, GrundEnergieKosten = 487.24 };

			Wohnhaus stuttgartMitte = new Wohnhaus() { AnzahlBewohner = 15, DaemmungStaerke = 1, Grundflaeche = 1200, GrundEnergieKosten = 12000, MieteProQM = 900.45 };
			Wohnhaus landHaus1 = new Wohnhaus() { AnzahlBewohner = 5, DaemmungStaerke = 5, Grundflaeche = 210, GrundEnergieKosten = 5000, MieteProQM = 455.21 };
			Wohnhaus landHaus2 = new Wohnhaus() { AnzahlBewohner = 2, DaemmungStaerke = 12, Grundflaeche = 120, GrundEnergieKosten = 2300, MieteProQM = 511.00 };




			List<Gebaeude> meineGebaeude = new List<Gebaeude>();

			meineGebaeude.Add(huetteSchwarzwald);
			meineGebaeude.Add(amStrand);
			meineGebaeude.Add(eifel);
			meineGebaeude.Add(stuttgartMitte);
			meineGebaeude.Add(landHaus1);
			meineGebaeude.Add(landHaus2);

			double mieteGesamt = 0.0;
			double energieKostenGesamt = 0.0;

            foreach (Gebaeude geb in meineGebaeude)
            {
				mieteGesamt += geb.ErstelleMietkosten();
				energieKostenGesamt += geb.BerechneEnergiekosten();
            }

			Console.WriteLine($@"Die Mietkosten aller Gebäude beträgt {mieteGesamt}.");
			Console.WriteLine($@"Die Gesamtenergiekosten belaufen sich auf: {energieKostenGesamt}");

			Console.ReadLine();
		}
        
	}
}
