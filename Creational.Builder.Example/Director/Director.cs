using Creational.Builder.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.Example.Director
{
    public class Director
    {
        public void DoMuzzarella(IPizzaBuilder pBuilder, int Slices)
        {
            pBuilder.Reset();
            pBuilder.SetSlices(Slices);
            pBuilder.SetSauce(true);
            pBuilder.SetCheeses(new string[] {"Muzzarella"} );
            pBuilder.SetName("Muzzarella");
        }

        public void DoSpecial(IPizzaBuilder pizzaBuilder, int Slices)
        {
            pizzaBuilder.Reset();
            pizzaBuilder.SetSlices(Slices);
            pizzaBuilder.SetSauce(true);
            pizzaBuilder.SetCheeses(new string[] { "Muzzarella", "Blue Cheese" });
            pizzaBuilder.SetHam(true);
            pizzaBuilder.SetName("Special");
            pizzaBuilder.SetSilantro(true);

        }

        public void DoChickenPizza(IPizzaBuilder pizzaBuilder, int Slices)
        {
            pizzaBuilder.Reset();
            pizzaBuilder.SetSlices(Slices);
            pizzaBuilder.SetSauce(true);
            pizzaBuilder.SetCheeses(new string[] { "Muzzarella", "Provolone" });
            pizzaBuilder.SetChicken(true);
            pizzaBuilder.SetTomato(true);
            pizzaBuilder.SetName("Chicken");

        }
    }
}
