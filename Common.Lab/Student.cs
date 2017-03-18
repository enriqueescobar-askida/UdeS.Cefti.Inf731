namespace Common.Lab
{
    using System.Collections.Generic;
    using System.Reflection;

    public class Student
    {
        public Student(string aName)
        {
            this.Name = aName;
            this.MarksArray = new StudentMark[5];
            this.MarkList = new List<StudentMark>();
        }

        public string Name { get; internal set; }

        public StudentMark[] MarksArray { get; internal set; }

        public List<StudentMark> MarkList { get; internal set; }

        public int MarkCounter { get; internal set; }

        public void AddMark(int i)
        {
            if (this.MarkCounter == this.MarksArray.Length)
                this.ExtendArray();

            this.MarkList.Add(new StudentMark(i));
            this.MarksArray[this.MarkCounter] = new StudentMark(i);
            this.MarkCounter++;
        }

        private void ExtendArray()
        {
            StudentMark[] studentMarks = new StudentMark[this.MarksArray.Length*2];

            for(int i=0 ; i < this.MarksArray.Length; i++)
                studentMarks[i] = this.MarksArray[i];

            this.MarksArray = studentMarks;
        }

        public int MarkSum()
        {
            int somme = 0;

            for (int i = 0; i < this.MarkCounter; ++i)
                somme += this.MarksArray[i].Mark;

            foreach (StudentMark studentMark in this.MarkList) somme += studentMark.Mark;

            return somme;
        }
    }
}
