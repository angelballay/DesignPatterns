// See https://aka.ms/new-console-template for more information
using Creational.Builder.Example.Builders;
using Creational.Builder.Example.Director;
using Creational.Builder.Example.Products;
using Newtonsoft.Json;
using System.Xml;

Console.WriteLine("Hello, World!");


Director _director = new Director();

PizzaBuilder _builderPizza = new PizzaBuilder();
PizzaBillBuilder _builderBillPizza = new PizzaBillBuilder();

_director.DoMuzzarella(_builderPizza, 4);
_director.DoMuzzarella(_builderBillPizza, 4);

Pizza muzza = _builderPizza.GetProduct();
PizzaBill muzzaBill = _builderBillPizza.GetProduct();

_director.DoSpecial(_builderBillPizza, 8);
_director.DoSpecial(_builderPizza, 8);

Pizza special =  _builderPizza.GetProduct();
PizzaBill specialBill =  _builderBillPizza.GetProduct();

_director.DoChickenPizza(_builderBillPizza, 8);
_director.DoChickenPizza(_builderPizza, 8);

Pizza chickenPizza = _builderPizza.GetProduct();
PizzaBill chickenPizzaBill = _builderBillPizza.GetProduct();


// Imprimir detalles de los autos y manuales
Console.WriteLine("================================");
Console.WriteLine("MUZZARELLA");
Console.WriteLine("================================");
Console.WriteLine();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("===============BILL=================");
Console.WriteLine();
Console.WriteLine("TOTAL POR PORCION : " + muzzaBill.Bill);
Console.WriteLine("PORCIONES: " + muzzaBill.Slices);
Console.WriteLine("TOTAL NETO : $" + muzzaBill.TotalNeto);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("================================");
Console.WriteLine("SPECIAL");
Console.WriteLine("================================");
Console.WriteLine();
Console.WriteLine("===============BILL=================");
Console.WriteLine();
Console.WriteLine("TOTAL POR PORCION : " + specialBill.Bill);
Console.WriteLine("PORCIONES: " + specialBill.Slices);
Console.WriteLine("TOTAL NETO : $" + specialBill.TotalNeto);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("================================");
Console.WriteLine("CHIKEN");
Console.WriteLine("================================");
Console.WriteLine();
Console.WriteLine("===============BILL=================");
Console.WriteLine();
Console.WriteLine("TOTAL POR PORCION : "+ chickenPizzaBill.Bill);
Console.WriteLine("PORCIONES: " + chickenPizzaBill.Slices);
Console.WriteLine("TOTAL NETO : $" + chickenPizzaBill.TotalNeto);


