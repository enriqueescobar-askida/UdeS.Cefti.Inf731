namespace Common.Lab
{
    using System;

    public class Rectangle
    {
        const int HauteurMax = 30;
        const int LargeurMax = 79;
        const int HauteurMin = 2;
        const int LargeurMin = 2;
        
        int largeur;
        int hauteur;
        public int Largeur
        {
            get
            {
                return this.largeur;
            }
            set
            {
                if (value >= LargeurMin && value <= LargeurMax)
                {
                    this.largeur = value;
                }
                else
                {
                    if (this.largeur == 0)
                    {
                        this.largeur = LargeurMin;
                    }
                }
            }
        }

        public int Hauteur
        {
            get
            {
                return this.hauteur;
            }
            set
            {
                if (value >= HauteurMin && value <= HauteurMax)
                {
                    this.hauteur = value;
                }
                else
                {
                    if (this.hauteur == 0)
                    {
                        this.hauteur = HauteurMin;
                    }
                }
            }
        }

        public Rectangle(Rectangle original)
        {
            this.Largeur = original.Largeur;
            this.Hauteur = original.Hauteur;
        }
        public Rectangle(int largeur = LargeurMin, int hauteur = HauteurMin)
        {
            this.Largeur = largeur;
            this.Hauteur = hauteur;
        }

        public String Afficher()
        {
            return "La largeur est de " + this.Largeur + " et la hauteur de " + this.Hauteur;
        }
        public static int AireMaximale()
        {
            return LargeurMax * HauteurMax;
        }
        
        public void SetLargeur(int uneLargeur)
        {
            if (uneLargeur >= LargeurMin && uneLargeur <= LargeurMax)
            {
                this.largeur = uneLargeur;
            }
        }
        
        public int GetLargeur()
        {
            return this.largeur;
        }
    }
}
