using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Demo
{
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
            //RunCarEnum();
        }

        static void RunCar()
        {
            Voiture v1 = new Voiture();
            Voiture v2 = new Voiture();

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

        static void AfficherVoiture(Voiture voiture)
        {
            Console.WriteLine("Immatriculation: {0}", voiture.Immatriculation);
            Console.WriteLine("Couleur: {0}", voiture.Couleur);
            Console.WriteLine("Kilometrage: {0}km", voiture.Kilometrage);
        }

        /*static void RunCarEnum()
        {
            VoitureEnum v1 = new VoitureEnum();
            VoitureEnum v2 = new VoitureEnum();

            v1.Immatriculation = "3j53n1";
            v1.Couleur = Colors.Bleu; //enum
            v1.Marque = "Ford";

            v2.Immatriculation = "p53l2m";
            v2.Couleur = Colors.Rouge; //enum
            v2.Marque = "Porsche";

            AfficherVoitureEnum(v1);
            Console.WriteLine("-------------");
            AfficherVoitureEnum(v2);
            Console.WriteLine();
            Console.WriteLine(v1.ParcourirDistance(44));
            Console.WriteLine(v1.ParcourirDistance(7000));
            Console.WriteLine(v2.ParcourirDistance(1245));
            Console.WriteLine(v2.ParcourirDistance(12));
            Console.WriteLine(v2.ParcourirDistance(128));
            Console.WriteLine();
            AfficherVoitureEnum(v1);
            Console.WriteLine("-------------");
            AfficherVoitureEnum(v2);
            Console.ReadLine();
        }

        static void AfficherVoitureEnum(VoitureEnum voitureEnum)
        {
            Console.WriteLine("Immatriculation: {0}", voitureEnum.Immatriculation);
            Console.WriteLine("Couleur: {0}", voitureEnum.Couleur);
            Console.WriteLine("Kilometrage: {0}km", voitureEnum.Kilometrage);
        }*/
    }
}
