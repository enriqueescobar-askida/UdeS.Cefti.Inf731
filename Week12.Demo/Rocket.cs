namespace Week12.Demo
{
    public class Rocket : Vehicule
    {
        public int Charge { get; internal set; }

        public Rocket()
        {
            
        }
        public Rocket(Rocket rocket)
        {
            this.Charge = rocket.Charge;
        }
        public override object Clone()
        {
            return new Rocket(this);
        }
    }
}
