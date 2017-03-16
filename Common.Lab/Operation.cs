namespace Common.Lab
{
    public class Operation
    {
        public Operation(string operateur, int valeur1, int valeur2)
        {
            this.Operateur = operateur;
            this.Valeur1 = valeur1;
            this.Valeur2 = valeur2;
        }

        public int Valeur1 { get; set; }

        public int Valeur2 { get; set; }

        public string Operateur { get; set; }

        public int Resultat
        {
            get
            {
                if (this.Operateur == "+")
                {
                    return this.Valeur1 + this.Valeur2;
                }
                else if (this.Operateur == "-")
                {
                    return this.Valeur1 - this.Valeur2;
                }
                else if (this.Operateur == "*")
                {
                    return this.Valeur1 * this.Valeur2;
                }
                else if (this.Operateur == "/")
                {
                    return this.Valeur1 / this.Valeur2;
                }
                else
                {
                    /////// Console.WriteLine("Operateur non reconnu {0}", Operateur);
                    return 0; //return obligatoire ici
                }
            }
        }
    }
}
