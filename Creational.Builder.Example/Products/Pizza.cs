using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.Example.Products
{
    public class Pizza
    {
        public string[] Cheeses {  get; set; }
        public int Slices { get; set; }
        public bool Eggs {  get; set; }
        public bool Salami {  get; set; }
        public string Name { get; set; }
        public bool Ham {  get; set; }
        public bool Chicken {  get; set; }

        public bool Sauce {  get; set; }
        public bool Tomato {  get; set; }

        public bool Silantro {  get; set; }

        public string Ingredients()
        {
            var ingredients = new List<string>();

            if (Cheeses != null && Cheeses.Length > 0)
            {
                ingredients.AddRange(Cheeses);
            }

            if (Eggs)
            {
                ingredients.Add("Eggs");
            }
            if (Salami)
            {
                ingredients.Add("Salami");
            }
            if (Ham)
            {
                ingredients.Add("Ham");
            }
            if (Chicken)
            {
                ingredients.Add("Chicken");
            }
            if (Sauce)
            {
                ingredients.Add("Sauce");
            }
            if (Tomato)
            {
                ingredients.Add("Tomato");
            }
            if (Silantro)
            {
                ingredients.Add("Silantro");
            }

            return $"La pizza {Name} tiene los siguientes Ingredientes: " + string.Join(", ", ingredients) + $"{Slices} porciones";
        }

    }
}
