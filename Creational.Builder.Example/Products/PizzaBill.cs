using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.Example.Products
{
    public class PizzaBill
    {
        public string Bill {  get; set; }
        public string Name { get; set; }    

        public int Slices {  get; set; }

        public double TotalSlice {  get; set; }

        public double TotalNeto {  get; set; }
        public void AddIngredient(string name, double price)
        {
            TotalSlice += price;
            Bill += $"\n {name} --- ${price}";
            TotalNeto = TotalSlice * Slices;
        }

    }
}
