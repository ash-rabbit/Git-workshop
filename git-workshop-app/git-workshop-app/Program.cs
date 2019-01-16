using System;

namespace git_workshop_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square();
            square.CalculateSquareArea();

            var rectangle = new Rectangle();
            rectangle.CalculateRectArea();

            var triangle = new Triangle();
            triangle.CalculateTriangleArea();

            var circle = new Circle();
            circle.CalculateCircleArea();

            Console.ReadKey();
        }
    }
}
