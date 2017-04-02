namespace Common.Lab
{
    public class Mosquito : Insect, IFly
    {
        public Mosquito(int weight)//, bool carapace = false)
            : base(weight)//, carapace)
        {
            this.Voler = false;
        }

        public bool Voler { get; internal set; }

        public void Decoller()
        {
            if (!this.Voler)
            {
                this.Voler = true;
                //Console.WriteLine("Ce moustique s'envole... ");
            }
        }

        public void SePoser()
        {
            if (this.Voler)
            {
                this.Voler = false;
                //Console.WriteLine("Ce moustique se pose...");
            }
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}