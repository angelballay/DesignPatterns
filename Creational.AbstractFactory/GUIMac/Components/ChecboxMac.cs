using Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.GUIMac.Components
{
    internal class ChecboxMac : ICheckbox
    {
        public void Paint(bool isChecked)
        {
            if (!isChecked)
            {
                Console.WriteLine("( ) No marcado");
                return;
            }
            Console.WriteLine("(*) Marcado");
        }
    }
}
