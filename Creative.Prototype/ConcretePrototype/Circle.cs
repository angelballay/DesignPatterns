using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creative.Prototype.ConcretePrototype
{
    internal class Circle : Shape
    {
        public Circle() { }
        public int radius { get; set; }

        public Circle(Circle source) : base(source)
        {
            this.radius = source.radius;
        }

        public override Shape Clone()
        {
            return new Circle(this);
        }
    }
}
