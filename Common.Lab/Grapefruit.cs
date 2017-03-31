namespace Common.Lab
{
    public class Grapefruit : Agrume
    {
        public string Type { get; private set; }

        public Grapefruit(string p, int c, string v, string type)
            : base(p, c, v)
        {
            this.Type = type;
        }

        public override string ToString()
        {
            return this.GetType().Name.PadRight(12) + base.ToString() + " type " + this.Type;
        }
    }
}
