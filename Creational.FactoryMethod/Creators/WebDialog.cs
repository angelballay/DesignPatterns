using Creational.FactoryMethod.Buttons;
using Creational.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod.Creators
{
    /// <summary>
    /// Los creadores concretos sobrescriben el metodo fabrica para cambiar el tipo de producto resultante.
    /// </summary>
    internal class WebDialog : Dialog
    {
        internal override IButton CreateButton()
        {
            return new HTMLButton();
        }
    }
}
