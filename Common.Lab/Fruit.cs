namespace Common.Lab
{
    public abstract class Fruit
    {
        public string Provenance { get; internal set; }
        public int Caliber { get; internal set; }

        protected Fruit(string provenance, int calibre)
        {
            this.Provenance = provenance;
            this.Caliber = calibre;
        }

        public override string ToString()
        {
            return " de " + Provenance.PadRight(16) + " -- calibre : " + this.Caliber.ToString();
        }
    }
}
