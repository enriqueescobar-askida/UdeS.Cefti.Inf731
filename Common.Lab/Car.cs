namespace Common.Lab
{
    using System;

    public class Car
    {
        public string Immatriculation { get; set; }

        public string Couleur
        {
            get
            {
                return this.couleur;
            }
            set
            {
                if (value.ToLower() == "rouge"
                    || value.ToLower() == "bleu"
                    || value.ToLower() == "vert"
                    || value.ToLower() == "jaune"
                    || value.ToLower() == "noir"
                    || value.ToLower() == "blanc")
                {
                    this.couleur = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string Marque { get; set; }
        public string Modele { get; set; }

        public int Kilometrage
        {
            get
            {
                return this.kilometrage;
            }
            set
            {
                if (value > 0)
                {
                    this.kilometrage = value;
                }
                throw new ArgumentException();
            }
        }

        //Attributes
        private int kilometrage;

        public Car()
        {
            this.Marque = String.Empty;
            this.Modele = String.Empty;
            this.Kilometrage = 0;
        }

        public Car(string marque, string modele)
        {
            this.Marque = marque;
            this.Modele = modele;
            this.Kilometrage = 0;
        }

        public Car(string marque, string modele, int kilometrage)
        {
            this.Marque = marque;
            this.Modele = modele;
            this.Kilometrage = kilometrage;
        }
        public Car(string modele, int kilometrage, string couleur)
        {
            this.Modele = modele;
            this.Couleur = couleur;
            this.Kilometrage = kilometrage;
        }

        public Car(Car autreVoiture)
        {
            this.Kilometrage = autreVoiture.Kilometrage;
            this.Marque = autreVoiture.Marque;
            this.Modele = autreVoiture.Modele;
        }

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

        private string couleur;
    }
}
