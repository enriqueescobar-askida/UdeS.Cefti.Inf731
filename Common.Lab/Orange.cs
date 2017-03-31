namespace Common.Lab
{
    public class Orange : Agrume
    {
        public Orange(string p, int c, string v)
            : base(p, c, v)
        {
        }
        public override string ToString()
        {
            return this.GetType().Name.PadRight(12) + base.ToString();
        }
    }
}
