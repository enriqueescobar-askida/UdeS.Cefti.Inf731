namespace Week5.Demo
{
    using System;

    using Common.Lab;

    class Program
    {
        static void Main(string[] args)
        {
            Car voiture1 = new Car("Ford", "Focus");
            Afficher(voiture1);
            Car voiture2 = new Car("Porche", "Cayenne", 44534);
            Afficher(voiture2);
            Car cloneVoiture2 = new Car(voiture2);
            Afficher(cloneVoiture2);
        }

        static void Afficher(Car voiture)
        {
            Console.WriteLine("Voiture[{0} {1}, {2}km]", voiture.Marque, voiture.Modele, voiture.Kilometrage);
        }
    }
}
