namespace Common.Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Cup
    {
        int nbMl;

        public string Couleur { get; set; }

        public override string ToString()
        {
            return "Cette tasse contient " + nbMl + " ml";
        }

        /// <summary>
        /// Il est à noter que la classe s'interposant entre le programme client et l'attribut,
        /// elle peut alors s'assurer de garder l'instance dans un état valide.
        /// Par exemple, ici, on refuse une valeur négative parce qu'il n'est pas normal d'avoir un volume négatif dans une tasse
        /// </summary>
        /// <param name="valeur">le nombre de ml à mettre dans la tasse</param>
        public void Initialiser(int nombreDeMl)
        {
            if (nombreDeMl >= 0)
            {
                nbMl = nombreDeMl;
            }
        }
    }
}
