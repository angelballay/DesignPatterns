using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructural.Composite.OtherExample.Interface
{
    public abstract class Element
    {
        public string Name { get; set; }
        public double Costo { get; set; }

       
        public Element(string name, double costo)
        {
            Name = name;
            Costo = costo;
        }
    }
}
