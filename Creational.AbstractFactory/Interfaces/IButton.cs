using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.Interfaces
{
    /// <summary>
    /// Cada producto individual de una familia de productos debe tener una interfaz base. 
    /// Todas las variantes del producto deben implementar esta interfaz.
    /// </summary>
    public interface IButton
    {
        void Paint(string? text = "");
    }
}
