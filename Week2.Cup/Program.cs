namespace Week2.Cup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Common.Lab;
    class Program
    {
        static void Main(string[] args)
        {
            // Illustration qu'un objet, dès sa création, va initialiser ses attributs
            // à leur valeur par défaut; ici, la valeur par défaut d'un entier est 0
            //----------------------------------------------------------
            Cup whatever = new Cup();
            Console.WriteLine(whatever.ToString());

            // Nous allons créer plusieurs instances d'une même classe Chaque instance de classe
            // (chaque objet) pourra être atteint à l'aide de sa référence;
            // Le 'new' provoque la création de l'instance en mémoire et réserve l'espace requis
            // pour les attributs ayant été indiqués dans la classe.
            // L'objet peut invoquer les méthodes que la classe a bien voulu lui rendre disponible
            // i.e. les méthodes privées
            // La bonne pratique est de mettre les attributs private (ils le sont par défaut,
            // si on n'indique rien) référence sur une Cup
            Cup firstCup = new Cup();
            firstCup.Initialiser(200);
            Console.WriteLine(firstCup.ToString());

            Cup secondCup = new Cup();
            secondCup.Initialiser(167);
            Console.WriteLine(secondCup.ToString());

            Cup thirdCup = new Cup();
            thirdCup.Initialiser(567);
            Console.WriteLine(thirdCup.ToString());
            thirdCup.Initialiser(-111);
            Console.WriteLine(thirdCup.ToString());

            Cup aCup = new Cup
            {
                Couleur = "White"
            };
            Console.WriteLine("This cup is " + aCup.Couleur);
        }
    }
}
