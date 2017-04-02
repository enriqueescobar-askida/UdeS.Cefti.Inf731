namespace Week12.Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.Lab;
    class Program
    {
        static void Main(string[] args)
        {
            First();
        }

        static void First()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Ostrich(80500));
            animals.Add(new Swan(125));
            animals.Add(new Mosquito(1));
            animals.Sort();
            Console.WriteLine();
            foreach (Animal a in animals)
            {
                Console.Write(a + " a un poids de ");
                Console.WriteLine(a.Weight);
            }

            List<IFly> flyerList = animals.OfType<IFly>().ToList();
            foreach (IFly v in flyerList)
                v.Decoller();
        }
    }
}
