using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses131
{
    internal class Cube : Shape
    {
        public double length { get; set; }

        
        public Cube(double length)
        {
            name = "Cube";
            this.length = length;
        }
        public override double Volume()
        {
            return Math.Pow(length, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Its length is {length}");
            Console.WriteLine($"Its volume is {Volume()}");
        }
    }
}
