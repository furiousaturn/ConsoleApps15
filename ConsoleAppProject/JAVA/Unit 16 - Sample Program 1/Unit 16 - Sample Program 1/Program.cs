using System;
using System.Collections.Generic;

namespace Unit_16___Sample_Program_1
{
    class Program
    {
        ShapeCollection shapes = new ShapeCollection();
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Unit 16 Smaple Program One - Simple Maths");

            program.showMenu();
        }


        void showMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("1. Calculate area of a Square");
            Console.WriteLine("2. Calculate area of a Triangle");
            Console.WriteLine("3. Calculate area of a Circle");
            Console.WriteLine("4. See Shape history");

            Console.WriteLine("Enter your choice: ");
            int answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    CalculateSquareArea();
                    break;
                case 2:
                    CalculateTriangleArea();
                    break;
                case 3:
                    CalculateCircleArea();
                    break;
                case 4:
                    SeeShapeHistory();
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again");
                    showMenu();
                    break;
            }
        }

        void CalculateSquareArea()
        {
            Console.WriteLine("");
            Console.WriteLine("Please input the width and height of your square/rectangle");

            Console.WriteLine("Enter the height: ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width: ");
            float width = float.Parse(Console.ReadLine());

            Shape square = new Square();
            square.setHeight(height);
            square.setWidth(width);

            float squareArea = square.CalcuateArea();

            Console.WriteLine("The area of your square is: " + squareArea);

            shapes.AddShape(square);
            EndFunction();
        }

        void CalculateTriangleArea()
        {
            Console.WriteLine("");

            Console.WriteLine("Please input the width and height of your Triangle");
            Console.WriteLine("Enter the height: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width: ");
            float width = float.Parse(Console.ReadLine());

            Shape triangle = new Triangle();
            triangle.setHeight(height);
            triangle.setWidth(width);

            float triangleArea = triangle.CalcuateArea();

            Console.WriteLine("The area of your Triangle is: " + triangleArea);

            shapes.AddShape(triangle);
            EndFunction();
        }

        void CalculateCircleArea()
        {
            Console.WriteLine("");

            Console.WriteLine("Enter the radius of the Circle: ");
            string valueToParse = Console.ReadLine();
            float radius = float.Parse(valueToParse);

            Shape circle = new Circle();

            circle.setRadius(radius);

            float area = circle.CalcuateArea();

            Console.WriteLine("The area of your Circle is: " + area);

            shapes.AddShape(circle);
            EndFunction();

        }

        void SeeShapeHistory()
        {
            List<Shape> shapeList = shapes.GetShapesList();


            if(shapeList.Count > 0)
            {
                for (int i = 0; i < shapeList.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". Type: " + shapeList[i].getType() + " Area: " + shapeList[i].CalcuateArea());
                }

                float totalAreaCalculated = shapes.GetShapesTotalArea();

                Console.WriteLine("");
                Console.WriteLine("Total Area Calculated: " + totalAreaCalculated);
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("You havent performed any calculations yet");
            }

            

            EndFunction();
        }

        void EndFunction()
        {
            Console.WriteLine("");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Main Menu");
            Console.WriteLine("2. Exit Application");
            Console.WriteLine("");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    showMenu();
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid Choice, try again");
                    EndFunction();
                    break;
            }

        }
    }
}
