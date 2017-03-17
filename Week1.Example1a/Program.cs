namespace Week1.Example1a
{
    using System;

    class Program
    {
        static void Main(string[] args)
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

            }
        }
    }
}
