using System;
using System.Collections.Generic;
using System.Text;

namespace git_workshop_app
{
    public class Rectangle : ShapeArea
    {
        public override int Area { get { return Length * Width; } }
        public int Length { get; set; }
        public int Width { get; set; }
    }
}
