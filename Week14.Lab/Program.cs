namespace Week14.Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.Lab;

    class Program
    {
        static void Main(string[] args)
        {
            CupOfTea();
            Pizzeria();
            Army();
        }

        private static void Army()
        {
            List<Fighter> army = new List<Fighter>();
            // à la création d'un combattant, on doit fournir son nom
            // ainsi qu'une référence sur son arme.
            army.Add(new Fighter("Voyou", new Machete(6)));
            army.Add(new Fighter("Ordure", new Revolver(10)));
            Console.WriteLine("Voici les dégats que peut faire notre armée : ");
            Console.WriteLine();

            foreach (Fighter c in army)
                Console.WriteLine("{0} produit {1} points de dégâts", c.Name, c.Attack());
        }

        private static void Pizzeria()
        {
            PizzaFactory fabrique = new PizzaFactory();

            for (int i = 0; i < 5; ++i)
            {
                AbstractPizza p = fabrique.Instancier(ChoisirPizza(fabrique));
                // pour indiquer le nom de la classe qui a été instanciée
                Console.WriteLine(p.ToString());
                Console.WriteLine();
                Console.WriteLine(new string('-', 72));
            }
        }
        // ChoisirPizza est placé ici puisque c'est ce programme qui sait
        // quel genre d'interface il utilise
        static string ChoisirPizza(PizzaFactory fabrique)
        {
            var liste = fabrique.ListeDesPizzas;
            string retour = string.Empty;
            bool choixEffectué = false;

            while (!choixEffectué)
            {
                try
                {
                    int i = 1;
                    foreach (string s in liste)
                    {
                        Console.WriteLine(i++ + ". " + s);
                    }

                    Console.Write("Donnez votre choix : ");
                    retour = liste.ElementAt(int.Parse(Console.ReadLine()) - 1);
                    choixEffectué = true;
                }
                catch (Exception)
                {
                    Console.WriteLine(" *** Choix invalide au menu ***");
                }
            }
            return retour;
        }

        private static void CupOfTea()
        {
            Cup première = new Cup(300);
            Cup seconde = new Cup(250);
            int valeur = (int)seconde;
            Cup troisième = 500;
            Cup quelconque = Modifier(200);
            Console.WriteLine((int)quelconque);
            int somme = 0;
            somme = somme + (int)première;  // (int) rendu nécessaire par la conversion 'explicit'
            somme += (int)seconde;          // ne serait pas requis pour une conversion 'implicit'
            somme += (int)troisième;
            Console.WriteLine("Somme : {0}", somme);
        }

        static Cup Modifier(Cup uneTasse)
        {
            return new Cup(uneTasse.NbMl + 100);
        }
    }
}
