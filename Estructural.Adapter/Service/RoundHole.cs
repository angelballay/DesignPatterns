using Estructural.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructural.Adapter.Service
{
    internal class RoundHole : IRound
    {
        public double Radius;
        public RoundHole(double raidus) { 
            this.Radius = raidus;
        }

        public bool Fits(IRound peg)
        {
            return this.GetRadius() >= peg.GetRadius();
            
        }

        public double GetRadius()
        {
            return this.Radius;
        }
    }
}
