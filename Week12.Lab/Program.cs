namespace Week12.Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.Lab;
    class Program
    {
        static readonly Func<int, bool> PlusGrandQue20 =
            delegate (int valeur) { return valeur > 20; };

        static void Main(string[] args)
        {
            //First();
            //Delegating();
            //DeletageMore();
            //Delegation();
            //Redelegation();
            Redelegating();
            Console.In.ReadLine();
            Animalia();
        }

        private static void Animalia()
        {
            List<Animal> lesAnimaux = new List<Animal>();
            lesAnimaux.Add(new Swan(125));
            lesAnimaux.Add(new Ostrich(80500));
            lesAnimaux.Add(new Mosquito(1));

            List<IFly> listeVolants = lesAnimaux.OfType<IFly>().ToList();
            foreach (IFly v in listeVolants)
                v.Decoller();

            lesAnimaux.Sort();
            Console.WriteLine();
            foreach (Animal a in lesAnimaux)
            {
                Console.Write(a.ToString() + " a un poids de ");
                Console.WriteLine(a.Weight);
            }
        }

        private static void Redelegating()
        {
            Random g = new Random(15);  // pour avoir la même liste à chaque exécution
            List<Person> liste = GenerateRandomPersons(g);
            Afficher(liste);
            double moyenne = liste.Average(p => p.Age);
            double moyenneEncore = liste.Select(p => p.Age).Average();
            double moyenneAinés = liste.Select(p => p.Age).Where(age => age >= 65).Average();
            Console.WriteLine("Moyenne générale \t\t{0:f1}", moyenne);
            Console.WriteLine("Moyenne générale calculée par Select  \t\t{0:f1}", moyenneEncore);
            Console.WriteLine("Moyenne des gens qui ont l'âge de la retraite  \t\t{0:f1}", moyenneAinés);
            /*IEnumerable<Person> listeParNom = liste.OrderBy(p => p.Name.ToList());
            Afficher(listeParNom);*/
            IOrderedEnumerable<Person> listeParAge = liste.OrderBy(p => p.Age).ThenBy(p => p.Name);
            Afficher(listeParAge);
        }
        private static List<Person> GenerateRandomPersons(Random g)
        {
            const int Min = 0;
            const int Max = 127;
            List<Person> liste = new List<Person>();
            liste.Add(new Person("Luc", g.Next(Min, Max + 1)));
            liste.Add(new Person("Paul", g.Next(Min, Max + 1)));
            liste.Add(new Person("Guy", g.Next(Min, Max + 1)));
            liste.Add(new Person("Anne", g.Next(Min, Max + 1)));
            liste.Add(new Person("Jean", g.Next(Min, Max + 1)));
            liste.Add(new Person("Marc", g.Next(Min, Max + 1)));
            liste.Add(new Person("Bob", g.Next(Min, Max + 1)));
            liste.Add(new Person("John", g.Next(Min, Max + 1)));
            liste.Add(new Person("Fred", g.Next(Min, Max + 1)));
            liste.Add(new Person("Q", g.Next(Min, Max + 1)));
            liste.Add(new Person("Ella", 123));
            liste.Add(new Person("Edward", 123));
            return liste;
        }
        private static List<int> PeuplerListe(Random random)
        {
            const int Min = 0;
            const int Max = 100;
            const int NbValeurs = 15;
            List<int> liste = new List<int>();
            for (int i = 0; i < NbValeurs; ++i)
            {
                liste.Add(random.Next(Min, Max + 1));
            }
            return liste;
        }
        private static void Redelegation()
        {
            Random g = new Random();
            List<int> liste = PeuplerListe(g);
            liste.ForEach(Console.WriteLine);
        }
        private static void Delegation()
        {
            Random g = new Random();
            List<int> liste = PeuplerListe(g);
            Afficher(liste);
            int valeurTrouvée = liste.FindIndex(EstNoteDansDizaine);
            Console.WriteLine();
            Console.WriteLine("L'indice de la première valeur dans la dizaine est : {0}", valeurTrouvée);
            List<int> listeNouvelle = liste.FindAll(EstNoteFaible);
            Afficher(listeNouvelle);
        }
        private static bool EstNoteFaible(int obj)
        {
            return obj <= 50;
        }
        private static bool EstNoteDansDizaine(int valeur)
        {
            return valeur >= 10 && valeur < 20;
        }
        static void First()
        {
            List<Animal> animals = new List<Animal> { new Ostrich(80500), new Swan(125), new Mosquito(1) };
            animals.Sort();
            Console.WriteLine();
            foreach (Animal a in animals)
            {
                Console.Write(a + " a un poids de ");
                Console.WriteLine(a.Weight);
            }

            List<IFly> flyerList = animals.OfType<IFly>().ToList();
            foreach (IFly v in flyerList)
                v.Decoller();
        }
        static void Delegating()
        {
            int[] t = { 10, 90, 22, 56, 57, 78, 79, 97, 65, 43, 21, 12, 60, 100 };
            List<int> liste = new List<int>(t);
            Afficher(liste);
            liste = liste.FindAll(EstInferieurA60);
            Afficher(liste);
            // à l'aide d'un délégué anonyme : 
            Console.WriteLine(
                liste.All(
                    delegate (int valeur) { return valeur >= 10; }
                )
            );
            // à l'aide d'un délégué Func déclaré plus haut 
            Console.WriteLine(liste.Count(PlusGrandQue20));
            // à l'aide d'un délégué anonyme : 
            int limite = 20;
            Console.WriteLine(
                liste.Count(
                    delegate (int valeur) { return valeur > limite; }
                )
            );
            // à l'aide d'une lambda : 
            Console.WriteLine(liste.Count(valeur => valeur > limite));
            liste = new List<int>(t);
            List<int> plusGrands = liste.Where(x => x >= 60).ToList();
            Afficher(plusGrands);
        }
        static void DeletageMore()
        {
            Random r = new Random();
            List<double> liste = new List<double>();
            for (int i = 0; i < 30; ++i)
                liste.Add(r.Next(0, 131));
            Afficher(liste);
            double valeur = liste.Find(EstPlusGrandQue100);
            Console.WriteLine("Première valeur trouvée : {0}", valeur);
            List<double> lesPlusGrands = liste.FindAll(EstPlusGrandQue100);
            Afficher(lesPlusGrands);
        }
        static void Afficher<T>(List<T> liste)
        {
            foreach (T nombre in liste)
                Console.Write("{0}, ", nombre);
            Console.WriteLine();
            Console.WriteLine(new string('-', 60));
        }
        static bool EstInferieurA60(int valeur)
        {
            return valeur < 60;
        }
        static bool EstPlusGrandQue100(double valeur)
        {
            return valeur > 100;
        }
        static void Afficher(IEnumerable<Person> liste)
        {
            foreach (Person p in liste)
                Console.WriteLine(p);
            Console.WriteLine();
        }
    }
}
