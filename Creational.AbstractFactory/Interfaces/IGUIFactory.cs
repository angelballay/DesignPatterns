using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.Interfaces
{   
    /// <summary>
    /// La interaz fabrica abstracta declarea un grupo de metodos que devuelven distintos productos abstractos.
    /// Estos produtos se denominan familia y estan relacionados por un tema o concepto de alto nivel.
    /// Normalmente, los productos de una familia pueden colabarar entre si. Una familia de productos puede tener 
    /// muchas variantes, per los productos de una variante son incompatibles con los producots de otra.
    /// </summary>
    public interface IGUIFactory
    {
        public IButton CreateButton();

        public ICheckbox CreateCheckbox();

    }
}
