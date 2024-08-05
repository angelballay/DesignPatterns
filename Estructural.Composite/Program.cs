using Estructural.Composite.Hojas;
using Estructural.Composite.Interfaces;

namespace Estructural.Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var editor = new ImageEditor();

            editor.Load();
            editor.GroupSeleceted(new List<IGraphic> { new Dot(1, 5), new Circle(2, 3, 2) });
        }
    }
}
