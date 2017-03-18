namespace Week9.Lab
{
    using System;
    using System.Collections.Generic;

    using Common.Lab;

    class Program
    {
        static void Main(string[] args)
        {
            InheritPart1();
            InheritPart2();
        }

        private static void InheritPart2()
        {
            List<Person> liste = new List<Person>();

            Student nouveau = new Student("Paul", "Hervieux", "HERP23232323", 19340);
            liste.Add(nouveau);

            Teacher nouvelEnseignant = new Teacher("Hisson", "Paul", "123123123", 123, "Informatique");
            liste.Add(nouvelEnseignant);
            liste.Add(new Person("Holmes", "Sherlock"));

            // Notez la simplification de ce code : même si toutes les références sont 
            // conservées dans une liste de 'Personne' et qu'on demande à chaque 'Personne' 
            // de s'afficher, la méthode Afficher de la classe Etudiant sera exécutée si le véritable type de la référence est un Etudiant. 
            // Ceci se fera en appliquant l'idée du polymorphisme qui consiste à  appeler la méthode la plus appropriée au véritable type de l'objet.
            foreach (Person p in liste)
                Console.Out.WriteLine(p);
            Console.ReadLine();
        }

        private static void InheritPart1()
        {
            // Notons qu'on déclare une liste de références sur la classe Person
            List<Person> liste = new List<Person>();

            // et on peut fort bien y ajouter une instance d'étudiant puisqu'un étudiant, par héritage, "est une" Person
            Student nouveau = new Student("Paul", "Hervieux", "HERP23232323", 19340);
            liste.Add(nouveau);

            // et on peut tous aussi bien y ajouter une instance d'Teacher pour les mêmes raisons : un Teacher, par héritage, "est une" Person
            Teacher nouvelTeacher = new Teacher("Hisson", "Paul", "123123123", 123, "Informatique");
            liste.Add(nouvelTeacher);

            // Cette approche fonctionne (au sens qu'elle donne le résultat attendu) mais
            // elle est très mauvais puisque l'ajout d'une classe dans la hiérarchie ferait
            // en sorte qu'il faille modifier aussi le programme client. C'est très mauvais, même si ça produit le résultat
            foreach (Person p in liste)
            {
                // Notez qu'on peut connaître le type véritable de la référence p en utilisant le mot clé 'is'
                if (p is Student)
                {
                    // et on peut retyper la référence p en utilisant le mot clé 'as'. on aurait aussi pu faire ((Student)p).Afficher(); 
                    (p as Student).ToString();
                }
                else
                {
                    if (p is Teacher)
                    {
                        (p as Teacher).ToString();
                    }
                    else
                    {
                        p.ToString();
                    }
                }
            }
        }
    }
}
