namespace Week2.Cup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main(string[] args)
        {
            // Illustration qu'un objet, dès sa création, va initialiser ses attributs
            // à leur valeur par défaut; ici, la valeur par défaut d'un entier est 0
            //----------------------------------------------------------
            Cup whatever = new Cup();
            whatever.Afficher();

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
            firstCup.Afficher();

            Cup secondCup = new Cup();
            secondCup.Initialiser(167);
            secondCup.Afficher();

            Cup thirdCup = new Cup();
            thirdCup.Initialiser(567);
            thirdCup.Afficher();
            thirdCup.Initialiser(-111);
            thirdCup.Afficher();

            Cup aCup = new Week2.Cup.Cup();
            aCup.Couleur = "White";
            Console.WriteLine("This cup is " + aCup.Couleur);
        }
    }
}
