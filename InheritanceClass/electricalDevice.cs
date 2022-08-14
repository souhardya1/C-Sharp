using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClass
{
    // parent or base class
    internal class electricalDevice
    {
        public bool IsOn { get; set; }

        // string for the brand name of electricalDevice
        public string Brand { get; set; }

        public electricalDevice(bool IsOn, string Brand)
        {
            this.IsOn = IsOn;
            this.Brand = Brand;
        }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }

        public void Use()
        {
            if (IsOn)
            {
                Console.WriteLine("Using the device");
            }

            else
            {
                Console.WriteLine("Device is off. Please switch it on first");
            }
        }
    }
}
