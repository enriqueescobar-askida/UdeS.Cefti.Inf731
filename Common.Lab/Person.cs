﻿namespace Common.Lab
{
    using System;

    using static System.String;

    public class Person : IComparable<Person>
    {
        public int Age { get; internal set; }
        public string Name { get; internal set; }

        public bool IsActive { get; internal set; }

        public Person(string nom, int age)
        {
            this.Name = nom;
            this.Age = age;
            this.IsActive = (age>=20 && age<=60) ;
        }

        public int CompareTo(Person other)
        {
            // return Compare(this.Name.ToUpper(), other.Name.ToUpper(), StringComparison.Ordinal);
            return -this.Age.CompareTo(other.Age);
        }
    }
}