using Estructural.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructural.Composite.Hojas
{
    /// <summary>
    /// La clase hoja representa objetos finales de una composicion.
    /// Un objeyo hoja  no puede tener ningun subobjeto. Normlamente, son los objetos hojas los que hacen el trabajo real.
    /// minetras los objetos compuestos se limitan a delegar a sus subcomponentes.
    /// </summary>
    public class Dot : IGraphic
    {
        internal int x;
        internal int y;

        public Dot(int x, int y)
        { 
                this.x = x;
                this.y = y;
        }
        public void Draw()
        {
            Console.WriteLine($"Dibuja un PUNTO en x: {this.x}, y: {this.y}");
        }

        public void Move(int x, int y)
        {
            Console.WriteLine($"Se mueve el Punto a {x} {y}");
            this.x = x; this.y = y;
        }
    }
}
