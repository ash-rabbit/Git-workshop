using System;
using System.Collections.Generic;
using System.Text;

namespace git_workshop_app
{
    public class Triangle : ShapeArea
    {
        public override int Area { get { return (Height * BaseWidth) / 2; } }
        public int Height { get; set; }
        public int BaseWidth { get; set; }
    }
}
