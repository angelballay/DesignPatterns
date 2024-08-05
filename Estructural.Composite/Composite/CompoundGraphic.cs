using Estructural.Composite.Interfaces;

namespace Estructural.Composite.Composite
{
    /// <summary>
    /// La clase compuesta representa componentes complejos que pueden tener hijos.
    /// Normalmente los objetos compuestos delegan el trabajo real a susu jijos y despues
    /// "recapitulan" el resultado.
    /// </summary>
    public class CompoundGraphic : IGraphic
    {
        private IList<IGraphic> _children = new List<IGraphic>();

        public CompoundGraphic(IGraphic child)
        {
            _children = [child];
        }

        public CompoundGraphic()
        {
        }

        public void Add(IGraphic child)
        {
            _children.Add(child);
        }

        public void Remove(IGraphic child) 
        {
            _children.Remove(child);
        }

        public void Move(int x, int y)
        {
            _children.ToList().ForEach(
                (item) => item.Move(x, y)
                );
        }

        /// <summary>
        /// Un compuesta ejecuta su logica primaria de una forma particular. Reocrre recurisvamente todos sus hijos
        /// recopilando y recapitulando sus resultados. Debido a que los hijos del compuesto pasan esas llamadas
        /// a sus propios hijos y asi sucecivamente. Se recorre todoe l arbol de objetos como resultado.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Draw()
        {
            //1. Para cad acomponente hijo 
            //   - Dibujar el componente.
            //   - Actualizar el rectangulo delimitador.
            //2. Dibuja un rectangulo de linea punteada utilizando las coordenadas de delimitiación.

            foreach (var item in _children)
            {
                item.Draw();
            }

            Console.WriteLine("Dibujar un RECTANGULO de linea PUNTEADA");
        }

    }
}
