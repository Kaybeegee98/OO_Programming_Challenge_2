using NUnit.Framework;
using Shapes;

namespace Tests
{
    public class Tests
    {
        Square square { get; set; }
        Rectangle rect { get; set; }
        Equilateral equil { get; set; }
        RightAngle right { get; set; }
        Circle circle { get; set; }

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(5, 25, 20)]
        [TestCase(15, 225, 60)]
        [TestCase(7, 49, 28)]
        public void SquareTest(double side, double area, double peri)
        {
            square = new Square("Blue", side);
            Assert.AreEqual(area, square.GetArea());
            Assert.AreEqual(peri, square.GetPerimeter());
        }

        [TestCase(5, 10, 50, 30)]
        [TestCase(4, 6, 24, 20)]
        [TestCase(9, 7, 63, 32)]
        public void RectangleTest(double side1, double side2, double area, double peri)
        {
            rect = new Rectangle("Blue", side1, side2);
            Assert.AreEqual(area, rect.GetArea());
            Assert.AreEqual(peri, rect.GetPerimeter());
        }

        [TestCase(5, 10.83, 15)]
        [TestCase(15, 97.43, 45)]
        [TestCase(7, 21.22, 21)]
        public void EquilateralTest(double side, double area, double peri)
        {
            equil = new Equilateral("Blue", side);
            Assert.AreEqual(area, equil.GetArea());
            Assert.AreEqual(peri, equil.GetPerimeter());
        }

        [TestCase(5, 10, 25, 26.18)]
        [TestCase(4, 6, 12, 17.21)]
        [TestCase(9, 7, 31.5, 27.4)]
        public void RightAngleTest(double side1, double side2, double area, double peri)
        {
            right = new RightAngle("Blue", side1, side2, 0);
            right.SetHypotenuse();

            Assert.AreEqual(area, right.GetArea());
            Assert.AreEqual(peri, right.GetPerimeter());
        }

        [TestCase(5, 78.54, 31.42)]
        [TestCase(15, 706.86, 94.25)]
        [TestCase(7, 153.94, 43.98)]
        public void CircleTest(double radius, double area, double peri)
        {
            circle = new Circle("Blue", radius);
            Assert.AreEqual(area, circle.GetArea());
            Assert.AreEqual(peri, circle.GetPerimeter());
        }
    }
}