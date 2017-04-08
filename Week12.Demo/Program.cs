namespace Week12.Demo
{
    using System;

    class Program
    {
        static void Main(string[] args)
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
    }
}
