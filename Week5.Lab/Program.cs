namespace Week5.Lab
{
    using System;
    using Common.Lab;

    class Program
    {
        const int NB_TIRAGES = 10;
        const int MIN = 0;
        const int MAX = 50;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Randomiser();
            Stringeriser();
            Rectungaler();
        }

        static void Randomiser()
        {
            Random random = new Random(22);

            for (int i = 0; i < NB_TIRAGES; ++i)
            {
                Console.WriteLine(random.Next(MIN, MAX));
            }
        }

        static void Stringeriser()
        {
            String chaine = "Bonjour tous les amis";
            string objet = new string('-', 70);

            Console.WriteLine(objet);
            chaine = chaine.Substring(4, 10);
            Console.WriteLine();
            Console.WriteLine(chaine);
        }

        static void Rectungaler()
        {
            Rectangle a = new Rectangle();
            Ecrire("'a'", a);

            Rectangle b = new Rectangle(8);
            Ecrire("'b'", b);

            Rectangle c = new Rectangle(hauteur: 10);
            Ecrire("'c'", c);

            Rectangle d = new Rectangle(12, 15);
            Ecrire("'d'", d);

            Rectangle copieDeA = new Rectangle(a);
            Ecrire("copie de 'a'", copieDeA);
        }

        static void Ecrire(string message, Rectangle rectangle)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Largeur du rectangle {0} : {1}", message, rectangle.Largeur);
            Console.WriteLine("Hauteur du rectangle {0} : {1}", message, rectangle.Hauteur);
        }
    }
}
