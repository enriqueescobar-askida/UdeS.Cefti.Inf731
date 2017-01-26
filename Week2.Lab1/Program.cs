namespace Week2.Lab1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Common.Lab;
    class Program
    {
        // En plaçant les constantes ici, elles sont disponibles à tous les sous-programmes de la classe Program
        // ce qui évite de les définir plusieurs fois.
        const int LIRE_INFORMATION = 1;
        const int AFFICHER_INFORMATION = 2;
        const int CELEBRER_ANNIVERSAIRE = 3;
        const int CALCULER_NB_ANNEES_AVANT_RETRAITE = 4;
        const int PEUT_PARTIR_POUR_RETRAITE = 5;
        const int DERNIER_CHOIX = PEUT_PARTIR_POUR_RETRAITE;
        const int QUITTER = 0;
        const string MESSAGE_PEUT_PARTIR_POUR_RETRAITE = "Peut partir à la retraite ?";
        //--- Nous considérerons anormal qu'un employé soit embauché
        //    avant un certain âge minimal, ici fixé à 16 ans.
        //    Nous pourrions fixer un âge maximal aussi mais ne
        //    faisons pas d'âgisme.
        const int AGE_MINIMAL_EMBAUCHE = 16;

        static void Main(string[] args)
        {
            int choix;
            Employe employe = new Employe();

            AfficherMenu();
            choix = LireChoix();
            while (choix != QUITTER)
            {
                TraiterChoix(choix, employe);
                AfficherMenu();
                choix = LireChoix();
            }
        }
        static void TraiterChoix(int choix, Employe employe)
        {
            switch (choix)
            {
                case LIRE_INFORMATION:
                    {
                        Console.Write("Donnez le nom de l'employé    : ");
                        string nom = Console.ReadLine();
                        Console.Write("Donnez le prénom de l'employé : ");
                        string prenom = Console.ReadLine();
                        Console.Write("Donnez l'âge de l'employé     : ");
                        int age = int.Parse(Console.ReadLine());
                        while (age < AGE_MINIMAL_EMBAUCHE)
                        {
                            Console.WriteLine(" *** L'âge de l'employé ne peut être inférieur à {0} ***", AGE_MINIMAL_EMBAUCHE);
                            Console.Write("Donnez l'âge de l'employé     : ");
                            age = int.Parse(Console.ReadLine());
                        }
                        employe.LireInformation(nom, prenom, age);
                        break;
                    }
                case AFFICHER_INFORMATION:
                    {
                        Console.WriteLine(employe);
                        break;
                    }
                case CELEBRER_ANNIVERSAIRE:
                    {
                        employe.CelebrerAnniversaire();
                        break;
                    }
                case CALCULER_NB_ANNEES_AVANT_RETRAITE:
                    {
                        int nbAnnées = employe.CalculerAnneesAvantRetraite();

                        // pour éviter l'affichage d'un nombre d'années négatif...
                        if (nbAnnées > 0)
                        {
                            Console.WriteLine("Il reste {0} années avant la retraite", nbAnnées);
                        }
                        else
                        {
                            Console.WriteLine("Cet employé est éligible à la retraite");
                        }
                        break;
                    }
                case PEUT_PARTIR_POUR_RETRAITE:
                    {
                        if (employe.EstEligibleALaRetraite())
                        {
                            Console.WriteLine("Cet employé est éligible à la retraite");
                        }
                        else
                        {
                            Console.WriteLine("Cet employé n'est pas éligible à la retraite");
                        }
                        break;
                    }
            }
        }

        static int LireChoix()
        {
            int choixLu;
            Console.Write("Votre choix : ");
            choixLu = int.Parse(Console.ReadLine());
            while (choixLu < QUITTER || choixLu > DERNIER_CHOIX)
            {
                Console.WriteLine(" *** Choix invalide; recommencez svp ***");
                Console.Write("Votre choix : ");
                choixLu = int.Parse(Console.ReadLine());
            }
            return choixLu;
        }

        // Note : les messages associés aux choix de menu auraient pu faire l'objet d'une constante aussi afin d'en faciliter la modification.
        // Pour en faire la démonstration, je l'ai fait pour l'avant dernier choix.
        static void AfficherMenu()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(" {0}. Lire les informations de l'employé", LIRE_INFORMATION);
            Console.WriteLine(" {0}. Afficher les informations de l'employé", AFFICHER_INFORMATION);
            Console.WriteLine(" {0}. Célébrer l'anniversaire de l'employé", CELEBRER_ANNIVERSAIRE);
            Console.WriteLine(" {0}. Calculer le nombre d'années avant la retraite", CALCULER_NB_ANNEES_AVANT_RETRAITE);
            Console.WriteLine(" {0}. {1}", PEUT_PARTIR_POUR_RETRAITE, MESSAGE_PEUT_PARTIR_POUR_RETRAITE);
            Console.WriteLine();
            Console.WriteLine(" {0}. Quitter", QUITTER);
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
