using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Quadrilateral, IShapeCalc
    {
        public Rectangle(string colour, double side1Length, double side2Length) : base(colour, side1Length, side2Length, side1Length, side2Length)
        {

        }

        public override double GetArea()
        {
            double num = Side1Length * Side2Length;
            return num;
        }

        public override double GetPerimeter()
        {
            double num = (Side1Length * 2) + (Side2Length * 2);
            return num;
        }
    }
}
