namespace Week1.Example1a
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
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int valeurLue;

            Console.Write("Donnez la valeur : ");
            valeurLue = int.Parse(Console.ReadLine());

            Console.WriteLine("La variable contient {0}", valeurLue);

            if (valeurLue % 2 == 0)
            {
                Console.WriteLine("... et cette valeur est paire");
            }
            else
            {
                Console.WriteLine("... c'est une valeur impaire");
            }
        }
    }
}
