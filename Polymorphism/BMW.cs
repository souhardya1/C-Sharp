using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class BMW:Car
    {
        private string brand = "BMW";
        public string model { get; set; }

        public BMW()
        {

        }
        public BMW(int hp,string color,string model):base(hp,color)
        {
           
           this.model = model;
        }
        
        public new void showDetails()
        {
            Console.WriteLine(brand+HP+Color);
        }

        public sealed override void repair()
        {
            Console.WriteLine($"BMW {model} is repaired");
        }
        
    }
}
