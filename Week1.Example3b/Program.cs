namespace Week1.Example3b
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        const int NB_CASES = 10;
        static void Main(string[] args)
        {
            int[] tableau = null;
            tableau = new int[NB_CASES];
            Afficher(tableau);

            // On passe en paramètre par valeur la référence du tableau. Ceci implique 
            // que dans une nouvelle variable (le paramètre leTableau), on recopie le 
            // contenu de la variable originale (tableau). Nous avons donc deux variables
            // qui contiennent la même référence qui mène au même tableau en mémoire, ce qui
            // explique que les changements apportés via leTableau auront des répercussions
            // sur tableau. 
            RemplirDeValeursAléatoires(tableau);

            // Dans le contexte, le tableau est toujours dans son état original. 
            Afficher(tableau);
        }
        /// <summary>
        /// Subtilité ici : puisque le paramètre par valeur est une variable distincte de l'originale,
        /// quand on instancie un nouveau tableau avec le new, ce tableau est entièrement distinct 
        /// du tableau créé dans le Main. On emplit donc ce nouveau tableau, ce qui n'a pas d'effet
        /// sur le tableau créé dans le Main. Le paramètre par valeur étant considéré comme une variable
        /// locale, cette variable (leTableau) disparaît de la pile d'exécution quand la fonction 
        /// RemplirDeValeursAléatoires est terminé
        /// </summary>
        /// <param name="leTableau"></param>
        static void RemplirDeValeursAléatoires(int[] leTableau)
        {
            Random générateur = new Random();
            leTableau = new int[NB_CASES];

            for (int i = 0; i < leTableau.Length; ++i)
            {
                leTableau[i] = générateur.Next(0, 101);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="leTableau"></param>
        static void Afficher(int[] leTableau)
        {
            Console.WriteLine(new string('-', 60));
            for (int i = 0; i < leTableau.Length; ++i)
            {
                Console.WriteLine(leTableau[i]);
            }
        }
    }
}
