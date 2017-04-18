namespace Week12.Demo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.Lab;

    class Program
    {
        static void Main(string[] args)
        {
            Twelve();
            Thirteen();
            Tempo();
        }

        private static void Tempo()
        {
            List<Temperature> listeTemperatures = new List<Temperature>();
            Random aléatoire = new Random();

            // Chargement de la liste par des valeurs aléatoires
            for (int i = 0; i < 10; i++)
            {
                Temperature températureLocale = new Temperature(aléatoire.Next(-100, 100));
                listeTemperatures.Add(températureLocale);
            }

            // On affiche la liste initiale
            AfficherListeTempérature(listeTemperatures);
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
            // Tri de la liste 
            listeTemperatures.Sort();

            // On affiche la liste triée
            AfficherListeTempérature(listeTemperatures);
        }

        private static void AfficherListeTempérature(List<Temperature> listeTemperatures)
        {
            foreach (Temperature temp in listeTemperatures)
                Console.WriteLine("Celsius:{0,4}  ---Fahrenheit: {1,6}", temp.Celsius, temp.Fahrenheit);
        }

        private static void Twelve()
        {
            VehiculeContainer conteneur = new VehiculeContainer();
            conteneur.Add(new Rocket());
            conteneur.Add(new Car());
            conteneur.Add(new Plane());

            for (int index = 0; index < conteneur.Count; ++index)
            {
                Vehicule vehicule = conteneur[index];
                Console.WriteLine(vehicule.ToString());
            }
        }

        private static void Thirteen()
        {

            List<string> chaines = new List<string>();
            chaines.Add("Bonjour");
            chaines.Add("les");
            chaines.Add("amis");
            chaines.Add("Ceci");
            chaines.Add("est");
            chaines.Add("un");
            chaines.Add("exemple");
            Console.Write("Entrer taille des chaines desirées: ");
            int tailleDesiree = int.Parse(Console.ReadLine());
            List<string> chainesFiltrees;
            // Delege en syntaxe fonction
            Console.WriteLine("Filtrage avec fonction (taille fixe >= 4)");
            chainesFiltrees = chaines
                .Where(estPlusLongQue3)
                .ToList();
            Afficher(chainesFiltrees);
            // Delegate en syntaxe lambda
            Console.WriteLine("Filtrage avec syntaxe 'delegate'");
            chainesFiltrees = chaines
                .Where(
                    delegate (string chaine)
                    {
                        return chaine.Length >= tailleDesiree;
                    }
                )
                .ToList();
            Afficher(chainesFiltrees);
            //Façon syntaxe lambda
            Console.WriteLine("Filtrage avec syntaxe 'lambda'");
            chainesFiltrees = chaines
                .Where(chaine => chaine.Length >= tailleDesiree)
                //.Where(chaine => chaine.Contains('a'))
                .ToList();
            Afficher(chainesFiltrees);
        }
        static bool estPlusLongQue3(string chaine)
        {
            return chaine.Length >= 4;
        }

        static void Afficher(List<string> chaines)
        {
            foreach (string chaine in chaines)
                Console.WriteLine(chaine);
        }
    }
}
