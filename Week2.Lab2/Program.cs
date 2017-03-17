namespace Week2.Lab2
{
    using System;

    class Program
    {
        /*
         * À noter
         *  - Ce programme lit 2 entier et calcule la somme. Il affiche aussi des
         *    informations sur ces nombres.
         */
        static void Main(string[] args)
        {
            int entier1 = LireEntier();
            AfficherInformationNombre(entier1);
            int entier2 = LireEntier();
            AfficherInformationNombre(entier2);
            int somme = Additionner(entier1, entier2);
            AfficherInformationNombre(somme);
        }

        static int LireEntier()
        {
            Console.Write("Entrer un nombre entier: ");
            string ligneLue = Console.ReadLine();
            return int.Parse(ligneLue);
        }

        static int Additionner(int nombre1, int nombre2)
        {
            int somme = nombre1 + nombre2;
            Console.WriteLine("La somme de {0} et {1} est {2}", nombre1, nombre2, somme);
            return somme;
        }

        static void AfficherInformationNombre(int nombre)
        {
            Console.WriteLine("Nombre '{0}'", nombre);
            if (nombre < 0)
            {
                Console.WriteLine("Ce nombre est négatif");
            }
            else if (nombre > 0)
            {
                Console.WriteLine("Ce nombre est positif");
            }
            else
            {
                Console.WriteLine("Ce nombre n'est ni positif, ni négatif (0)");
            }
            Console.WriteLine("-----------------------");
        }
    }
}
