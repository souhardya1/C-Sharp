using System;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            box box = new box();


            box.Width = 5;  // setting Width variable

            // box.height = 6; // height is not settable because its not public
            box.Height = 5; // we are setting value to Height property not height variable

            // box.length = 4; // length is not setable because its not public,protected
            // Console.WriteLine("length is"+box.length); // length is not getable because its not public,protected


            box.setLength(7); //setter
            Console.WriteLine("Length is "+box.getLength()); // getter
            box.DisplayInfo();
        }
    }
}
