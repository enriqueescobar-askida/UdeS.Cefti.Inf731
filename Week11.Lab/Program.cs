namespace Week11.Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.Lab;

    class Program
    {
        static void Main(string[] args)
        {
            Kiwi unKiwi = new Kiwi("Nouvelle Zélande", 36);
            Orange uneOrange = new Orange("Floride", 48, "Navel");
            Grapefruit g = new Grapefruit("Californie", 32, "Ruby Red", "Rose");
            List<Fruit> liste = new List<Fruit>();
            liste.Add(unKiwi);
            liste.Add(g);
            liste.Add(uneOrange);
            foreach (Fruit fruit in liste)
                Console.WriteLine(fruit);

            ExampleOne();
        }
        static void ExampleOne()
        {
            RectangleShape rs = new RectangleShape('%', 4, 5);
            Console.Out.WriteLine(rs);
            Console.WriteLine();
            Console.WriteLine(new string('-', 70));
            Console.WriteLine();
            Triangle monTriangle = new Triangle('!', 12, 8);
            Console.Out.WriteLine(monTriangle);
            List<Shape> liste = new List<Shape> { monTriangle, rs };
            List<Shape2D> liste2D = liste.OfType<Shape2D>().ToList();
            foreach (Shape2D f in liste2D)
                Console.WriteLine(f.Aire);
        }
    }
}
