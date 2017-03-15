namespace Week8.Demo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Common.Lab;
    class Program
    {
        static void Main(string[] args)
        {
            List<Voiture> voitures = LireVoitures();
            EcrireVoitures(voitures);
        }

        static List<Voiture> LireVoitures()
        {
            List<Voiture> voitures = new List<Voiture>();

            bool lectureTermine = false; //la lecture n'est pas terminée
            while (!lectureTermine) //tant que la lecture n'est pas terminée
            {
                try
                {
                    Console.Write("Entrer le modèle de la voiture {0}: ", voitures.Count + 1);
                    string modele = Console.ReadLine();

                    Console.Write("Entrer la couleur de la voiture {0}: ", voitures.Count + 1);
                    string couleur = Console.ReadLine();

                    if (modele == "q" && couleur == "q")
                    {
                        lectureTermine = true;
                    }
                    else
                    {
                        Console.Write("Entrer le kilometrage de la voiture {0}: ", voitures.Count + 1);
                        int kilometrage = int.Parse(Console.ReadLine());

                        Voiture nouvelleVoiture = new Voiture(modele, couleur, kilometrage);
                        voitures.Add(nouvelleVoiture);
                    }
                }
                catch (VoitureCouleurInvalideException ex)
                {
                    Console.WriteLine("Couleur invalide!");
                }
                catch (VoitureModeleInvalideException ex)
                {
                    Console.WriteLine("Modele invalide!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur lors de la création de la voiture: {0}", ex.Message);
                }
            }

            return voitures;
        }

        static void EcrireVoitures(List<Voiture> voitures)
        {
            Console.WriteLine("{0} voitures", voitures.Count);
            foreach (Voiture voiture in voitures)
            {
                Console.WriteLine("{0} {1} {2}km", voiture.Modele, voiture.Couleur, voiture.Kilometrage);
            }
        }
    }
}
