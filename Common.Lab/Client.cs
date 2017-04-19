namespace Common.Lab
{
    using System;
    using System.Collections.Generic;

    public class Client : IObservable
    {
        public string Name { get; private set; }

        Dictionary<Actio, int> ActionList { get; set; }

        public Client(string nom)
        {
            this.Name = nom;
            this.ActionList = new Dictionary<Actio, int>();
        }

        public void Ajouter(Actio actions, int nombre)
        {
            actions.AjouterObservateur(this);
            this.ActionList.Add(actions, nombre);

        }

        public void MettreAJour()
        {
            string str = String.Format("Portefeuille de " + this.Name);
            str += "\n" + new string('-', 72);
            foreach (KeyValuePair<Actio, int> s in this.ActionList)
            {
                str += s.Key;
                str += string.Format(" ==> {0} actions", s.Value);
            }
        }
    }
}