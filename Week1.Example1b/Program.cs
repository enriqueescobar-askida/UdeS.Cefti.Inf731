namespace Week1.Example1b
{
    using System;

    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Limite maximale d'un entier : {0}", int.MaxValue);
            Console.WriteLine();
            Console.WriteLine("Limite minimale d'un entier : {0}", int.MinValue);
            int valeur = int.MaxValue - 10;

            // Cette boucle illustre que si on atteint la valeur maximale d'un entier 
            // pour ensuite incrémenter encore la variable, on passe du côté négatif

            while (valeur != 0)
            {
                Console.WriteLine(valeur);
                valeur++;
                Console.ReadKey();
            }
        }
    }
}
