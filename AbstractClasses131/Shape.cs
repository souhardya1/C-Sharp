using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses131
{
    abstract class Shape // we cannot create objects of abstract class
    {
        public string name { get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {name}");
        }

        public abstract double Volume(); // abstract method
    }
}
