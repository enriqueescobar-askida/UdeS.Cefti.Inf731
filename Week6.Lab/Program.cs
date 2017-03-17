namespace Week6.Lab
{
    using System;
    using Common.Lab;

    class Program
    {
        const char SEPARATEUR = ';';
        static void Main(string[] args)
        {
            Funnier();
            WhatEver();
            Splitter();
        }

        private static void Splitter()
        {
            char[] séparateurs = new char[] { ';' };
            string uneChaine = "Pierre;Prud'homme;90   ;   23   ";
            string[] chaineS = uneChaine.Split(SEPARATEUR);

            for(int i = 0; i < chaineS.Length; ++i)
                Console.WriteLine(chaineS[i]);

            Console.WriteLine("La somme des deux derniers éléments vaut : ");
            Console.WriteLine(int.Parse(chaineS[2]) + int.Parse(chaineS[3]));
        }

        private static void WhatEver()
        {
            string uneChaine = new string('*', 70);
            Console.WriteLine(uneChaine);

            string chaineA = "Allo";
            string chaineB = "toi";
            Console.WriteLine(chaineA + chaineB);
            Console.WriteLine(chaineA);
            Console.WriteLine(chaineB);
            string texte = "Il était une fois, dans un pays lointain, un jeune prince qui vivait dans un somptueux château.";
            texte = texte.Substring(3, 20);
            Console.WriteLine(texte);
            Console.WriteLine(texte.Substring(3, 6));
            texte = texte.ToUpper();
            Console.WriteLine(texte);
            Console.WriteLine();
            string chaineLue;
            Console.Write("Donnez une chaine : ");
            chaineLue = Console.ReadLine();
            Console.WriteLine("La chaine a une longueur de {0} caractères", chaineLue.Length);
            chaineLue = chaineLue.Trim();
            Console.WriteLine("La chaine a une longueur de {0} caractères", chaineLue.Length);
            Quelconque uneInstance = new Quelconque();
            Console.WriteLine(uneInstance.PeuImporte);
            if (uneInstance.ChainStrange == null)
            {
                Console.WriteLine("null");
            }
            else
            {
                if (uneInstance.ChainStrange == string.Empty)
                {
                    Console.WriteLine("vide");
                }
                else
                {
                    Console.WriteLine("... Autre chose ...");
                }
            }

            if (string.IsNullOrEmpty(uneInstance.ChainStrange))
            {
                Console.WriteLine("eh! oui !!!!");
            }

            Quelconque autreInstance = new Quelconque("      ");
            if (string.IsNullOrEmpty(autreInstance.ChainStrange.Trim()))
            {
                Console.WriteLine("en effet...");
            }

        }

        private static void Funnier()
        {
            Fun objet1 = new Fun();
            Fun objet2 = new Fun(2);
            Fun objet3 = new Fun(3.0);
            Fun objet4 = new Fun(4, 4.0);

            Console.WriteLine("Dans main(), juste apres declarations"); Console.WriteLine();

            Console.WriteLine("Dans main(), avant premier appel"); Console.WriteLine();
            TraiterAvecDesVariablesLocales();
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Avant PassageParRéférence, l'objet transmis contient {0} et {1}",
                               objet1.Entier, objet1.Double);
            TraiterAvecPassageParRef(objet1);
            Console.WriteLine("Au retour de PassageParRéférence, l'objet contient dorénavant {0} et {1}",
                               objet1.Entier, objet1.Double); Console.WriteLine();
            Console.ReadKey();


            Console.WriteLine("Avant PassageParRéférenceDeRéférence, l'objet transmis contient {0} et {1}",
                               objet2.Entier, objet2.Double);
            TraiterReferenceDeRef(ref objet2);
            Console.WriteLine("Au retour de PassageParRéférencDeRéférence, l'objet contient dorénavant {0} et {1}",
                               objet2.Entier, objet2.Double); Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Dans main(), juste avant fin du programme"); Console.WriteLine();
        }

        static void TraiterAvecDesVariablesLocales()
        {
            Fun obj1 = new Fun(5);
            Fun obj2 = new Fun(6, 6.0);
            Console.WriteLine("Dans TraiterAvecDesVariablesLocales(), apres déclarations");
        }

        static void TraiterAvecPassageParRef(Fun obj)
        {
            obj = new Fun(7);
            Console.WriteLine("Dans TraiterAvecPassageParRéférence()");
        }

        static void TraiterReferenceDeRef(ref Fun obj)
        {
            obj = new Fun(8);
            Console.WriteLine("Dans TraiterRéférenceDeRéférence()");
        }

    }
}
