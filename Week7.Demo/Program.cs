namespace Week7.Demo
{
    using System;
    using System.IO;

    using  Common.Lab;

    class Program
    {
        static void Main(string[] args)
        {
            //Puisque l'on désire retourner deux valeurs, nous allons passer les paramètre
            //par référence pour que la fonction appelé puisse les modifier. De plus, puisque
            //les paramètres sont passé par référence, il est aussi nécessaire de les initialiser.
            //Cette initialisation est bidon puisque LireOpération va immédiatement modifier 
            //les valeurs. Nous aurions pu contourner cette limitation en passant les paramètres avec
            //"out" au lieu de "ref".
            Operation[] operations = new Operation[0];
            int nbOperations = 0;
            LireOperations(ref operations, ref nbOperations);

            TraiterOperation(operations, nbOperations);

            EcrireOperations(operations, nbOperations);
        }

        static void LireOperations(ref Operation[] operations2, ref int nbOperations)
        {
            operations2 = new Operation[50000];
            nbOperations = 0;

            StreamReader reader = new StreamReader("../../entree.txt");
            while (!reader.EndOfStream)
            {
                string ligne = reader.ReadLine();
                string[] composants = ligne.Split(' ');

                int valeur1 = int.Parse(composants[0]);
                string operateur = composants[1];
                int valeur2 = int.Parse(composants[2]);

                Operation operation = new Operation(operateur, valeur1, valeur2);
                operations2[nbOperations] = operation;
                ++nbOperations;
            }
            reader.Close();
        }

        static void TraiterOperation(Operation[] operations, int nbOperation)
        {
            //Dans notre cas, aucun traitement sur les opérations n'est requis.
        }

        static void EcrireOperations(Operation[] operations, int nbOperation)
        {
            StreamWriter writer = new StreamWriter("../../sortie.txt");
            for (int idx = 0; idx < nbOperation; ++idx)
            {
                Operation op = operations[idx];
                string ligne = string.Format("{0} {1} {2} = {3}",
                    op.Valeur1,
                    op.Operateur,
                    op.Valeur2,
                    op.Resultat);
                Console.WriteLine(ligne);
                writer.WriteLine(ligne);
            }
            writer.Close();
        }
    }
}
