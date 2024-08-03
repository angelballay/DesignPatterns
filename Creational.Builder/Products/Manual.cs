using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.Products
{
    public class Manual
    {
        public string ManualContent { get; set; }

        public void AddChapter(string chapter)
        {
            this.ManualContent += $"\n {chapter}";
        }
    }
}
