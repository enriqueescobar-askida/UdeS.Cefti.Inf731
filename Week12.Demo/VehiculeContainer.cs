namespace Week12.Demo
{
    using System.Collections.Generic;

    public class VehiculeContainer
    {
        public List<Vehicule> Vehicules { get; internal set; }

        public int Count { get; internal set; }

        public VehiculeContainer(List<Vehicule> vehicules)
        {
            this.Vehicules = vehicules;
        }

        public VehiculeContainer()
        {
        }

        public Vehicule this[int index]
        {
            get
            {
                // Voiture demandé à l'index
                Vehicule vehiculeDesire = this.Vehicules[index];

                // Copie de la voiture demandé (pour respecter l'encapsulation)
                // Puisque Clone() retourne une valeur de type Object, il est 
                // nécessaire de caster cette valeur en Vehicule avec "as Vehicule"
                Vehicule clone = vehiculeDesire.Clone() as Vehicule;

                // Retourner la copie
                return clone;
            }
        }

        public void Add(Vehicule vehicule)
        {
            this.Vehicules.Add(vehicule);
        }
    }
}