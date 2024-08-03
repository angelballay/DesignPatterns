using Estructural.Adapter.Interfaces;
using Estructural.Adapter.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructural.Adapter.Adapter
{
    internal class SquareAdapter : IRound
    {
        private SquarePeg peg;

        public SquareAdapter(SquarePeg peg) 
        {
            this.peg = peg;
        }

        public double GetRadius()
        {
            return this.peg.Width * Math.Sqrt(2) / 2;
        }
    }
}
