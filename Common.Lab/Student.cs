﻿namespace Common.Lab
{
    using System;
    using System.Collections.Generic;

    public class Student : Person
    {
        public Student(string aName)
            : base(aName.Split(' ')[0], aName.Split(' ')[1])
        {
            this.FullName = aName;
            this.MarksArray = new StudentMark[5];
            this.MarkList = new List<StudentMark>();
        }

        public Student(string name, string familyName, string codePermanent, int admissionId)
            : base(name, familyName)
        {
            this.FullName = name + " " + familyName;
            this.CodePermanent = codePermanent;
            this.AdmissionId = admissionId;
        }

        /*public Student(Student student)
            : base(student)
        {
            this.FullName = student.FullName;
            this.CodePermanent = student.CodePermanent;
            this.AdmissionId = student.AdmissionId;
            this.MarksArray = student.MarksArray;
            this.MarkList = student.MarkList;
        }*/
        public Student(Student existant)
            : base(existant)
        {
            this.AdmissionId = existant.AdmissionId;
            this.CodePermanent = existant.CodePermanent;
        }

        public Student(string name, string familyName, string noDossier)
            : base(name, familyName)
        {
            this.CodePermanent = noDossier;
        }
        public Student(string nom, string prénom, string[] tableau)
            : base(nom, prénom)
        {
            this.AdmissionId = int.Parse(tableau[0]);
            this.CodePermanent = tableau[1];
        }

        public string FullName { get; internal set; }
        public string CodePermanent { get; internal set; }
        public int AdmissionId { get; internal set; }
        public StudentMark[] MarksArray { get; internal set; }
        public List<StudentMark> MarkList { get; internal set; }

        //public new string ToString()
        public override string ToString()
        {
            return base.ToString() + " --- " + this.CodePermanent + "; " + this.AdmissionId;
        }

        public override string Afficher()
        {
            // On fait appel d'abord appel à la méthode Afficher() de Personne (base désigne Personne)
            string s = base.Afficher() + " | " + String.Format("{0} --- {1}", this.CodePermanent, this.AdmissionId);

            return s;
        }

        public override string Afficher2()
        {
            string s = base.Afficher();
            s += "\n" + String.Format("Numéro de dossier : " + this.CodePermanent);
            return s;
        }


        public string Afficher3()
        {
            string s = base.Afficher();
            s += "\n" + String.Format("No admission : {0}", this.AdmissionId);
            s += "\n" + String.Format("Numéro de dossier : {1}", this.CodePermanent);
            return s + "\n";
        }

        public override Person Clone()
        {
            return new Student(this);
        }

        public int MarkCounter { get; internal set; }

        private void ExtendArray()
        {
            StudentMark[] studentMarks = new StudentMark[this.MarksArray.Length * 2];

            for (int i = 0; i < this.MarksArray.Length; i++)
                studentMarks[i] = this.MarksArray[i];

            this.MarksArray = studentMarks;
        }

        public void AddMark(int i)
        {
            if (this.MarkCounter == this.MarksArray.Length)
                this.ExtendArray();

            this.MarkList.Add(new StudentMark(i));
            this.MarksArray[this.MarkCounter] = new StudentMark(i);
            this.MarkCounter++;
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
