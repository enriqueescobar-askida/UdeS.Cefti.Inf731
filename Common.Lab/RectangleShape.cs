namespace Common.Lab
{
    using System;

    public class RectangleShape : Shape2D
    {
        private const char SymboleRectangleParDefaut = '*';
        public RectangleShape(int valLargeur, int valHauteur)
            : base(SymboleRectangleParDefaut, valLargeur, valHauteur)
        {
        }
        public RectangleShape(char valSymbole, int valLargeur, int valHauteur)
            : base(valSymbole, valLargeur, valHauteur)
        {
        }

        public override string ToString()
        {
            string s = String.Empty;
            for (int i = 0; i < this.Hauteur; ++i)
            {
                for (int j = 0; j < this.Largeur; ++j)
                    s += this.Symbole;

                s += "\n";
            }
            return s;
        }

        public override int Aire => this.Hauteur * this.Largeur;
    }
}