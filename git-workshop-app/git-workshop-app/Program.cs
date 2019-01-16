using System;

namespace git_workshop_app
{
    class Program
    {
        static void Main(string[] args)
        {
            // we will test if we still have conflicts
            var squareShape = new Square();
            squareShape.CalculateSquareArea();

            var rectangle = new Rectangle();
            rectangle.CalculateRectArea();

            var triangleShape = new Triangle();
            triangleShape.CalculateTriangleArea();

            var circle = new Circle();
            circle.CalculateCircleArea();

            Console.ReadKey();
        }
    }
}
