using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class RightAngle : Triangle, IShapeCalc
    {
        public RightAngle(string colour, double side1Length, double side2Length, double side3Length) : base(colour, side1Length, side2Length, side3Length)
        {

        }

        public void SetHypotenuse()
        {
            double num = (Math.Sqrt((Math.Pow(Side1Length, 2) + Math.Pow(Side2Length, 2))));
            Side3Length = num;
        }

        public double GetArea()
        {
            double num = (0.5 * Side1Length * Side2Length);
            num = Math.Round(num, 2);
            return num;
        }

        public double GetPerimeter()
        {
            double num = Side1Length + Side2Length + Side3Length;
            num = Math.Round(num, 2);
            return num;
        }
    }
}
