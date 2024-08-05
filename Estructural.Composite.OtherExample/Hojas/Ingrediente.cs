using Estructural.Composite.OtherExample.Interface;

namespace Estructural.Composite.OtherExample.Hojas
{
    public class Ingrediente : Element
    {
        public int cantidad { get; set; }
        public string unidad { get; set; }

        public override string ToString()
        {
            return $"{Name} - {cantidad} {unidad} = ${Costo}";
        }
        public Ingrediente(string name, double costo, int cantidad, string unidad) : base(name, costo)
        {
            this.cantidad = cantidad;
            this.unidad = unidad;
        }
    }
}
