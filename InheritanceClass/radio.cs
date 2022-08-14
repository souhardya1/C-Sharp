using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClass
{
    // radio is inheriting from electrical device
    internal class radio:electricalDevice
    {

       
       // constructor with the base class
       // it basically says whatever parent has send it to child's constructor parameter
        public radio(bool IsOn,string Brand):base(IsOn,Brand)
        {
            this.IsOn = IsOn;
            this.Brand = Brand;
        }

      
        public void ListenToRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to radio");
            }

            else
            {
                Console.WriteLine("Radio is off. Please switch it on first");
            }
        }
    }
}
