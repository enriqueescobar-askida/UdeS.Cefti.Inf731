namespace Common.Lab
{
    public abstract class Agrume : Fruit
    {
        public string Variety { get; private set; }

        protected Agrume(string p, int c, string variété)
            : base(p, c)
        {
            this.Variety = variété;
        }
        public override string ToString()
        {
            return base.ToString() + " variété " + this.Variety.PadRight(8);
        }
    }
}
