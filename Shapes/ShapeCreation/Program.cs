using System;
using System.Collections.Generic;
using Shapes;

namespace ShapeCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool error = true;
            string answer = "0";
            string colour;
            double side1 = 0;
            double side2 = 0;
            double radius = 0;
            RightAngle r;

            List<Square> squarelist = new List<Square>();
            List<Rectangle> rectlist = new List<Rectangle>();
            List<Equilateral> equillist = new List<Equilateral>();
            List<RightAngle> rightlist = new List<RightAngle>();
            List<Circle> circlelist = new List<Circle>();

            while (answer != "6")
            {

                Console.Clear();
                Console.WriteLine("Please Enter Which Shape You Would Like To Create!");
                Console.WriteLine("1.  Square");
                Console.WriteLine("2.  Rectangle");
                Console.WriteLine("3.  Equilateral Triangle");
                Console.WriteLine("4.  Right Angle Triangle");
                Console.WriteLine("5.  Cicle");
                Console.WriteLine();
                Console.WriteLine("6. Exit Program");

                answer = Console.ReadLine();

                if (answer != "1" && answer != "2" && answer != "3" && answer != "4" && answer != "5" && answer != "6")
                {
                    Console.WriteLine("Not a Valid answer");
                }

                else if (answer == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Please enter Colour: ");
                    colour = Console.ReadLine();
                    Console.WriteLine("Please enter Square's Side Length: ");

                    while (error == true)
                    {
                        try
                        {
                            side1 = int.Parse(Console.ReadLine());
                            if((side1 % 1) > 0)
                            {
                                throw new NumberIsDecimalException(side1);
                            }
                            error = false;
                        }
                        catch (System.FormatException e)
                        {
                            Console.WriteLine("That is not a number, Please enter a Number: ");
                        }
                        catch (NumberIsDecimalException){
                            Console.WriteLine("Can not use Decimal Numbers, Please enter a Number:");
                        }
                    }
                    error = true;
                    squarelist.Add(new Square(colour, side1));
                    Console.WriteLine("Shape Create Succesfully!");
                    Console.WriteLine("You have create a " + colour + " Square with a side length of " + side1 + "!");

                }

                else if (answer == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Please enter Colour: ");
                    colour = Console.ReadLine();
                    Console.WriteLine("Please enter Rectangle's First Side Length: ");

                    while (error == true)
                    {
                        try
                        {
                            side1 = int.Parse(Console.ReadLine());
                            error = false;
                        }
                        catch (System.FormatException e)
                        {
                            Console.WriteLine("That is not a number, Please enter a Number: ");
                        }
                    }
                    error = true;

                    Console.WriteLine("Please enter Rectangle's Second Side Length: ");
                    while (error == true)
                    {
                        try
                        {
                            side2 = int.Parse(Console.ReadLine());
                            error = false;
                        }
                        catch (System.FormatException e)
                        {
                            Console.WriteLine("That is not a number, Please enter a Number: ");
                        }
                    }
                    error = true;

                    rectlist.Add(new Rectangle(colour, side1, side2));
                    Console.WriteLine("Shape Create Succesfully!");
                    Console.WriteLine("You have create a " + colour + " Rectangle with a side length of " + side1 + " and " + side2 + "!");

                }

                else if (answer == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Please enter Colour: ");
                    colour = Console.ReadLine();
                    Console.WriteLine("Please enter Equilateral Triangle's Side Length: ");

                    while (error == true)
                    {
                        try
                        {
                            side1 = int.Parse(Console.ReadLine());
                            error = false;
                        }
                        catch (System.FormatException e)
                        {
                            Console.WriteLine("That is not a number, Please enter a Number: ");
                        }
                    }
                    error = true;

                    equillist.Add(new Equilateral(colour, side1));
                    Console.WriteLine("Shape Create Succesfully!");
                    Console.WriteLine("You have create a " + colour + " Equilateral Triangle with a side length of " + side1 + "!");

                }

                else if (answer == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Please enter Colour: ");
                    colour = Console.ReadLine();
                    Console.WriteLine("Please enter Right Angle Triangle's First Side Length: ");

                    while (error == true)
                    {
                        try
                        {
                            side1 = int.Parse(Console.ReadLine());
                            error = false;
                        }
                        catch (System.FormatException e)
                        {
                            Console.WriteLine("That is not a number, Please enter a Number: ");
                        }
                    }
                    error = true;

                    Console.WriteLine("Please enter Right Angle Triangle's Second Side Length: ");
                    while (error == true)
                    {
                        try
                        {
                            side2 = int.Parse(Console.ReadLine());
                            error = false;
                        }
                        catch (System.FormatException e)
                        {
                            Console.WriteLine("That is not a number, Please enter a Number: ");
                        }
                    }
                    error = true;

                    r = new RightAngle(colour, side1, side2, 0);
                    r.SetHypotenuse();
                    rightlist.Add(r);
                    Console.WriteLine("Shape Create Succesfully!");
                    Console.WriteLine("You have create a " + colour + " Right Angle triangle with a side length of " + side1 + " and " + side2 + " and a Hypotenuse of " + Math.Round(r.Side3Length, 2) + "!");

                }

                else if (answer == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Please enter Colour: ");
                    colour = Console.ReadLine();
                    Console.WriteLine("Please enter Circle's Radius: ");

                    while (error == true)
                    {
                        try
                        {
                            radius = int.Parse(Console.ReadLine());
                            error = false;
                        }
                        catch (System.FormatException e)
                        {
                            Console.WriteLine("That is not a number, Please enter a Number: ");
                        }
                    }
                    error = true;

                    circlelist.Add(new Circle(colour, radius));
                    Console.WriteLine("Shape Create Succesfully!");
                    Console.WriteLine("You have create a " + colour + " Circle with a radius of " + radius + "!");

                }
                Console.ReadLine();
            }
            Console.WriteLine("Closing Program...");
            Console.ReadLine();
        }

    }
}
