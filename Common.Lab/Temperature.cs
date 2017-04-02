namespace Common.Lab
{
    using System;
    public class Temperature : IComparable
    {
        const double AbsolutZero = -273.15;
        public double Anglaise { get; set; }
        public double Metrique { get; set; }
        public double Celsius { get; internal set; }
        public double Fahrenheit => this.Celsius * 9 / 5 + 32;

        public Temperature(double celsius)
        {
            this.Celsius = celsius;
        }

        public Temperature()
        {
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Temperature))
                throw new ArgumentException();

            return -this.Celsius.CompareTo((obj as Temperature).Celsius);
        }
    }
}
