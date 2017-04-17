namespace Week14.Lab
{
    using System;

    using Common.Lab;

    class Program
    {
        static void Main(string[] args)
        {
            CupOfTea();
        }

        private static void CupOfTea()
        {
            Cup première = new Cup(300);
            Cup seconde = new Cup(250);
            int valeur = (int)seconde;
            Cup troisième = 500;
            Cup quelconque = Modifier(200);
            Console.WriteLine((int)quelconque);
            int somme = 0;
            somme = somme + (int)première;  // (int) rendu nécessaire par la conversion 'explicit'
            somme += (int)seconde;          // ne serait pas requis pour une conversion 'implicit'
            somme += (int)troisième;
            Console.WriteLine("Somme : {0}", somme);
        }

        static Cup Modifier(Cup uneTasse)
        {
            return new Cup(uneTasse.NbMl + 100);
        }
    }
}
