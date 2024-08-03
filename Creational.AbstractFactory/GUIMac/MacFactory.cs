using Creational.AbstractFactory.GUIMac.Components;
using Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.GUIMac
{
    /// <summary>
    /// Las fabricas concretas producen una familia de productos que pertencen a una unica variante. 
    /// La fabrica garantiza que los producots resultantes sean compatibles. Las firmas d elos metodos de las fabricas
    /// concretas devuelven un producto abtracto mientras   que dentro del metodo se instaan un producto concreto.
    /// </summary>
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new ButtonMac();
        }

        public ICheckbox CreateCheckbox()
        {
            return new ChecboxMac();
        }
    }
}
