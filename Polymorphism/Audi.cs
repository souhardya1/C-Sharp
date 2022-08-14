using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Audi:Car
    {
        private string brand = "Audi";
        public string model { get; set; }
        public Audi(int hp, string color, string model) : base(hp, color)
        {

            this.model = model;
        }

        public void showDetails()
        {
            Console.WriteLine(brand + HP + Color);
        }

        public override void repair()
        {
            Console.WriteLine($"Audi {model} is repaired");
        }
    }
}
