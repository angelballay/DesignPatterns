// See https://aka.ms/new-console-template for more information


using Creational.AbstractFactory.GUIMac;
using Creational.AbstractFactory.GUIWindows;
using Creational.AbstractFactory.GUIWindows.Components;
using Creational.AbstractFactory.Interfaces;
using static System.Net.Mime.MediaTypeNames;

IGUIFactory? _factory;
IGUIFactory _factoryMAC;
IGUIFactory? _factoryRain;

IButton _button;
ICheckbox _checkbox;

ConfigOs _configOS = new ConfigOs { OS = "windows", Version="rain"};

InitializeGUI();

RenderCatalog();

void RenderCatalog()
{
    List<IGUIFactory> factorys = new List<IGUIFactory>();

    factorys.Add(_factory);
    factorys.Add(_factoryMAC);
    factorys.Add(_factoryRain);

    Console.WriteLine("===============================");
    Console.WriteLine("Catalogo de Compoentes GUI");
    Console.WriteLine("===============================");

    factorys.ForEach(factory =>
    {
        Console.WriteLine($"Catalogo: {factory.GetType().Name.ToString()}");
        Console.WriteLine("Boton");
        factory.CreateButton().Paint();
        Console.WriteLine("===============================");
        Console.WriteLine();
        Console.WriteLine("chexbox");
        factory.CreateCheckbox().Paint(true);
        factory.CreateCheckbox().Paint(false);

        Console.WriteLine("===============================");
        Console.WriteLine("===============================");
        Console.WriteLine();
        Console.WriteLine();

    });
}

void InitializeGUI()
{
    _factory = new WinFactory();
    _factoryMAC = new MacFactory();
    _factoryRain = new WinFactoryRain();
}



class ConfigOs
{
    public string OS { get; set;}
    public string Version { get; set;}  
}



internal class WinFactoryRain : WinFactory
{
    public override IButton CreateButton()
    {
        return new ButtonWindosRain();
    }
}
internal class ButtonWindosRain : ButtonWin
{
    public override void Paint(string? text = "")
    {
        Console.WriteLine("Botón estilo Windows Rain:");
        Console.WriteLine("╔═-----------------------╗");
        Console.WriteLine("|                        |");
        Console.WriteLine($"|          {text}       m|");
        Console.WriteLine("|                        |");
        Console.WriteLine("╚-----------------------═╝");
        Console.WriteLine();
    }
}