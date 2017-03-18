namespace Common.Lab
{
    using System;

    public class Teacher : Person
    {
        public string NAS { get; internal set; }
        public int EmployeeNumber { get; internal set; }
        public string Field { get; internal set; }

        public Teacher(string familyName, string name, string nas, int employeeNb, string field)
            : base(name, familyName)
        {
            this.NAS = nas;
            this.EmployeeNumber = employeeNb;
            this.Field = field;
        }

        public override string ToString()
        {
            return base.ToString() + " --- " + this.NAS + "; " + this.EmployeeNumber + " ==> " + this.Field;
        }

        public override string Afficher()
        {
            // On fait appel à la méthode Afficher() de la classe de base (Personne)
            string s = base.Afficher() + " | " + String.Format("{0}, {1} ==> {2}", this.NAS, this.EmployeeNumber, this.Field);

            return s;
        }
    }
}
