namespace Common.Lab
{
    using System;
    class HauteurInvalideException : ArgumentException { }
    class LargeurInvalideException : ArgumentException { }

    public abstract class Shape2D : Shape
    {
        private const int LargeurMax = 40;
        private const int HauteurMax = 20;
        private int hauteur;
        public int Hauteur
        {
            get { return this.hauteur; }
            private set
            {
                if (value <= 0 || value > HauteurMax)
                {
                    throw new HauteurInvalideException();
                }
                this.hauteur = value;
            }
        }
        private int largeur;
        public int Largeur
        {
            get { return this.largeur; }
            private set
            {
                if (value <= 0 || value > LargeurMax)
                {
                    throw new LargeurInvalideException();
                }
                this.largeur = value;
            }
        }
        public abstract int Aire
        {
            get;
        }

        protected Shape2D(char valSymbole, int valLargeur, int valHauteur)
        : base(valSymbole)
        {
            this.Largeur = valLargeur;
            this.Hauteur = valHauteur;
        }
    }
}