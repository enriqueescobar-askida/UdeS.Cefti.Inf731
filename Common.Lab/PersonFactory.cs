namespace Common.Lab
{
    using System;
    using System.Collections.Generic;

    public class PersonFactory
    {
        // Dictionnaire qui établit un lien entre les noms des choix de pizza et la procédure d'instanciation programmée à l'aide 
        // d'une lambda. Notez que c'est une propriété privée pour  ne pas briser l'encapsulation
        Dictionary<string, Func<string, string, string[], Person>> Dictionnaire { get; set; }

        public PersonFactory()
        {
            this.Dictionnaire = new Dictionary<string, Func<string, string, string[], Person>>()
            {
                { "Personne", (n, m, p) => new Person(n, m) },
                { "Employé",  (n, m, p) => new Employe(n, m, p)},
                { "Étudiant", (n, m, p) => new Student(n, m, p)}
                // on doit ajouter ici une nouvelle entrée si on ajoute une classe 
                // à la hiérarchie mais le programme client n'a pas à être
                // modifié, ce qui permet le découplage entre le programme
                // client et la hiérarchie de classes concrètes.
            };
        }

        public Person Instancier(string nom, string n, string m)
        {
            //Personne p = Dictionnaire[nom](n,m, new string [] {});
            //return p;
            //ou plus généralement (puisqu'on laisse le compilateur
            //déterminer le type de ce qui est créé) :
            //
            Func<string, string, string[], Person> factory = this.Dictionnaire[nom];
            return factory(n, m, new string[] { });
        }

        public Person Instancier(string nom, string n, string m, string[] tableau)
        {
            //Personne p = Dictionnaire[nom](n,m, tableau);
            //return p;
            //ou plus généralement (puisqu'on laisse le compilateur
            //déterminer le type de ce qui est créé) :
            Func<string, string, string[], Person> factory = this.Dictionnaire[nom];
            return factory(n, m, tableau);
        }

        public IEnumerable<string> ListeDesEntités => this.Dictionnaire.Keys;
    }
}