// See https://aka.ms/new-console-template for more information
using Creative.Prototype;
using Creative.Prototype.ConcretePrototype;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

Console.WriteLine("Hello, World!");

List<Shape> shapes = new List<Shape>();

Circle circle = new Circle();
circle.y = 10;
circle.radius = 25;
circle.x = 20;
circle.Color = "red";

shapes.Add(circle);

Circle AnotherCircle = (Circle)circle.Clone();

shapes.Add(AnotherCircle);

Rectangle rect = new Rectangle();
rect.x = 11;
rect.y = 33;
rect.width = 42;
rect.height = 13;
rect.Color = "black";

shapes.Add(rect);

shapes.Add(rect.Clone());


List<Shape> shapesCopys = new List<Shape>();

//Clonar lista.

foreach (var item in shapes)
{
    shapesCopys.Add(item.Clone());
}



Console.WriteLine("LISTA ORIGINAL:");

for (int i = 0; i < shapes.Count; i++)
{
    Console.WriteLine($"{i}. {shapes[i].GetType().Name} - {JsonConvert.SerializeObject(shapes[i])}");

}

Console.WriteLine("##########################");
Console.WriteLine("LISTA COPIADA");
for (int i = 0; i < shapesCopys.Count; i++)
{
    Console.WriteLine($"{i}. {shapes[i].GetType().Name} -  {JsonConvert.SerializeObject(shapesCopys[i])}");

}

