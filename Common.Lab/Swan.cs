namespace Common.Lab
{
    public class Swan : Bird, IFly
    {
        public bool Voler { get; internal set; }
        public Swan(int weight)//, string color = "Blanc")
            : base(weight)//, color)
        {
            this.Voler = false;
        }

        public void Decoller()
        {
            if (!this.Voler)
            {
                this.Voler = true;
                //Console.WriteLine("Cette hirondelle s'envole... ");
            }
        }

        public void SePoser()
        {
            if (this.Voler)
            {
                this.Voler = false;
                //Console.WriteLine("Cette hirondelle se pose...");
            }
        }
    }
}
