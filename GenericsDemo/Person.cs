using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Person: IComparable<Person>
    {
        public int Age { get; set; }

        public int CompareTo(Person? other)
        {
            if (other == null) return -999999999;
            if(this.Age < other.Age) { return -1; }
            else if(this.Age == other.Age) { return 0; }
            else { return 1; }      
        }
    }
}
