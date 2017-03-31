namespace Week7.Lab
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Common.Lab;

    class Program
    {
        const int NB_CASES = 20;
        const string CHEMIN = "../../";

        const int MAX = 1000;
        static void Main(string[] args)
        {
            float[] tableau = RemplirTableau();
            EcrireTableau(tableau);
            TableauWriter();
            Studentider();
            Personifier();
        }

        private static void Personifier()
        {
            List<Person> liste = new List<Person>
                                     {
                                         new Person("Hector", 76),
                                         new Person("Grégoire", 56),
                                         new Person("Marie-Eve", 3),
                                         new Person("Andréanne", 23),
                                         new Person("Elphège", 95),
                                         new Person("Jacqueline", 9),
                                         new Person("Guy", 45),
                                         new Person("Denis", 63)
                                     };
            liste.Sort();
            PrintPersonList(liste);
            Console.WriteLine("-----------------------------------------");

            List<Person> travailleurs = liste.FindAll(item => item.IsActive);
            PrintPersonList(travailleurs);
        }
        static void PrintPersonList(List<Person> uneListe)
        {
            for (int i = 0; i < uneListe.Count; ++i)
                Console.WriteLine("{0} {1}", uneListe[i].Name.PadRight(15), uneListe[i].Age.ToString().PadLeft(2));
            Console.In.ReadLine();
        }

        private static void Studentider()
        {
            Student s = new Student("Marc");
            s.AddMark(90);
            s.AddMark(91);
            s.AddMark(92);
            s.AddMark(93);
            s.AddMark(94);
            s.AddMark(95);
            s.AddMark(96);
            s.AddMark(97);
            s.AddMark(98);
            s.AddMark(99);
            s.AddMark(89);
            s.AddMark(88);
            Console.WriteLine("La somme des notes : {0}", s.MarkSum());
        }

        private static void TableauWriter()
        {
            Console.Write("Donnez le nom du fichier : ");
            String nomFichier = Console.ReadLine();
            StreamWriter fichierSortie = new StreamWriter(CHEMIN + nomFichier);

            if (File.Exists(CHEMIN + nomFichier))
            {
                for(int i = 0; i < MAX; ++i)
                    fichierSortie.WriteLine(i);

                fichierSortie.Close();  // vide le buffer vers le disque
            }
            else
            {
                Console.WriteLine("Le fichier n'a pas pu être créé");
            }
        }

        private static float[] RemplirTableau()
        {
            Random g = new Random();
            float[] nouveau = new float[NB_CASES];

            for (int i = 0; i < nouveau.Length; ++i)
                nouveau[i] = g.Next() % 10001 / 1000.0f; // nouveau[i] = g.Next(0, MAX + 1);

            return nouveau;
        }

        private static void EcrireTableau(float[] tableau)
        {
            Console.Write("Donnez le nom du fichier où écrire le tableau : ");
            String nomFichier = Console.ReadLine();

            StreamWriter fichierSortie = new StreamWriter(CHEMIN + nomFichier);
            fichierSortie.WriteLine("Voici les nombres tirés au hasard");
            fichierSortie.WriteLine();
            fichierSortie.WriteLine();

            foreach (float t in tableau) fichierSortie.WriteLine("{0:f3}", t);

            fichierSortie.Close();
        }
    }
}
