using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class WithoutKnowledge
    {
        public double ResultWithoutKnowledge { get; set; }
        public WithoutKnowledge(double a, double b, double c)
        {
            Triangle Func = new Triangle(a, b, c);
            ResultWithoutKnowledge = Func.GetArea();
        }
        
        public WithoutKnowledge(double radius)
        {
            Circle Func = new Circle(radius);
            ResultWithoutKnowledge = Func.GetArea();
        }

        public double GetArea()
        {
            return ResultWithoutKnowledge;
        }
    }
}
