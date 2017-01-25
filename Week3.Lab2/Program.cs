namespace Week3.Lab2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Common.Lab;
     
    class Program
    {
        const int QUITTER = 0;
        const int CONSERVER_F = 1;
        const int CONSERVER_C = 2;
        const int OBTENIR_F = 3;
        const int OBTENIR_C = 4;

        const string TITRE = "*********** Programme de conversion de temperature";
        const string MSG_CONSERVER_F = "Conserver une temperature en Fahrenheit ";
        const string MSG_CONSERVER_C = "Conserver une temperature en Celsius ";
        const string MSG_OBTENIR_F = "Obtenir la temperature en Fahrenheit ";
        const string MSG_OBTENIR_C = "Obtenir la temperature en Celsius ";
        const string MSG_QUITTER = "Quitter ";

        static void Main(string[] args)
        {
            Temperature temperature = new Temperature();
            int reponse;

            AfficherMenu();
            reponse = ObtenirChoix();
            while (reponse != QUITTER)
            {
                TraiterChoixObtenu(reponse, temperature);
                AfficherMenu();
                reponse = ObtenirChoix();
            }
        }

        // permet d'afficher le menu proposé dans le laboratoire
        static void AfficherMenu()
        {
            Console.WriteLine(TITRE);
            Console.WriteLine();
            Console.WriteLine("{0}. {1}", CONSERVER_F, MSG_CONSERVER_F);
            Console.WriteLine("{0}. {1}", CONSERVER_C, MSG_CONSERVER_C);
            Console.WriteLine("{0}. {1}", OBTENIR_F, MSG_OBTENIR_F);
            Console.WriteLine("{0}. {1}", OBTENIR_C, MSG_OBTENIR_C);
            Console.WriteLine();
            Console.WriteLine("{0}. {1}", QUITTER, MSG_QUITTER);
            Console.WriteLine("**************************************************");
        }


        // permet d'obtenir de l'utilisateur une réponse validée au menu
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
                else if (choix < QUITTER || choix > OBTENIR_C)
                {
                    Console.WriteLine("Choix invalide, recommencez svp ...");
                    Console.WriteLine();
                }
            }
            while (!lectureReussie || choix < QUITTER || choix > OBTENIR_C);
            return choix;
        }

        // permet de traiter le choix de l'utilisateur
        static void TraiterChoixObtenu(int reponse, Temperature temp)
        {
            double valeurLue;

            switch (reponse)
            {
                case CONSERVER_F:
                    Console.Write("Donnez la temperature en Fahrenheit : ");
                    valeurLue = double.Parse(Console.ReadLine());
                    temp.Anglaise = valeurLue;
                    break;
                case CONSERVER_C:
                    Console.Write("Donnez la temperature en Celsius : ");
                    valeurLue = double.Parse(Console.ReadLine());
                    temp.Metrique = valeurLue;
                    break;
                case OBTENIR_F:
                    Console.WriteLine("La temperature en Fahrenheit est de {0}", temp.Anglaise);
                    Console.WriteLine();
                    break;
                case OBTENIR_C:
                    Console.WriteLine("La temperature en Celsius est de {0}", temp.Metrique);
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine(" *** Erreur interne dans le traitement du choix obtenu ***");
                    break;
            }
        }
    }
}
