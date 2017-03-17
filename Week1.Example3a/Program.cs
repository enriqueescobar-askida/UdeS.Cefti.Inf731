namespace Week1.Example3a
{
    using System;

    class Program
    {
        const int NB_CASES = 10;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] tableau = null;
            tableau = new int[NB_CASES];

            Afficher(tableau);

            // On passe en paramètre par valeur la référence du tableau. Ceci implique que dans une nouvelle variable
            // (le paramètre leTableau), on recopie le contenu de la variable originale (tableau).
            // Nous avons donc deux variables qui contiennent la même référence qui mène au même tableau en mémoire, ce qui
            // explique que les changements apportés via leTableau auront des répercussions sur tableau. 
            RemplirDeValeursAléatoires(tableau);
            Afficher(tableau);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="leTableau"></param>
        static void RemplirDeValeursAléatoires(int[] leTableau)
        {
            Random générateur = new Random();

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
