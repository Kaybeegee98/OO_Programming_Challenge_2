using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public abstract class Quadrilateral : Shape, IShapeCalc
    {
        public double Side1Length;
        public double Side2Length;
        public double Side3Length;
        public double Side4Length;

        public Quadrilateral(string colour, double side1Length, double side2Length, double side3Length, double side4Length) : base(colour)
        {
            Side1Length = side1Length;
            Side2Length = side2Length;
            Side3Length = side3Length;
            Side4Length = side4Length;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}
