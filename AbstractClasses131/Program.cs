using System;

namespace AbstractClasses131
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Shape[] shapes = {new Sphere(5), new Cube(9)}; // array of objects of two classes
            foreach(Shape i in shapes)
            {
                i.GetInfo();
                

                // as keyword to create a variable of a certain type return null if not possible
                if (i as Cube==null)
                {
                    Console.WriteLine("This is a cube class");
                }

                // is keyword to check if a variable is of certain type
                if (i is Sphere)
                {
                    Console.WriteLine("This is a sphere class");
                }

                Console.WriteLine();
            }
        }
    }
}
