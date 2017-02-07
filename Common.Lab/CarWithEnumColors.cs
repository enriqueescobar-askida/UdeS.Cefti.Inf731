namespace Common.Lab
{
    using System;

    public class CarWithEnumColors
    {
        public string Immatriculation { get; set; }

        public EnumColors Couleur { get; set; }

        public int Kilometrage
        {
            get
            {
                return kilometrage_;
            }
            private set
            {
                if (value > 0)
                {
                    kilometrage_ = value;
                }
            }
        }

        public string Marque { get; set; }

        public string ParcourirDistance(int kilometresParcouru)
        {
            string s = String.Empty;

            if (kilometresParcouru > 0)
            {
                s = String.Format("La voiture {0} parcourt {1}km", this.Immatriculation, kilometresParcouru);
                this.Kilometrage = this.Kilometrage + kilometresParcouru;
            }

            return s;
        }

        private int kilometrage_;
    }
}
