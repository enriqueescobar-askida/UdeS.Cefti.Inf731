using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture1 = new Voiture("Ford", "Focus");
            Afficher(voiture1);
            Voiture voiture2 = new Voiture("Porche", "Cayenne", 44534);
            Afficher(voiture2);
            Voiture cloneVoiture2 = new Voiture(voiture2);
            Afficher(cloneVoiture2);
        }

        static void Afficher(Voiture voiture)
        {
            Console.WriteLine("Voiture[{0} {1}, {2}km]", voiture.Marque, voiture.Modele, voiture.Kilometrage);
        }
    }
}
