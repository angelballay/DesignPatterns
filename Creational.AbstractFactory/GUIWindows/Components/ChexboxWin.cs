using Creational.AbstractFactory.Interfaces;

namespace Creational.AbstractFactory.GUIWindows.Components
{
    public class ChexboxWin : ICheckbox
    {
        public void Paint(bool isCheked)
        {
            if (isCheked)
            {
                Console.WriteLine("[X] Marcado");
                return;

            }
                Console.WriteLine("[ ] No marcado");

        }
    }
}
