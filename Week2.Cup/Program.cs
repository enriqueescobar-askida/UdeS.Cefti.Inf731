namespace Week2.Cup
{
    using System;

    using Common.Lab;
    class Program
    {
        static void Main(string[] args)
        {
            Cup whatever = new Cup();
            Console.WriteLine(whatever.ToString());
            Cup firstCup = new Cup();
            firstCup.Initialiser(200);
            Console.WriteLine(firstCup.ToString());

            Cup secondCup = new Cup();
            secondCup.Initialiser(167);
            Console.WriteLine(secondCup.ToString());

            Cup thirdCup = new Cup();
            thirdCup.Initialiser(567);
            Console.WriteLine(thirdCup.ToString());
            thirdCup.Initialiser(-111);
            Console.WriteLine(thirdCup.ToString());

            Cup aCup = new Cup
            {
                Couleur = "White"
            };
            Console.WriteLine("This cup is " + aCup.Couleur);

            Cup cupOne = new Cup();
            cupOne.Initialiser(256);
            Cup cupTwo = new Cup();
            cupTwo.Initialiser(110);
            Cup cupThree = new Cup();
            cupThree.Initialiser(467);
            Console.WriteLine("La tasse la plus pleine contient : {0} ml", Cup.MaxCapacity);
            Console.ReadLine();
        }
    }
}
