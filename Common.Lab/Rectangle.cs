namespace Common.Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Rectangle
    {

        const int HAUTEUR_MAX = 30;
        const int LARGEUR_MAX = 79;

        const int HAUTEUR_MIN = 2;
        const int LARGEUR_MIN = 2;

        // Attributs
        int largeur;
        int hauteur;

        // Propriétés pour fournir l'accesseur et le mutateur
        // Chaque attribut se voit associer une propriété pour
        // lui fournir un accesseur et / ou un mutateur
        public int Largeur
        {
            get
            {
                return largeur;
            }
            set
            {
                // rappel : value correspond à la valeur qui se trouve à droite du
                // symbole d'affectation dans le programme client.

                if (value >= LARGEUR_MIN && value <= LARGEUR_MAX)
                {
                    largeur = value;
                }
            }
        }

        public int Hauteur
        {
            get
            {
                return hauteur;
            }
            set   // rappel : si je mets le set 'private', il devient impossible d'affecter
                  // une valeur à la propriété dans le programme client
            {
                if (value >= HAUTEUR_MIN && value <= HAUTEUR_MAX)
                {
                    hauteur = value;
                }
            }
        }

        public String Afficher()
        {
            // Note : lorsqu'une propriété existe, on préfère accéder à la valeur de l'attribut via la propriété associée
            return "La largeur est de " + Largeur + " et la hauteur de " + Hauteur;
        }

        // mutateur ("setter") : méthode qui permet de modifier un attribut forme traditionnelle
        public void SetLargeur(int uneLargeur)
        {
            if (uneLargeur >= LARGEUR_MIN && uneLargeur <= LARGEUR_MAX)
            {
                largeur = uneLargeur;
            }
        }

        // accesseur ("getter") : méthode qui permet d'obtenir la valeur d'un attribut
        public int GetLargeur()
        {
            return largeur;
        }
    }
}
