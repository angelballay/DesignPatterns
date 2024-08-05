using Estructural.Composite.OtherExample.Interface;

namespace Estructural.Composite.OtherExample.Hojas
{
    public class Factura : Element
    {
        public DateTime Date { get; set; }  
        public string Description {  get; set; }
        public string Vendedor { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Description} con un total de ${this.Costo} vendido por {Vendedor}";
        }

        public Factura(string name, double costo, DateTime date, string description, string vendedor) : base(name, costo)
        {
            this.Date = date;
            this.Description = description;
            this.Vendedor = vendedor;
        }
    }
}
