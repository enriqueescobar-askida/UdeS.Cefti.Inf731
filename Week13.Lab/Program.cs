namespace Week13.Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.Lab;

    class Program
    {
        const int NoteDePassage = 60;

        private static readonly Func<int, bool> PlusGrandQue20 = delegate (int valeur) { return valeur > 20; };

        static void Main(string[] args)
        {
            DelegateThree();
            DelegateTwo();
            DelegateOne();
            Predecator();
        }

        private static void DelegateThree()
        {
            Random random = new Random(15);  // pour avoir la même liste à chaque exécution
            List<Person> liste = PeuplerListe(random, 0, 127);
            Afficher(liste);
            // Je veux faire la moyenne de leur age...
            double moyenne = liste.Average(p => p.Age);
            Console.WriteLine("Moyenne générale \t\t{0:f1}", moyenne);
            Console.ReadKey();
            double moyenneEncore = liste.Select(p => p.Age).Average();
            double moyenneAinés = liste.Select(p => p.Age).Where(a => a >= 65).Average();
            // Trouver la personne qui a 123 ans : 
            Person lui = liste.Find(p => p.Age == 5);
            if (lui != null) Console.WriteLine(lui);
            else Console.WriteLine("Pas trouvé");
            //Console.Write("Le type qui a 123 ans : ");
            Console.ReadKey();
            Console.WriteLine("Moyenne générale calculée par Select  \t\t{0:f1}", moyenneEncore);
            Console.WriteLine("Moyenne des gens qui ont l'âge de la retraite  \t\t{0:f1}", moyenneAinés);
            IEnumerable<Person> listeParNom = liste.OrderBy(p => p.FamilyName).ToList();
            Afficher(listeParNom);
            IOrderedEnumerable<Person> listeParAge = liste.OrderBy(p => p.Age).ThenBy(p => p.FamilyName);
            Afficher(listeParAge);
        }

        private static void DelegateTwo()
        {
            const int NoteMax = 100;
            Random random = new Random();
            List<int> liste = PeuplerListe(random, 100);
            Afficher(liste);
            for (int i = 0; i < 10; ++i)
            {
                int min = i * 10;
                int max = (i + 1) * 10;
                if (max == NoteMax) ++max;
                // On peut écrire dans la clause Where une fonction anonyme déléguée qui peut
                // utiliser les variables locales de la boucle (alors qu'une fonction traditionnelle
                // ne le pourrait pas)
                //List<int> listeIntervalle = liste.FindAll(delegate(int val)
                //                            {
                //                                return val >= min && val < max;
                //                            });
                List<int> listeLambda = liste.FindAll(v => v >= min && v < max);
                Afficher(listeLambda);
            }
            List<int> listeBonnesNotes = liste.Where(x => x > 70).ToList();
            foreach (var valeur in listeBonnesNotes)
                Console.WriteLine(valeur);
        }

        private static void DelegateOne()
        {
            Random gRandom = new Random();
            List<int> liste = PeuplerListe(gRandom);
            Afficher(liste);
            int valeurTrouvée = liste.FindIndex(EstNoteDansDizaine);
            Console.WriteLine();
            Console.WriteLine("L'indice de la première valeur dans la dizaine est : {0}", valeurTrouvée);
            List<int> listeNouvelle = liste.FindAll(EstNoteFaible);
            Afficher(listeNouvelle);
        }

        private static void Predecator()
        {
            int[] t = { 10, 90, 22, 56, 57, 78, 79, 97, 65, 43, 21, 12, 60, 100 };
            List<int> liste = new List<int>(t);
            Afficher(liste);
            int laValeur = liste.Find(EstUnEchec);
            int indice = liste.FindIndex(EstUnEchec);
            Console.WriteLine("À la position {0} se trouve la valeur {1}", indice, laValeur);
            Console.ReadKey();
            liste = liste.FindAll(EstInferieurA60);
            Afficher(liste);
            // à l'aide d'un délégué anonyme : 
            //Console.WriteLine(
            //    liste.All(delegate(int valeur) 
            //              { return valeur >= 10; })
            //    );
            // à l'aide d'un délégué Func déclaré plus haut 
            Console.WriteLine(liste.Count(PlusGrandQue20));
            // à l'aide d'un délégué anonyme : 
            int limite = 20;
            //Console.WriteLine(liste.Count(delegate(int valeur)
            //                             { return valeur > limite; })//                  );
            // à l'aide d'une lambda : 
            Console.WriteLine(liste.Count(valeur => valeur > limite));
            liste = new List<int>(t);
            List<int> plusGrands = liste.Where(x => x >= 60).ToList();
            Afficher(plusGrands);
        }

        static bool EstUnEchec(int note)
        {
            return note < NoteDePassage;
        }
        static bool EstInferieurA60(int valeur)
        {
            return valeur < 60;
        }
        static bool EstNoteFaible(int valeur)
        {
            return valeur <= 50;
        }
        static bool EstNoteDansDizaine(int valeur)
        {
            return valeur >= 10 && valeur < 20;
        }
        static void Afficher<T>(List<T> liste)
        {
            foreach (T nombre in liste)
                Console.Write("{0}, ", nombre);
            Console.WriteLine();
            Console.WriteLine(new string('-', 60));
        }
        static void Afficher(List<int> liste)
        {
            foreach (int i in liste)
                Console.Write("{0}, ", i);
            Console.WriteLine();
        }
        static void Afficher(IEnumerable<int> liste)
        {
            foreach (int i in liste)
                Console.Write("{0}, ", i);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();
        }
        static void Afficher(IEnumerable<Person> liste)
        {
            foreach (Person p in liste)
                Console.WriteLine(p);
            Console.WriteLine();
        }
        static List<int> PeuplerListe(Random random)
        {
            const int Min = 0;
            const int Max = 100;
            const int NbValeurs = 15;
            List<int> liste = new List<int>();
            for (int i = 0; i < NbValeurs; ++i)
                liste.Add(random.Next(Min, Max + 1));
            
            return liste;
        }
        static List<int> PeuplerListe(Random random, int nbValues = 100)
        {
            if (nbValues <= 0) throw new ArgumentOutOfRangeException(nameof(nbValues));
            const int Min = 0;
            const int Max = 100;
            List<int> liste = new List<int>();

            for (int i = 0; i < nbValues; ++i)
                liste.Add(random.Next(Min, Max + 1));
            
            return liste;
        }
        static List<Person> PeuplerListe(Random random, int Min = 0, int Max = 127)
        {
            List<Person> liste = new List<Person>
                                     {
                                         new Person("Luc", random.Next(Min, Max + 1)),
                                         new Person("Paul", random.Next(Min, Max + 1)),
                                         new Person("Guy", random.Next(Min, Max + 1)),
                                         new Person("Anne", random.Next(Min, Max + 1)),
                                         new Person("Jean", random.Next(Min, Max + 1)),
                                         new Person("Marc", random.Next(Min, Max + 1)),
                                         new Person("Bob", random.Next(Min, Max + 1)),
                                         new Person("John", random.Next(Min, Max + 1)),
                                         new Person("Fred", random.Next(Min, Max + 1)),
                                         new Person("Q", random.Next(Min, Max + 1)),
                                         new Person("Ella", 123),
                                         new Person("Edward", 123)
                                     };

            return liste;
        }
    }
}
