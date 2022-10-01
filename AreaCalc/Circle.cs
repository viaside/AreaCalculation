using System;

namespace AreaCalc
{
    public class Circle : IFigure
    {
        public string NameFigure { get; set; } = "Circle";

        public const double MinRadius = 1e-6;

        public double Radius { get; }

        public Circle(double radius)
        {
            if(radius < MinRadius)
            {
                throw new ArgumentException("Invalid circle radius", nameof(radius));
            }
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2d);
        }
    }
}
