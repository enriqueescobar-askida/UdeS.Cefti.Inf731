namespace Common.Lab
{
    using System;

    public class Person : IComparable<Person>
    {
        public int Age { get; internal set; }
        public string Name { get; set; }
        public string FamilyName { get; internal set; }
        public bool IsActive { get; internal set; }

        public Person(string nom, int age)
        {
            this.Name = nom;
            this.FamilyName = (nom.Contains(" "))?
                                nom.Split(' ')[1]
                                : String.Empty;
            this.Age = age;
            this.IsActive = (age>=20 && age<=60) ;
        }

        public Person(string name, string familyName) : this(name + " " + familyName, 0)
        {
        }

        /*public Person(Person person)
        {
            this.Name = person.Name;
            this.FamilyName = person.FamilyName;
            this.Age = person.Age;
            this.IsActive = person.IsActive;
        }*/
        public Person(Person existant)
        {
            this.Name = existant.Name;
            this.FamilyName = existant.FamilyName;
            this.Age = 0;
            this.IsActive = false;
        }

        public int CompareTo(Person other)
        {
            // return Compare(this.Name.ToUpper(), other.Name.ToUpper(), StringComparison.Ordinal);
            return -this.Age.CompareTo(other.Age);
        }
        public override string ToString()
        {
            return this.Name.PadRight(15) + string.Format("{0:c2}", this.Age).PadLeft(7);
        }
        public virtual string Afficher()
        {
            return String.Format("{0}, {1}", this.FamilyName, this.Name);
        }
        public virtual string Afficher2()
        {
            string s = new string('-', 72);
            s += "\n" + String.Format("{0}, {1}", this.FamilyName, this.Name);
            return s + "\n";
        }
        /// <summary>
        /// Méthode polymorphique qui produit une copie de l'instance qui y fait appel. Notez la signature !
        /// </summary>
        /// <returns>Une instance de Personne</returns>
        public virtual Person Clone()
        {
            return new Person(this);
        }
    }
}
