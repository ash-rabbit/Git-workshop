using System;
using System.Collections.Generic;
using System.Text;

namespace git_workshop_app
{
    class Rectangle
    {
        public float length;
        public float width;

        public void CalculateRectArea()
        {
            Console.WriteLine("Enter the Length for Rectangle");
            length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width for Rectangle");
            width = float.Parse(Console.ReadLine());

            Console.WriteLine("Area of rectangle is :{0}", length * width);
        }
    }
}
