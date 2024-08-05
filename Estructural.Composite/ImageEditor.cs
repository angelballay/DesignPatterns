using Estructural.Composite.Composite;
using Estructural.Composite.Hojas;
using Estructural.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructural.Composite
{
    /// <summary>
    /// El codigo cliente trabaja con todos los componentes a través de su interfaz base.
    /// De esta forma el codigo cliente puede soportar componentes de jojas simples asi como compuestos complejos.
    /// </summary>
    public class ImageEditor
    {
        private CompoundGraphic all;
    
        public void Load()
        {
            all = new CompoundGraphic();
            all.Add(new Dot(1, 2));
            all.Add(new Circle(4, 4, 2));
            all.Add(new Dot(3, 6));

        }

        public void GroupSeleceted(IList<IGraphic> graphics)
        {
            var group = new CompoundGraphic();
            foreach (var graphicsItem in graphics)
            {
                group.Add(graphicsItem);
                all.Remove(graphicsItem);
            }
            all.Add(group);

            all.Draw();
        }
    }
}
