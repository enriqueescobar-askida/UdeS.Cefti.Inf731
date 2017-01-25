namespace Common.Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Employe
    {
        string nom_;
        string prenom_;
        int age_;
        int experience_;

        //--- Note : en fonction de ce que nous apprendrons durant
        //    la séance #3, il conviendrait d'implanter des mutateurs
        //    (set) et des accesseurs (get) pour modifier les attributs
        //    plutôt que d'affecter directement la valeur à l'attribut
        //    comme nous le faisons ici. J'ai préféré utiliser les
        //    outils que nous avions vu à la séance #2 pour faire une
        //    solution conforme à ce que vous pouviez faire.

        public void LireInformation()
        {
            //--- Nous considérerons anormal qu'un employé soit embauché
            //    avant un certain âge minimal, ici fixé à 16 ans.
            //    Nous pourrions fixer un âge maximal aussi mais ne
            //    faisons pas d'âgisme.
            const int AGE_MINIMAL_EMBAUCHE = 16;

            System.Console.Write("Donnez le nom de l'employé    : ");
            nom_ = Console.ReadLine();
            System.Console.Write("Donnez le prénom de l'employé : ");
            prenom_ = Console.ReadLine();

            Console.Write("Donnez l'âge de l'employé     : ");
            age_ = int.Parse(Console.ReadLine());
            while (age_ < AGE_MINIMAL_EMBAUCHE)
            {
                Console.WriteLine(" *** L'âge de l'employé ne peut être inférieur à {0} ***", AGE_MINIMAL_EMBAUCHE);
                Console.Write("Donnez l'âge de l'employé     : ");
                age_ = int.Parse(Console.ReadLine());
            }
            experience_ = 0;
        }

        public void CelebrerAnniversaire()
        {
            ++age_;
            ++experience_;
        }

        public bool EstEligibleALaRetraite()
        {
            return CalculerAnneesAvantRetraite() <= 0;
        }

        // Cette méthode aurait pu être privée aussi, si on avait voulu
        // ne pas en donner l'accès aux instances de la classe
        public int CalculerAnneesAvantRetraite()
        {
            const int FACTEUR_MINIMAL_REQUIS = 90;

            // On transforme la soustraction en 'float' pour provoquer une division réelle
            // sinon on aurait une division entière et une valeur 12,5 deviendrait 12 ce qui serait
            // incorrect
            float nbAnnées = (float)(FACTEUR_MINIMAL_REQUIS - (age_ + experience_)) / 2;

            // par contre, comme la valeur de retour de la méthode est 'int', il faut prendre le
            // résultat qui est un réel et le transformer en entier
            return (int)Math.Ceiling(nbAnnées);
        }

        public void AfficherInformations()
        {
            Console.WriteLine();
            Console.WriteLine("  Nom et prénom de l'employé : {0}, {1}", nom_, prenom_);
            Console.WriteLine("            Âge de l'employé : {0}", age_);
            Console.WriteLine("Nombre d'années d'expérience : {0}", experience_);
            Console.WriteLine();
        }
    }
}
