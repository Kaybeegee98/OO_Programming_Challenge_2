using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Equilateral : Triangle, IShapeCalc
    {
        public Equilateral(string colour, double side1Length) : base(colour, side1Length, side1Length, side1Length)
        {

        }

        public double GetArea()
        {
            double num = ((Math.Sqrt(3) / 4) * (Math.Pow(Side1Length, 2)));
            num = Math.Round(num, 2);
            return num;
        }

        public double GetPerimeter()
        {
            double num = Side1Length * 3;
            num = Math.Round(num, 2);
            return num;
        }
    }
}
