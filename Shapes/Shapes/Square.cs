using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Square : Quadrilateral
    {
        public Square(string colour, double side1length) : base(colour, side1length, side1length, side1length, side1length)
        {

        }

        public override double GetArea()
        {
            double num = Side1Length * Side1Length;
            return num;
        }

        public override double GetPerimeter()
        {
            double num = Side1Length * 4;
            return num;
        }
    }
}
