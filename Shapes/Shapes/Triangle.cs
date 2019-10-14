using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public abstract class Triangle : Shape
    {
        public double Side1Length;
        public double Side2Length;
        public double Side3Length;

        public Triangle(string colour, double side1Length, double side2Length, double side3Length) : base(colour)
        {
            Side1Length = side1Length;
            Side2Length = side2Length;
            Side3Length = side3Length;
        }
    }
}
