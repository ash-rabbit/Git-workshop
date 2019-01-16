using System;
using System.Collections.Generic;
using System.Text;

namespace git_workshop_app
{
    class Circle
    {
        public float radius;

        public void CalculateCircleArea()
        {
            Console.WriteLine("Enter the Radius of the Circle");
            radius = float.Parse(Console.ReadLine());

            Console.WriteLine("Area of Circle is:{0}", 3.14 * radius * radius);
        }
    }
}
