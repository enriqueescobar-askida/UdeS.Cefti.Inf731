using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture = new Voiture();
            voiture.ReservoirEssence = Voiture.CAPACITE_RESERVOIR_ESSENCE;

            AfficherVoiture(voiture);
            Console.WriteLine("==============================");

            voiture.ParcourirDistance(58);
            Console.WriteLine("Parcourrir 58km avec la voiture");
            voiture.ParcourirDistance(21);
            Console.WriteLine("Parcourrir 21km avec la voiture");
            Console.WriteLine("==============================");

            AfficherVoiture(voiture);
            Console.WriteLine("==============================");

            Console.WriteLine("Faire le plein d'essence de la voiture!");
            voiture.FaireLePlein();
            Console.WriteLine("==============================");

            AfficherVoiture(voiture);
        }

        static void AfficherVoiture(Voiture voiture)
        {
            Console.WriteLine("Reservoir global: {0}/{1} litres", Voiture.ReservoirEssenceGlobal, Voiture.CAPACITE_RESERVOIR_ESSENCE_GLOBAL);
            Console.WriteLine("Kilométrage de la voiture: {0}km", voiture.Kilometrage);
            Console.WriteLine("Essence de la voiture: {0}/{1} litres", voiture.ReservoirEssence, Voiture.CAPACITE_RESERVOIR_ESSENCE);
        }
    }
}
