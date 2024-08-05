using Estructural.Composite.OtherExample.Composite;
using Estructural.Composite.OtherExample.Hojas;
using Estructural.Composite.OtherExample.Interface;

namespace Estructural.Composite.OtherExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CREACION DE FACTURA");

            FactureComposite FactureComposite = new FactureComposite("Factura B - Manufactura y mano de obra",2000);

            Element factura1 = new Factura("Factura por arreglo del techo", 100, DateTime.Now, "Se arreglo la tapadera del techo", "Carlitos");
            Element factura2 = new Factura("Factura por arreglo del parachoques", 200, DateTime.Now, "Se arreglo el parachoque", "Carlitos");
            Element factura3 = new Factura("Chapa y pintura", 1500, DateTime.Now, "Se lo hizo de cero una joyita quedo", "Don humberto");

            Console.WriteLine("Se añaden las siguientes Facturas al Facture Composite");
            Console.WriteLine(factura1.ToString());
            Console.WriteLine(factura2.ToString());
            Console.WriteLine(factura3.ToString());

            FactureComposite.AddElement(factura1);
            FactureComposite.AddElement(factura2);
            FactureComposite.AddElement(factura3);

            Console.WriteLine("Se calculara el total de la factura y sus subfacturas...");

            var total = FactureComposite.GetTotal();

            Console.WriteLine("El total es igual a $"+total+" y cuenta con "+FactureComposite.Count + " Facturas");

            var a = Console.ReadLine();

            Console.WriteLine("Creación de Pizza");

            Element ingrediente1 = new Ingrediente("Prepizza", 500, 1, "unidad");
            Element ingrediente2 = new Ingrediente("Salsa", 400, 200, "gramos");
            Element ingrediente3 = new Ingrediente("Queso Muzzarella", 1600, 300, "gramos");

            Console.WriteLine("Se añaden los siguientes ingrediente1 al Pizza Composite");
            Console.WriteLine(ingrediente1.ToString());
            Console.WriteLine(ingrediente2.ToString());
            Console.WriteLine(ingrediente3.ToString());
            CostComposite Pizza = new PizzaComposite("pizza Muzzarella");

            Pizza.AddElement
                (ingrediente1);
            Pizza.AddElement (ingrediente2);
            Pizza.AddElement(ingrediente3);

            Console.WriteLine("Costo de la pizza");
            Console.WriteLine(Pizza.GetTotal());

            Console.WriteLine("Factura de Pizzas");



        }
    }
}
