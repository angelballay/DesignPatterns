using Creational.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod.Buttons
{
    internal class HTMLButton : IButton
    {
        public void OnClick(string pEvent)
        {
            switch (pEvent.ToLower())
            {
                case "close":
                    {
                        Console.WriteLine("Se cierra el dialog con HTML");
                        break;
                    }
                case "open":
                    {
                        Console.WriteLine("Se abre el dialog con HTML");
                        break;
                    }

            }
        }

        public void Render(int x, int y)
        {
            Console.WriteLine("Renderiza un boton HTML");
        }
    }
}
