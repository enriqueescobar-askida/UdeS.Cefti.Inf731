namespace Common.Lab
{
    using System.Reflection;

    public class Student
    {
        public Student(string aName)
        {
            this.Name = aName;
            this.StudentMarks = new StudentMark[5];
        }

        public string Name { get; internal set; }

        public StudentMark[] StudentMarks { get; internal set; }

        public int MarkCounter { get; internal set; }

        public void AddMark(int i)
        {
            if (this.MarkCounter == this.StudentMarks.Length)
                this.ExtendArray();

            this.StudentMarks[this.MarkCounter] = new StudentMark(i);
            this.MarkCounter++;
        }

        private void ExtendArray()
        {
            StudentMark[] studentMarks = new StudentMark[this.StudentMarks.Length*2];

            for(int i=0 ; i < this.StudentMarks.Length; i++)
                studentMarks[i] = this.StudentMarks[i];

            this.StudentMarks = studentMarks;
        }

        public int MarkSum()
        {
            int somme = 0;

            for (int i = 0; i < this.MarkCounter; ++i)
                somme += this.StudentMarks[i].Mark;

            return somme;
        }
    }
}
