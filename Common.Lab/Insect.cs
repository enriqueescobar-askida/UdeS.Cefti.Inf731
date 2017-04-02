namespace Common.Lab
{
    public abstract class Insect : Animal
    {
        public bool Carapace { get; internal set; }

        public Insect(int weight, bool carapace = false)
            : base(weight)
        {
            this.Carapace = carapace;
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
