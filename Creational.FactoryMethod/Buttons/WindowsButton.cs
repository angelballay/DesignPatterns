using Creational.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod.Buttons
{
    internal class WindowsButton : IButton
    {
        public void OnClick(string pEvent)
        {
            switch (pEvent.ToLower())
            {
                case "close":
                    {
                        Console.WriteLine("Se cierra el dialog con windows");
                        break;
                    }
                case "open":
                    {
                        Console.WriteLine("Se abre el dialog con widnows");
                        break;
                    }

            }
        }

        public void Render(int x, int y)
        {
            Console.WriteLine($"Renderizando boton windows en coordenadas {x}:{y}");
        }
    }
}
