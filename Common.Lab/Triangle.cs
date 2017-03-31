namespace Common.Lab
{
    using System;

    public class Triangle : Shape2D
    {
        private const char SymboleTriangleParDefaut = '#';
        public Triangle(int valLargeur, int valHauteur)
        : base(SymboleTriangleParDefaut, valLargeur, valHauteur)
        {
        }

        public Triangle(char valSymbole, int valLargeur, int valHauteur)
        : base(valSymbole, valLargeur, valHauteur)
        {
        }
        public override int Aire => this.Hauteur * this.Largeur / 2;

        public override string ToString()
        {
            string s = String.Empty;
            for (int ligne = 0; ligne < this.Hauteur; ++ligne)
            {
                int nbSymboles = (int)Math.Floor((float)this.Largeur / this.Hauteur * (ligne + 1));

                // identique à 
                if (nbSymboles == 0)
                {
                    nbSymboles = 1;
                }

                for (int j = 0; j < nbSymboles; ++j)
                    s += this.Symbole;

                s += "\n";
            }
            return s;
        }

    }
}
