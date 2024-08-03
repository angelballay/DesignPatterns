using Estructural.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructural.Adapter.Service
{
    internal class RoundPeg : IRound
    {
        public double Radius;
        public RoundPeg(double radius)
        {
            this.Radius = radius;   
        }

        public RoundPeg() { }

        public virtual double GetRadius()
        {
           return this.Radius;
        }
    }
}
