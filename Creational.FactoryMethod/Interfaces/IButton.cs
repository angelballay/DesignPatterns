using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod.Interfaces
{
    internal interface IButton
    {
        void Render(int x, int y);

        void OnClick(string pEvent);
    }
}
