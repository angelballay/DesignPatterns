using Creational.Builder.Example.Interfaces;
using Creational.Builder.Example.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.Example.Builders
{
    public class PizzaBillBuilder : IPizzaBuilder
    {
        private PizzaBill _bill;

        public PizzaBillBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            _bill = new PizzaBill();
        }

        public PizzaBill GetProduct()
        {
            PizzaBill mBill = _bill;
            this.Reset();
            return mBill;
        }

        public void SetCheeses(string[] cheeses)
        {
            cheeses.ToList<string>().ForEach(cheese =>
            {
                _bill.AddIngredient(cheese, 1.0);
            });
        }

        public void SetChicken(bool chicken)
        {
            _bill.AddIngredient("Chicken", 2);
        }

        public void SetEggs(bool eggs)
        {
            _bill.AddIngredient("Eggs", 0.5);
        }

        public void SetHam(bool ham)
        {
            _bill.AddIngredient("Ham", 0.8);
        }

        public void SetName(string name)
        {
            _bill.Name = name;
        }

        public void SetSalami(bool salami)
        {
            _bill.AddIngredient("salami", 0.8);
        }

        public void SetSauce(bool sauce)
        {
            _bill.AddIngredient("sauce", 0);
        }

        public void SetSilantro(bool silantro)
        {
            _bill.AddIngredient("silantro", 0.25);
        }

        public void SetSlices(int slices)
        {
            _bill.Slices = slices;
        }

        public void SetTomato(bool tomato)
        {
            _bill.AddIngredient("tomato", 0.5);
        }
    }
}
