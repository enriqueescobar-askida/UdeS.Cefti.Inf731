namespace Week12.Demo
{
    public class Plane : Vehicule
    {
        public string Color { get; internal set; }

        public Plane(Plane plane)
        {
            this.Color = plane.Color;
        }

        public Plane()
        {
        }

        public override object Clone()
        {
            return new Plane(this);
        }
    }
}
