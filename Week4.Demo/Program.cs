namespace Week4.Demo
{
    using System;
    using Common.Lab;
    class Program
    {
        static void Main(string[] args)
        {
            CarStatic voiture = new CarStatic();
            voiture.ReservoirEssence = CarStatic.CapaciteReservoirEssence;

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

        static void AfficherVoiture(CarStatic voiture)
        {
            Console.WriteLine("Reservoir global: {0}/{1} litres", CarStatic.ReservoirEssenceGlobal, CarStatic.CapaciteReservoirEssenceGlobal);
            Console.WriteLine("Kilométrage de la voiture: {0}km", voiture.Kilometrage);
            Console.WriteLine("Essence de la voiture: {0}/{1} litres", voiture.ReservoirEssence, CarStatic.CapaciteReservoirEssence);
        }
    }
}
