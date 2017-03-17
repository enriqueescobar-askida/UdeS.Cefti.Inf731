namespace Common.Lab
{
    public class Fun
    {
        public int Entier{ get; internal set; }
        
        public double Double { get; internal set; }

        public Fun()
        {
            this.Entier = 0;
            this.Double = 0.0;
            this.ToString();
        }

        public Fun(int entier)
        {
            this.Entier = entier;
            this.Double = 0.0;
            this.ToString();
        }

        public Fun(double unDouble)
        {
            this.Entier = 0;
            this.Double = unDouble;
            this.ToString();
        }

        public Fun(int entier, double unDouble)
        {
            this.Entier = entier;
            this.Double = unDouble;
            this.ToString();
        }

        public sealed override string ToString()
        {
            string s = this.Entier + " -- " + this.Double;
            return s;
        }
    }

}
