namespace Common.Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Operation
    {
        public Operation(string operateur, int valeur1, int valeur2)
        {
            Operateur = operateur;
            Valeur1 = valeur1;
            Valeur2 = valeur2;
        }

        public int Valeur1
        {
            get
            {
                return valeur1_;
            }
            set
            {
                valeur1_ = value;
            }
        }

        public int Valeur2
        {
            get
            {
                return valeur2_;
            }
            set
            {
                valeur2_ = value;
            }
        }

        public string Operateur
        {
            get
            {
                return operateur_;
            }
            set
            {
                operateur_ = value;
            }
        }

        public int Resultat
        {
            get
            {
                if (Operateur == "+")
                {
                    return Valeur1 + Valeur2;
                }
                else if (Operateur == "-")
                {
                    return Valeur1 - Valeur2;
                }
                else if (Operateur == "*")
                {
                    return Valeur1 * Valeur2;
                }
                else if (Operateur == "/")
                {
                    return Valeur1 / Valeur2;
                }
                else
                {
                    /////// Console.WriteLine("Operateur non reconnu {0}", Operateur);
                    return 0; //return obligatoire ici
                }
            }
        }

        private int valeur1_;
        private int valeur2_;
        private string operateur_;
    }
}
