using Creational.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod.Buttons
{
    internal class LinuxButton : IButton
    {
        public void OnClick(string pEvent)
        {
            Console.WriteLine($"Se agrega evento {pEvent} al  click del boton Linux");
        }

        public void Render(int x, int y)
        {
            Console.WriteLine($"Renderizando boton LINUX en coordenadas {x}:{y}");
        }
    }
}
