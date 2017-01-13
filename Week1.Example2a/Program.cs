namespace Week1.Example2a
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class Program
    {
        /// <summary>
        /// le fond de l'écran en blanc et le texte en bleu. La mécanique de ceci sera expliquée
        /// plus tard durant la session, lorsque nous verrons les constructeurs de classe.
        /// </summary>
        static Program()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int b = 5;
            int a = b + 12 / 2;
            Console.WriteLine("Valeur maximale d'une variable de type short : {0}", short.MaxValue);
            Console.WriteLine("Valeur maximale d'une variable de type int   : {0}", int.MaxValue);
            Console.WriteLine("Valeur maximale d'une variable de type long  : {0}", long.MaxValue);
            Console.WriteLine();
            Console.WriteLine("La variable b vaut {0}", b);
            Console.WriteLine();
            Console.WriteLine("Résultat de b + 12 / 2 : {0}", a);
            int c = b / 2;  // division entière
            Console.WriteLine();
            Console.WriteLine("Résultat de b / 2 : {0}", c);
            float d = b / 2;
            Console.WriteLine();
            Console.WriteLine("b / 2 affecté à un float ne change pas la nature de la division entière : {0}", d);

            // float e = b / 2.0; // Ceci provoque une erreur pour cause de conflit de type; 2.0 est une valeur 'double' par défaut
            float e = b / 2.0f;  // division réelle
            Console.WriteLine();
            Console.WriteLine("Résultat de b / 2.0f : {0}", e);
        }
    }
}
