using Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.GUIMac.Components
{
    public class ButtonMac : IButton
    {
        public void Paint(string? text = "")
        {
            Console.WriteLine("   ,--------------------,");
            Console.WriteLine(" /`                      `\\");
            Console.WriteLine("(      *    *MAC*     *   )");
            Console.WriteLine(" \\                      /");
            Console.WriteLine("   '--------------------'");
        }
    }
}
