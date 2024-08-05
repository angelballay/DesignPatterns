using Estructural.Composite.OtherExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructural.Composite.OtherExample.Composite
{
    public class PizzaComposite : CostComposite
    {
        public PizzaComposite(string name, double costo = 0) : base(name, costo)
        {
        }

    }
}
