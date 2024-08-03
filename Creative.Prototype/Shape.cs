using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creative.Prototype
{
    internal abstract class Shape
    {
        public int x; public int y;
        public string? Color;

        public Shape() { 
           
        }

        public Shape(Shape shape)
        {
            this.x = shape.x;
            this.y = shape.y;
            this.Color = shape.Color;
        }

        public abstract Shape Clone();
    }
}
