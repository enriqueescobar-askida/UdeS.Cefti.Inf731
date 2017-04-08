namespace Week12.Demo
{
    using System;

    public class Car : Vehicule
    {
        public int Level { get; internal set; }
        public Car()
        {
        }

        public Car(Car car)
        {
            this.Level = car.Level;
        }
        public override object Clone()
        {
            return new Car(this);
        }
    }
}