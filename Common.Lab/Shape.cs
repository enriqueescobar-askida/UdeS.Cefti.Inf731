namespace Common.Lab
{
    public abstract class Shape
    {
        public char Symbole { get; protected set; }

        protected Shape(char valSymbole)
        {
            this.Symbole = valSymbole;
        }

        public abstract override string ToString();
    }
}