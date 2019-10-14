using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape, IShapeCalc
    {
        readonly double PI = Math.PI;
        public double Radius;

        public Circle(string colour, double radius) : base(colour)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            double num = (Math.PI * (Math.Pow(Radius, 2)));
            num = Math.Round(num, 2);
            return num;
        }

        public double GetPerimeter()
        {
            double num = (2 * Math.PI * Radius);
            num = Math.Round(num, 2);
            return num;
        }
    }
}
