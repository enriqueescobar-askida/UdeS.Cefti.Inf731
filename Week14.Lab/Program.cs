namespace Week14.Lab
{
    using System;
    using Common.Lab;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            CopyConstructor();
        }

        private static void CopyConstructor()
        {
#pragma warning disable CC0001 // You should use 'var' whenever possible.
            List<Person> liste = new List<Person>();
#pragma warning restore CC0001 // You should use 'var' whenever possible.
            liste.Add(new Person("Einstein", "Albert"));
            liste.Add(new Student("Mercury", "Freddie", "MERF12125501", 34));
            liste.Add(new Student("Obama", "Barack", "OBAB30106201", 55));
            liste.Add(new Person("Trump", "Donald"));
            Console.WriteLine("============================================");
            Console.WriteLine("Voici la liste originale: ");
            AfficherListe(liste);
            //foreach (Person p in liste)
            //{
            //    Afficher(p);
            //    Console.WriteLine("-------------------------------------");
            //}
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Produisons une copie de la liste : ");
            Console.WriteLine();
            List<Person> nouvelleListe = ReproduireListe(liste);
            // observons le problème...
            AfficherListe(nouvelleListe);
            // ceci ne fonctionne pas davantage...
            // var listeActi = ReproduireListeGénérique(liste);
            // AfficherListe(listeActi);
            Console.WriteLine();
            Console.WriteLine("Revoici l'originale : ");
            AfficherListe(liste);
        }

        static List<Person> ReproduireListe(List<Person> listeOriginale)
        {
#pragma warning disable CC0001 // You should use 'var' whenever possible.
            List<Person> listeNouvelle = new List<Person>();
#pragma warning restore CC0001 // You should use 'var' whenever possible.

            foreach (Person p in listeOriginale)
            {
                if (p is Student)
                    listeNouvelle.Add(new Student(p as Student));
                else
                    listeNouvelle.Add(new Person(p));

            }
            return listeNouvelle;
        }
        static void AfficherListe(List<Person> liste)
        {
            foreach (Person p in liste)
                Console.WriteLine(p.Afficher() + "-------------------------------------");
        }
        static List<T> ReproduireListeGénérique<T>(List<T> listeOriginale)
        {
#pragma warning disable CC0001 // You should use 'var' whenever possible.
            List<T> listeNouvelle = new List<T>();
#pragma warning restore CC0001 // You should use 'var' whenever possible.

            foreach (T p in listeOriginale)
            {
                T nouvellePersonne = (T)Activator.CreateInstance(typeof(T), p);
                listeNouvelle.Add(nouvellePersonne);
            }
            return listeNouvelle;
        }
    }
}
