namespace Week1.Example2b
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        static Program()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
        }
        /// <summary>
        /// Notez ici que les deux paramètres sont passés par valeur.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void CalculerValeur(int a, int b)
        {
            a = b + 12 / 2;
        }
        /// <summary>
        /// Notez ici que a est passé par référence, ce qui signifie que les modifications au
        /// paramètre auront un effet sur la variable originale transmise. 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void CalculerValeur(ref int a, int b)
        {
            a = b + 12 / 2;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int b = 5;
            int a = 0;
            CalculerValeur(a, b);
            Console.WriteLine("Valeur de a après appel à CalculerValeur(a,b) : {0}", a);
            CalculerValeur(ref a, b);
            Console.WriteLine();
            Console.WriteLine("Valeur de a après appel à CalculerValeur(ref a, b) : {0}", a);
        }
    }
}
