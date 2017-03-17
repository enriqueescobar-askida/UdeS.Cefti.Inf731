namespace Week1.Example3c
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
            RemplirDeValeursAléatoires(ref tableau);
            Afficher(tableau);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="leTableau"></param>
        static void RemplirDeValeursAléatoires(ref int[] leTableau)
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
