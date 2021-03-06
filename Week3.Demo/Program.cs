﻿namespace Week3.Demo
{
    using System;

    using Common.Lab;
    class Program
    {
        static void Main(string[] args)
        {
            RunCar();
            RunCarEnum();
        }

        static void RunCar()
        {
            Car v1 = new Car();
            Car v2 = new Car();

            v1.Immatriculation = "3j53n1";
            v1.Couleur = "Bleu";
            v1.Marque = "Ford";

            v2.Immatriculation = "p53l2m";
            v2.Couleur = "Rouge";
            v2.Marque = "Porsche";

            AfficherVoiture(v1);
            Console.WriteLine("-------------");
            AfficherVoiture(v2);
            Console.WriteLine();
            Console.WriteLine(v1.ParcourirDistance(44));
            Console.WriteLine(v1.ParcourirDistance(7000));
            Console.WriteLine(v2.ParcourirDistance(1245));
            Console.WriteLine(v2.ParcourirDistance(12));
            Console.WriteLine(v2.ParcourirDistance(128));
            Console.WriteLine();
            AfficherVoiture(v1);
            Console.WriteLine("-------------");
            AfficherVoiture(v2);
            Console.ReadLine();
        }

        static void AfficherVoiture(Car voiture)
        {
            Console.WriteLine("Immatriculation: {0}", voiture.Immatriculation);
            Console.WriteLine("Couleur: {0}", voiture.Couleur);
            Console.WriteLine("Kilometrage: {0}km", voiture.Kilometrage);
        }

        static void RunCarEnum()
        {
            CarWithEnumColors v1 = new CarWithEnumColors
            {
                Immatriculation = "3j53n1",
                Couleur = EnumColors.Blue,
                Marque = "Ford"
            };

            CarWithEnumColors v2 = new CarWithEnumColors
            {
                Immatriculation = "p53l2m",
                Couleur = EnumColors.Red,
                Marque = "Porsche"
            };

            AfficherEnumCar(v1);
            Console.WriteLine("-------------");
            AfficherEnumCar(v2);
            Console.WriteLine();
            Console.WriteLine(v1.ParcourirDistance(44));
            Console.WriteLine(v1.ParcourirDistance(7000));
            Console.WriteLine(v2.ParcourirDistance(1245));
            Console.WriteLine(v2.ParcourirDistance(12));
            Console.WriteLine(v2.ParcourirDistance(128));
            Console.WriteLine();
            AfficherEnumCar(v1);
            Console.WriteLine("-------------");
            AfficherEnumCar(v2);
            Console.ReadLine();
        }

        static void AfficherEnumCar(CarWithEnumColors voitureEnum)
        {
            Console.WriteLine("Immatriculation: {0}", voitureEnum.Immatriculation);
            Console.WriteLine("Couleur: {0}", voitureEnum.Couleur);
            Console.WriteLine("Kilometrage: {0}km", voitureEnum.Kilometrage);
        }
    }
}
