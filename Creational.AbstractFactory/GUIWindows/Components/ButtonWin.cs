using Creational.AbstractFactory.Interfaces;

namespace Creational.AbstractFactory.GUIWindows.Components
{
    internal class ButtonWin : IButton
    {
        /// <summary>
        /// Los productos concretos son creados por las frabricas concretas correspondientes.
        /// </summary>
        /// <param name="Text"></param>
        public virtual void Paint(string? Text = "")
        {
            Console.WriteLine("Botón estilo Windows:");
            Console.WriteLine("╔════════════════════════╗");
            Console.WriteLine("║  [        ]            ║");
            Console.WriteLine($"║  [ {Text} ] ===>        ║");
            Console.WriteLine("║  [        ]            ║");
            Console.WriteLine("╚════════════════════════╝");
            Console.WriteLine();
        }

       
    }
}
