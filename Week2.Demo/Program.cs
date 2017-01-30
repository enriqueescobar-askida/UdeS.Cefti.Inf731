namespace Week2.Demo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        /*
        *  Passage de paramètre par valeur et par référence
        *
        * À noter:
        *  - En C#, il existe des types par valeur et des types par référence.
        *    -> Les variables ayant un type par valeur contiennent directement une valeur.
        *       Ainsi, lors d'une affectation sur une variable de type par valeur, la valeur
        *       est copiée à l'intérieur de la variable.
        *       => Les types primitif (int, float, bool) sont par valeur
        *    -> Les variables ayant un type par référence pointent/font référence une valeur.
        *       Contrairement au type par valeur, il ne contiennent pas directement leur valeur.
        *       Lors de l'affectation sur une variable d'un type par référence, l'adresse de la
        *       valeur est copiée à l'intérieur de la variable. Il est ainsi possible d'avoir
        *       plusieurs variables par référence pointant sur la même valeur.
        *       => Les types gros/complexe/demandant de l'allocation dynamique de mémoire (tableau,
        *          objets, etc) sont par référence.
        *
        *  - Le passage de paramètre à une fonction peut aussi être par valeur ou par référence
        *    -> Par default, le type de passage de paramètre dépend des types de paramètres:
        *       => Les paramètres ayant un type par valeur sont passés par valeur
        *       => Les paramètres ayant un type par copie sont passés par référence
        *    -> Ainsi,
        *         static void fonction(int entier)        =>  passage par valeur (int est un type par valeur)
        *         static void fonction(ref int entier)    =>  passage par référence (int est un type par valeur, mais on force une référence à l'aide du mot clef 'ref')
        *         static void fonction(int[] tableau)     =>  passage par référence (les tableaux sont toujours par référence)
        *         static void fonction(ref int[] tableau) =>  passage par référence (référence sur une référence!)
        *    -> Lorsqu'un paramètre de fonction est passé par valeur, toute modification effectuée
        *       au paramètre est sans effet sur le paramètre utilisé dans l'appel puisque le valeur
        *       est en fait copie.
        *    -> Lorsqu'un paramètre de fonction est passé par référence, toute modification effectuée
        *       au paramètre se répercutera sur la fonction appelante puisque la fonction reçoit une
        *       référence sur la valeur.
        */
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
