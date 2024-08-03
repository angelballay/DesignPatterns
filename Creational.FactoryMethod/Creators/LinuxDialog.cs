using Creational.FactoryMethod.Buttons;
using Creational.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod.Creators
{
    internal class LinuxDialog : Dialog
    {
        internal override IButton CreateButton()
        {
            return new LinuxButton();
        }
    }
}
