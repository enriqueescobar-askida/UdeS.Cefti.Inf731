namespace Week4.Lamp
{
    using System;

    using Common.Lab;
    class Program
    {
        const int QUITTER = 0;
        const int BRANCHER = 1;
        const int DEBRANCHER = 2;
        const int TOUCHER = 3;
        const int DERNIER_CHOIX_MENU = TOUCHER;

        const string TITRE = "*********** Programme de vérification du fonctionnement de la lampe ";
        const string MSG_BRANCHER = "Brancher la lampe dans une prise électrique ";
        const string MSG_DEBRANCHER = "Débrancher la lampe de la prise électrique ";
        const string MSG_TOUCHER = "Toucher le pied de la lampe pour changer l'intensité de l'éclairate ";
        const string MSG_QUITTER = "Quitter ";

        static void Main(string[] args)
        {
            Lamp lamp = new Lamp();
            int reponse;

            // Pour indication de l'état de départ; pourrait être enlevé du fonctionnement du programme
            Console.WriteLine("À la création de la lampe (instanciation de la classe), {0}", lamp.State);
            Console.WriteLine(); Console.WriteLine();

            AfficherMenu();
            reponse = ObtenirChoix();
            while (reponse != QUITTER)
            {
                TraiterChoixObtenu(reponse, lamp);
                AfficherMenu();
                reponse = ObtenirChoix();
            }
        }

        // permet d'afficher le menu proposé
        //------------------------------------------------------------------------
        static void AfficherMenu()
        {
            Console.WriteLine(TITRE);
            Console.WriteLine();
            Console.WriteLine("{0}. {1}", BRANCHER, MSG_BRANCHER);
            Console.WriteLine("{0}. {1}", DEBRANCHER, MSG_DEBRANCHER);
            Console.WriteLine("{0}. {1}", TOUCHER, MSG_TOUCHER);
            Console.WriteLine();
            Console.WriteLine("{0}. {1}", QUITTER, MSG_QUITTER);
            Console.WriteLine("********************************************************************");
        }
        
        static int ObtenirChoix()
        {
            int choix;
            bool lectureReussie;

            do
            {
                Console.Write("Donnez votre choix : ");
                lectureReussie = int.TryParse(Console.ReadLine(), out choix);
                if (!lectureReussie)
                {
                    Console.WriteLine("--- Erreur dans votre choix; donnez une valeur entiere svp...");
                    Console.WriteLine();
                }
                else if (choix < QUITTER || choix > DERNIER_CHOIX_MENU)
                {
                    Console.WriteLine("Choix invalide, recommencez svp ...");
                    Console.WriteLine();
                }
            }
            while (!lectureReussie || choix < QUITTER || choix > DERNIER_CHOIX_MENU);
            return choix;
        }

        static void TraiterChoixObtenu(int reponse, Lamp lamp)
        {
            switch (reponse)
            {
                case BRANCHER:
                    lamp.Plug();
                    Console.WriteLine("-->>> {0}", lamp.State);
                    break;
                case DEBRANCHER:
                    lamp.Unplug();
                    Console.WriteLine("-->>> {0}", lamp.State);
                    break;
                case TOUCHER:
                    lamp.Touch();
                    Console.WriteLine("-->>> {0}", lamp.State);
                    break;
                default:
                    Console.WriteLine(" *** Erreur interne dans le traitement du choix obtenu ***");
                    break;
            }
            Console.WriteLine();
        }
    }
}
