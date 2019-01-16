using System;
using System.Collections.Generic;
using System.Text;

namespace git_workshop_app
{
    class Triangle
    {
        public float width;
        public float height;

        public void CalculateTriangleArea()
        {
            Console.WriteLine("Enter the width for Triangle");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height for Triangle");
            height = float.Parse(Console.ReadLine());

            Console.WriteLine("Area of rectangle is :{0}", (height * width) / 2);
        }
    }
}

