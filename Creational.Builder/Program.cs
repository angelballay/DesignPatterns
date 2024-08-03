// See https://aka.ms/new-console-template for more information
using Creational.Builder.Builders;
using Creational.Builder.Director;
using Creational.Builder.Products;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");
/*
 * 
 * El uso del patron builder solo tiene sentido cuando tus productos son bastante complejos y requieren una
 * configuracion extensiva. Los productos tienen relacion entre si, aunque no tiene interfaces en comun.
 * 
 * */

MakeCar();

void MakeCar()
{
    Director _director = new Director();

    CarBuilder carBuilder = new CarBuilder();
    CarManualBuilder carManualBuilder = new CarManualBuilder();

    _director.ConstructSportCar(carBuilder);
    _director.ConstructSportCar(carManualBuilder);

    Car mSportCar = carBuilder.GetProduct();
    Manual mManualSportCar = carManualBuilder.GetProduct();
    
    _director.ConstructRegularCar(carBuilder);
    _director.ConstructRegularCar(carManualBuilder);

    Car mRegularCar = carBuilder.GetProduct();
    Manual mManualRegularCar = carManualBuilder.GetProduct();

    // Imprimir detalles de los autos y manuales
    Console.WriteLine("================================");
    Console.WriteLine("Auto Regular");
    Console.WriteLine("================================");
    Console.WriteLine();

    Console.WriteLine();
    Console.WriteLine(JsonConvert.SerializeObject(mRegularCar, Formatting.Indented));
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine();
    Console.WriteLine(mManualRegularCar.ManualContent);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine("Auto Regular");
    Console.WriteLine("================================");
    Console.WriteLine();

    Console.WriteLine();

    Console.WriteLine(JsonConvert.SerializeObject(mSportCar, Formatting.Indented));
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine();
    Console.WriteLine(mManualSportCar.ManualContent);



}