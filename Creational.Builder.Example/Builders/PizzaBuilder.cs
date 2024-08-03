using Creational.Builder.Example.Interfaces;
using Creational.Builder.Example.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.Example.Builders
{
    public class PizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza;

        public PizzaBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            _pizza = new Pizza();
        }

        public Pizza GetProduct()
        {
            Pizza mPizza = _pizza;
            this.Reset();
            return mPizza;  
        }
        public void SetCheeses(string[] cheeses)
        {
            _pizza.Cheeses = cheeses;
        }

        public void SetChicken(bool chicken)
        {
            _pizza.Chicken = chicken;
        }

        public void SetEggs(bool eggs)
        {
            _pizza.Eggs = eggs;
        }

        public void SetHam(bool ham)
        {
            _pizza.Ham = ham;
        }

        public void SetName(string name)
        {
            _pizza.Name = name;
        }

        public void SetSalami(bool salami)
        {
           _pizza.Salami= salami;
        }

        public void SetSauce(bool sauce)
        {
            _pizza.Sauce= sauce;
        }

        public void SetSilantro(bool silantro)
        {
            _pizza.Silantro = silantro;
        }

        public void SetSlices(int slices)
        {
            _pizza.Slices = slices;
        }

        public void SetTomato(bool tomato)
        {
            _pizza.Tomato = tomato;
        }
    }
}
