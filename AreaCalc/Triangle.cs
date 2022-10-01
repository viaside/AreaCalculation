using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class Triangle : IFigure
    {
        public string NameFigure { get; set; } = "Triangle";

        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 && b <= 0 && c <= 0)
                throw new ArgumentException("Invalid sides", nameof(a));
            else if (a <= 0)
                throw new ArgumentException("Invalid side", nameof(a));
            else if (b <= 0)
                throw new ArgumentException("Invalid side", nameof(b));
            else if (c <= 0)
                throw new ArgumentException("Invalid side", nameof(c));

            A = a;
            B = b;
            C = c;
        }

        public bool IsRightTriangle()
        {
            double AInSquare = Math.Pow(A, 2);
            double BInSquare = Math.Pow(B, 2);
            double CInSquare = Math.Pow(C, 2);

            if (CInSquare == Math.Sqrt(AInSquare + BInSquare)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetArea()
        {
            var P = (A + B + C) / 2d;
            var square = Math.Sqrt(
                P
                * (P - A)
                * (P - B)
                * (P - C)
            );

            return square;
        }
    }
}
