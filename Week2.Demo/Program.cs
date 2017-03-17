namespace Week2.Demo
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================");
            Console.WriteLine("=    Type par valeur   =");
            Console.WriteLine("========================");

            int entier1 = 42;
            int entier2 = entier1; //copie de la valeur
                                   //entier1 et entier2 contiennent chacun la valeur 42

            afficher("entier1", entier1);
            afficher("entier2", entier2);

            Console.WriteLine("-------");
            Console.WriteLine("Appel à 'fonctionPassageParCopieSurTypeParValeur' avec entier1 comme paramètre.");
            fonctionPassageParCopieSurTypeParValeur(entier1);
            afficher("entier1", entier1);
            afficher("entier2", entier2);

            Console.WriteLine("-------");
            Console.WriteLine("Appel à 'fonctionPassageParReferenceSurTypeParValeur' avec entier1 comme paramètre.");
            fonctionPassageParReferenceSurTypeParValeur(ref entier1);
            afficher("entier1", entier1);
            afficher("entier2", entier2);

            Console.WriteLine();

            Console.WriteLine("===========================");
            Console.WriteLine("=    Type par reference   =");
            Console.WriteLine("===========================");

            int[] tableau1 = new int[] { 1, 2, 3 };
            int[] tableau2 = tableau1; //copie de l'adresse du tableau.
            //tableau1 et tableau2 pointent sur le même tableau
            afficherTableau("tableau1", tableau1);
            afficherTableau("tableau2", tableau2);

            Console.WriteLine("-------");
            Console.WriteLine("Appel à 'fonctionPassageParCopieSurTypeParReference' avec tableau1 comme paramètre.");
            fonctionPassageParCopieSurTypeParReference(tableau1);
            afficherTableau("tableau1", tableau1);
            afficherTableau("tableau2", tableau2);

            Console.WriteLine("-------");
            Console.WriteLine("Appel à 'fonctionPassageParReferenceSurTypeParReference' sur avec tableau1 comme paramètre.");
            fonctionPassageParReferenceSurTypeParReference(ref tableau1);
            afficherTableau("tableau1", tableau1);
            afficherTableau("tableau2", tableau2);
        }

        static void fonctionPassageParCopieSurTypeParValeur(int param)
        {
            Console.WriteLine(" -> Modification au paramètre de type par valeur");
            param = 1;
        }

        static void fonctionPassageParReferenceSurTypeParValeur(ref int param)
        {
            Console.WriteLine(" -> Modification au paramètre référence sur type par valeur");
            param = 1;
        }

        static void fonctionPassageParCopieSurTypeParReference(int[] param)
        {
            Console.WriteLine(" -> Modification au paramètre de type par reference");

            for (int idx = 0; idx < param.Length; ++idx)
            {
                param[idx] = 1;
            }
        }

        static void fonctionPassageParReferenceSurTypeParReference(ref int[] param)
        {
            Console.WriteLine(" -> Modification au paramètre référence sur type par reference");

            for (int idx = 0; idx < param.Length; ++idx)
            {
                param[idx] = 1;
            }
        }
        static void afficher(string nomParam, int valeur)
        {
            Console.WriteLine("La variable '{0}' vaut {1}", nomParam, valeur);
        }

        static void afficherTableau(string nomParam, int[] valeur)
        {
            Console.Write("La variable '{0}' vaut ", nomParam);
            Console.Write("{");
            for (int idx = 0; idx < valeur.Length; ++idx)
            {
                Console.Write(valeur[idx]);
                if (idx != valeur.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("}");
        }
    }
}
