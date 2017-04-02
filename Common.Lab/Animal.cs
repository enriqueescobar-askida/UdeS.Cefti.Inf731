namespace Common.Lab
{
    using System;

    public abstract class Animal : IComparable
    {
        public int Weight { get; internal set; }

        protected Animal(int weight)
        {
            this.Weight = weight;
        }

        public int CompareTo(object obj) => this.Weight.CompareTo((obj as Animal).Weight);
    }
}
