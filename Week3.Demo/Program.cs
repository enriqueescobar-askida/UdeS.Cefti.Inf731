namespace Week3.Demo
{
    using System;

    using Common.Lab;
    class Program
    {
        /*
        * Exemple avec classe de base comprenant données membres, méthodes et propriétés
        * À noter:
        *  - La classe Voiture possède 4 attributs et 4 propriétés associées
        *    -> Immatriculation
        *    -> Couleur
        *    -> Kilométrage
        *    -> Marque
        *  - La classe Voiture possède aussi une méthode publique
        *    -> ParcourirDistance(...) fait parcourir une certaine quantité de kilomètres à
        *       la voiture
        *  - Immatriculation, Couleur et Marque ont un accesseur et un mutateur public
        *  - Kilometrage possède aussi un accesseur public, mais son mutateur est privé.
        *    -> Cela signifie que seule la classe Voiture peut modifier le kilometrage
        *    -> Cette restrition d'accès nous permet de protégrer la valeur de kilometrage
        *       et d'assurer que sa valeur toujours valide et cohérente.
        *    -> En effet, le kilometrage qui ne peut diminuer, il ne peut qu'augmenter. Du
        *       point de vue du programme client, la seule façon de modifier le kilometrage
        *       passe par la méthode ParcourrirDistance, et cette méthode ne permet que
        *       d'augmenter le kilometrage.
        */
        static void Main(string[] args)
        {
            RunCar();
            RunCarEnum();
        }

        static void RunCar()
        {
            Car v1 = new Car();
            Car v2 = new Car();

            v1.Immatriculation = "3j53n1";
            v1.Couleur = "Bleu";
            v1.Marque = "Ford";

            v2.Immatriculation = "p53l2m";
            v2.Couleur = "Rouge";
            v2.Marque = "Porsche";

            AfficherVoiture(v1);
            Console.WriteLine("-------------");
            AfficherVoiture(v2);
            Console.WriteLine();
            Console.WriteLine(v1.ParcourirDistance(44));
            Console.WriteLine(v1.ParcourirDistance(7000));
            Console.WriteLine(v2.ParcourirDistance(1245));
            Console.WriteLine(v2.ParcourirDistance(12));
            Console.WriteLine(v2.ParcourirDistance(128));
            Console.WriteLine();
            AfficherVoiture(v1);
            Console.WriteLine("-------------");
            AfficherVoiture(v2);
            Console.ReadLine();
        }

        static void AfficherVoiture(Car voiture)
        {
            Console.WriteLine("Immatriculation: {0}", voiture.Immatriculation);
            Console.WriteLine("Couleur: {0}", voiture.Couleur);
            Console.WriteLine("Kilometrage: {0}km", voiture.Kilometrage);
        }

        static void RunCarEnum()
        {
            CarWithEnumColors v1 = new CarWithEnumColors
            {
                Immatriculation = "3j53n1",
                Couleur = EnumColors.Blue,
                Marque = "Ford"
            };

            CarWithEnumColors v2 = new CarWithEnumColors
            {
                Immatriculation = "p53l2m",
                Couleur = EnumColors.Red,
                Marque = "Porsche"
            };

            AfficherEnumCar(v1);
            Console.WriteLine("-------------");
            AfficherEnumCar(v2);
            Console.WriteLine();
            Console.WriteLine(v1.ParcourirDistance(44));
            Console.WriteLine(v1.ParcourirDistance(7000));
            Console.WriteLine(v2.ParcourirDistance(1245));
            Console.WriteLine(v2.ParcourirDistance(12));
            Console.WriteLine(v2.ParcourirDistance(128));
            Console.WriteLine();
            AfficherEnumCar(v1);
            Console.WriteLine("-------------");
            AfficherEnumCar(v2);
            Console.ReadLine();
        }

        static void AfficherEnumCar(CarWithEnumColors voitureEnum)
        {
            Console.WriteLine("Immatriculation: {0}", voitureEnum.Immatriculation);
            Console.WriteLine("Couleur: {0}", voitureEnum.Couleur);
            Console.WriteLine("Kilometrage: {0}km", voitureEnum.Kilometrage);
        }
    }
}
