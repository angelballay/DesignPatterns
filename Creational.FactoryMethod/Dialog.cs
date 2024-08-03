using Creational.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod
{
    /// <summary>
    /// La clase creadora declara el metodo fabrica que debe deolver un objeto de una clase producto.
    /// Normalmente, las subclases de la creadora proporcionan la implementacion de este metodo.
    /// </summary>
    public abstract class Dialog
    {
        /// <summary>
        /// La creadora puede proporcionar cierta implemnetaicon por defecto del metodo fabrica.
        /// </summary>
        /// <returns></returns>
        internal abstract IButton CreateButton();

        /// <summary>
        /// Obeservar que, a pesar de su nombre, la principal responsalibilidad  de la creadora no es crear productos. 
        /// Normalmente contiene cierta logica de negocio que depende de los objetos de producto devueltos por el metodo
        /// fabrica. 
        /// Las sublcases pueden cambiar indirectamente esa logica de negocio sobvtresciebiendo el metodo frabrica 
        /// y devolveinde desde el un tipo difernte de producto.
        /// </summary>
        public void Render()
        {
            IButton okButton = CreateButton();

            okButton.OnClick("close");
            okButton.Render(50,25);
        }

      
    }
}
