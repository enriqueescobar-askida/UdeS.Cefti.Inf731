namespace Common.Lab
{
    using System;
    using System.Collections.Generic;

    public class PizzaFactory
    {
        // Dictionnaire qui établit un lien entre les noms des choix de
        // pizza et la procédure d'instanciation programmée à l'aide 
        // d'une lambda. Notez que c'est une propriété privée pour 
        // ne pas briser l'encapsulation
        public Dictionary<string, Func<AbstractPizza>> Dictionnaire { get; internal set; }
        public PizzaFactory()
        {
            Dictionnaire = new Dictionary<string, Func<AbstractPizza>>()
            {
                { "Pizza Napolitaine", () => new TomatoPizza() },
                //{ "Pizza aux Anchois extraordinaire", () => new PizzaAuxAnchois()},
                { "Pizza All Dressed", () => new AllDressPizza()},
                //{ "Pizza Végétarienne", () => new PizzaVégé()},
                { "Pizza Viande Extreme", () => new ExtremePizza()},
                { "Pizza Hawaienne", () => new HawaianPizza()}
                // on doit ajouter ici une nouvelle entrée si on ajoute une classe 
                // à la hiérarchie mais le programme client n'a pas à être
                // modifié, ce qui permet le découplage entre le programme
                // client et la hiérarchie de classes concrètes.
            };
        }
        public AbstractPizza Instancier(string nom)
        {
            AbstractPizza p = this.Dictionnaire[nom]();
            return p;
            //ou plus généralement (puisqu'on laisse le compilateur
            //déterminer le type de ce qui est créé) :
            //
            //var factory = Dictionnaire[nom];
            //return factory();
        }

        public IEnumerable<string> ListeDesPizzas
        {
            get
            {
                return Dictionnaire.Keys;
            }
        }
    }
}