namespace Common.Lab
{
    public class Kiwi : Fruit
    {
        public Kiwi(string provenance, int calibre)
        : base(provenance, calibre)
            {
            }
        public override string ToString()
        {
            return this.GetType().Name.PadRight(12) + base.ToString();
        }
    }
}
