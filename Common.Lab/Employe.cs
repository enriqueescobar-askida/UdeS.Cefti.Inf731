namespace Common.Lab
{
    using System;

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

        public void LireInformation(string nom, string prenom, int age)
        {
            nom_ = nom;
            prenom_ = prenom;
            age_ = age;
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

        // Cette méthode aurait pu être privée aussi, si on avait voulu ne pas en donner l'accès aux instances de la classe
        public int CalculerAnneesAvantRetraite()
        {
            const int FACTEUR_MINIMAL_REQUIS = 90;

            // On transforme la soustraction en 'float' pour provoquer une division réelle sinon on aurait une division entière et
            // une valeur 12,5 deviendrait 12 ce qui serait incorrect
            float nbAnnées = (float)(FACTEUR_MINIMAL_REQUIS - (age_ + experience_)) / 2;

            // par contre, comme la valeur de retour de la méthode est 'int', il faut prendre le résultat qui est un réel et le transformer en entier
            return (int)Math.Ceiling(nbAnnées);
        }

        public override string ToString()
        {
            string s = "\n";
            s += "  Nom et prénom de l'employé : " + nom_ + ", " + prenom_ + "\n";
            s += "            Âge de l'employé : " + age_ + "\n";
            s += "Nombre d'années d'expérience : " + experience_ + "\n";
            s += "\n";

            return s;
        }
    }
}
