using Estructural.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructural.Composite.Hojas
{
    /// <summary>
    /// Todas las clases de compnenten pueden extender otros componentes.
    /// </summary>
    public class Circle : Dot
    {
        private int radius;
        public Circle(int x, int y, int radius) : base(x, y){
            this.radius = radius;
        }
        public new void Draw()
        {
            Console.WriteLine($"Dibuja un CIRCULO en x: {this.x}, y: {this.y}, radius: {radius}");
        }

       
    }
}
