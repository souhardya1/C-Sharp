using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClass
{
    internal class tv:electricalDevice
    {
        
        public tv(bool IsOn, string Brand):base(IsOn, Brand)
        {
            
        }

        

        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching TV");
            }

            else
            {
                Console.WriteLine("TV is off. Please switch it on first");
            }
        }
    }
}
