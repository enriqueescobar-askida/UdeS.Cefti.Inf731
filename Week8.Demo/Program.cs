namespace Week8.Demo
{
    using System;
    using System.Collections.Generic;

    using Common.Lab;
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> voitures = LireVoitures();
            EcrireVoitures(voitures);
        }

        static List<Car> LireVoitures()
        {
            List<Car> voitures = new List<Car>();
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

                        Car nouvelleVoiture = new Car(modele, kilometrage, couleur);
                        voitures.Add(nouvelleVoiture);
                    }
                }
                catch (InvalidColorException ex)
                {
                    Console.WriteLine("Couleur invalide!\n" + ex.Message);
                }
                catch (InvalidModelException ex)
                {
                    Console.WriteLine("Modele invalide!\n" + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur lors de la création de la voiture: {0}", ex.Message);
                }
            }

            return voitures;
        }

        static void EcrireVoitures(List<Car> voitures)
        {
            Console.WriteLine("{0} voitures", voitures.Count);
            foreach (Car voiture in voitures)
            {
                Console.WriteLine("{0} {1} {2}km", voiture.Modele, voiture.Couleur, voiture.Kilometrage);
            }
        }
    }
}
