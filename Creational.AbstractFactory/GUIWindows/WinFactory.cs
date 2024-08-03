using Creational.AbstractFactory.GUIWindows.Components;
using Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.GUIWindows
{
    /// <summary>
    /// Las fabricas concretas producen una familia de productos que pertencen a una unica variante. 
    /// La fabrica garantiza que los producots resultantes sean compatibles. Las firmas d elos metodos de las fabricas
    /// concretas devuelven un producto abtracto mientras   que dentro del metodo se instaan un producto concreto.
    /// Cada fabrica concreta tiene una variante de producto correspondiente.
    /// 
    /// </summary>
    public class WinFactory : IGUIFactory
    {
        /// <summary>
        /// Los metodos virtuales pueden ser extendidos y sobreescritos por una subclase sin necesidad que la clase sea abstracta.
        /// </summary>
        /// <returns></returns>
        public virtual IButton  CreateButton()
        {
            return new ButtonWin();
        }

        public virtual ICheckbox CreateCheckbox()
        {
            return new ChexboxWin();
        }
    }
}
