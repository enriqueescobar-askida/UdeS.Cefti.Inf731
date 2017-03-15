using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Demo
{
    class Program
    {
        const char SEPARATEUR = ' ';

        static void Main(string[] args)
        {
            string premierMot = "Allo";
            string deuxiemeMot = "les";
            string troisemeMot = "amis";

            string chaine = premierMot + " " + deuxiemeMot + " " + troisemeMot;
            Console.WriteLine("Chaine = \"{0}\"", chaine);

            string[] mots = chaine.Split(SEPARATEUR);
            Console.WriteLine("La chaine comprend {0} mots:", mots.Length);
            for (int idx = 0; idx < mots.Length; ++idx)
            {
                string mot = mots[idx];
                Console.WriteLine("{0} -> \"{1}\"", idx + 1, mot);
            }

            Console.WriteLine("La chaine comprend {0} caractères:", chaine.Length);
            for (int idx = 0; idx < chaine.Length; ++idx)
            {
                char caractère = chaine[idx];
                Console.WriteLine("{0} -> '{1}'", idx, caractère);
            }
        }
    }
}
