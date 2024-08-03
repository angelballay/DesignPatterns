// See https://aka.ms/new-console-template for more information
using Creational.Singleton;

Console.WriteLine("Hello, World!");


DataBase db = DataBase.Instance();

db.Query("SELECT * FROM TU VIEJA");

