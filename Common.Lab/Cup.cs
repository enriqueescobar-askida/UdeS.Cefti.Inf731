namespace Common.Lab
{
    public class Cup
    {
        static int maxCapacity;

        int NbofMl;

        public string Couleur { get; set; }

        public static int MaxCapacity { get { return maxCapacity; } set { maxCapacity = value; } }

        public int NbMl
        {
            get { return this.NbofMl; }
            private set
            {
                if (value  >= 0) NbofMl = value;
            }
        }

        public override string ToString()
        {
            return "Cette tasse contient " + this.NbofMl + " ml";
        }

        /// <summary>
        /// Il est à noter que la classe s'interposant entre le programme client et l'attribut,
        /// elle peut alors s'assurer de garder l'instance dans un état valide.
        /// Par exemple, ici, on refuse une valeur négative parce qu'il n'est pas normal d'avoir un volume négatif dans une tasse
        /// </summary>
        /// <param name="nombreDeMl">todo: describe nombreDeMl parameter on Initialiser</param>
        public void Initialiser(int nombreDeMl)
        {
            if (nombreDeMl >= 0)
            {
                this.NbofMl = nombreDeMl;
            }
            if (this.NbofMl > maxCapacity)
            {
                maxCapacity = this.NbofMl;
            }
        }
    }
}
