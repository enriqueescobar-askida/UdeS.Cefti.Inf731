namespace Common.Lab
{
    public class Bird : Animal
    {
        const string ColorDefault = "Blanc";
        public string Color { get; internal set; }
        public Bird(int weight, string color = ColorDefault)
            : base(weight)
        {
            this.Color = color;
        }
    }
}