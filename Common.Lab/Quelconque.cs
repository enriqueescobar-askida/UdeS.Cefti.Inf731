namespace Common.Lab
{
    public class Quelconque
    {
        public string ChainStrange { get; internal set; }

        public int PeuImporte { get; }

        public Quelconque(string valeurInitiale = null)
        {
            this.ChainStrange = valeurInitiale;
        }
    }
}
