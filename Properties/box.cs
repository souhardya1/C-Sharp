using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class box
    {
        private int length=3;
        private int height;
        // public int width;
        public int volume;


        // Not a property but works like a property to see how property works for length
        public void setLength(int length)
        {
            this.length = length;
        }

        public int getLength()
        {
            return this.length;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} and volume is {3} ",length,height,Width,volume = length*height*Width);

        }


        // creating property Height to change height (style 1)
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        // width property creation works same as Height property (style 2)
        public int Width { get;set; }
    }
}
