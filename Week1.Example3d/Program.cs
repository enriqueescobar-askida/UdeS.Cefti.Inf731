namespace Week1.Example3d
{
    using System;

    class Program
    {
        const int NB_CASES = 10;
        static void Main(string[] args)
        {
            int[] tableau = null;
            tableau = new int[NB_CASES];
            Afficher(tableau);
            RemplirDeValeursAléatoires(tableau);

            // Dans le contexte, le tableau contient toujours la même valeur à moins d'être très chanceux
            // et que l'horloge ait changé de milliseconde entre les appels.  
            Afficher(tableau);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="leTableau"></param>
        static void RemplirDeValeursAléatoires(int[] leTableau)
        {
            for (int i = 0; i < leTableau.Length; ++i)
            {
                leTableau[i] = TirerUnNombre();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static int TirerUnNombre()
        {
            Random générateur = new Random();

            return générateur.Next(0, 101);
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
