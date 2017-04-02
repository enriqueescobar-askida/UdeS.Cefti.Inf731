namespace Common.Lab
{
    public class Ostrich : Bird, IWalk
    {
        const float MaxMarche = 3;  // km/h
        const float MaxCourse = 10; // km/h

        public float Speed { get; internal set; }

        public Ostrich(int weight)
            :base(weight)
        {
            this.Speed = 0;
        }

        public bool Marcher()
        {
            this.Speed = MaxMarche;
            //Console.WriteLine("Je suis l'autruche et je marche à {0} km/h", this.Speed);
            return this.Speed > 0;
        }

        public bool Courir()
        {
            this.Speed = MaxCourse;
            //Console.WriteLine("Je suis l'autruche et je cours à {0} km/h", this.Speed);
            return this.Speed > 0;
        }

        public bool Arreter()
        {
            this.Speed = 0;
            //Console.WriteLine("Je suis l'autruche et je m'arrête");
            return (this.Speed == 0);
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
