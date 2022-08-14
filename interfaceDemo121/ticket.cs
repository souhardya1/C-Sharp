using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceDemo121
{
    internal class ticket : IEquatable<ticket>
    {
        public int duration { get; set; }

        //constructor
        public ticket(int duration)
        {
            this.duration = duration;
        }

        public bool Equals(ticket other)
        {
            return this.duration == other.duration;
        }
    }

}
