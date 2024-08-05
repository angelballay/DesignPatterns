using Estructural.Composite.OtherExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructural.Composite.OtherExample.Composite
{
    public abstract class CostComposite : Element
    {
        internal IList<Element> elements;
        public CostComposite(string name, double costo = 0) : base(name, costo)
        {
            elements = new List<Element>();
        }

        public void AddElement(Element element)
        {
            elements.Add(element);
        }

        public void RemoveElement(Element element)
        {
            elements.Remove(element);
        }

        public double GetTotal()
        {
            var total = 0.00;
            if (elements.Any())
            {
                foreach (var element in elements)
                {
                    total += element.Costo;
                }
            }
            return total;
        }
    }
}
