using Estructural.Composite.OtherExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructural.Composite.OtherExample.Composite
{
    public class FactureComposite : CostComposite
    {
        
        public int Count { get
            {
                return elements.Count;
            }
         }

        public FactureComposite(string name, double costo = 0) : base(name, costo)
        {

        }

    }
}
