using System;
using System.Collections.Generic;
using System.Text;

namespace git_workshop_app
{
    class Square
    {
        public float side;

        public void CalculateSquareArea()
        {
            Console.WriteLine("Enter the side for Square");
            side = int.Parse(Console.ReadLine());

            Console.WriteLine("Area of square is :{0}", side * side);
        }
    }
}
