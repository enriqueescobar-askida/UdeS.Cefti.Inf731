namespace Common.Lab
{
    class Teacher
    {
        public string FamilyName { get; internal set; }
        public string Name { get; internal set; }
        public string NAS { get; internal set; }
        public int EmployeeNumber { get; internal set; }
        public string Field { get; internal set; }

        public Teacher(string familyName, string name, string nas, int employeeNb, string field)
        {
            this.FamilyName = familyName;
            this.Name = name;
            this.NAS = nas;
            this.EmployeeNumber = employeeNb;
            this.Field = field;
        }

        public override string ToString()
        {
            return this.FamilyName + ", " + this.Name + " --- " + this.NAS + "; "
                   + this.EmployeeNumber + " ==> " + this.Field;
        }
    }
}
