using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses131
{
    internal class Sphere : Shape
    {
        public double radius { get; set; }
        public override double Volume()
        {
            return Math.PI * radius;

        }

        public Sphere(double radius)
        {
            name = "Sphere";
            this.radius = radius;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Its radius is {radius}");
            Console.WriteLine($"Its volume is {Volume()}");
        }
    }
}
