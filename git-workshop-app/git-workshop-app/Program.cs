using System;

namespace git_workshop_app
{
    class Program
    {

        // I will try to create conflicts now

        static void Main(string[] args)
        {
            var squareObj = new Square();
            squareObj.CalculateSquareArea();

            var rectangleObj = new Rectangle();
            rectangleObj.CalculateRectArea();

            var triangleObj = new Triangle();
            triangleObj.CalculateTriangleArea();

            var circleObj = new Circle();
            circleObj.CalculateCircleArea();

            Console.ReadKey();
        }
    }
}
