namespace Week3.Lab1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Common.Lab;
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            //Rectangle deuxiemeRectangle = new Rectangle();

            rectangle.Largeur = 29;
            rectangle.Hauteur = -5;  // que la propriété devrait rejeter
                                     // si elle fait correctement son travail

            Console.WriteLine("La largeur du rectangle est {0}", rectangle.Largeur);
            Console.WriteLine("La hauteur du rectangle est {0}", rectangle.Hauteur);

            // petit aparté sur les objets immuables; il faut créer un nouvel
            // objet pour remplacer l'objet existant.
            string chaine = "Bonjour la police !";
            chaine = chaine.Substring(0, 2) + "w" + chaine.Substring(3);
            Console.WriteLine(chaine);
        }
    }
}
