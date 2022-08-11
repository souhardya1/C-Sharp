using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String
            string name = "Souhardya";
            Console.WriteLine(name);

            // string length
            Console.WriteLine(name.Length);

            // Uppercase
            Console.WriteLine(name.ToUpper());

            // LowerCase
            Console.WriteLine(name.ToLower());

            // take input and print
            string inp = Console.ReadLine();
            Console.WriteLine(inp);

            // to string conversion
            double doubleval = 13.37;
            string doublestring = doubleval.ToString();
            Console.WriteLine(doublestring);

            // parse string
            string strint = "14";
            string strint2 = "16";
            int intstr = Int32.Parse(strint);
            int intstr2 = Int32.Parse(strint2);
            Console.WriteLine(intstr2+intstr);

            //string concat
            int age = 17;
            Console.WriteLine("Hi my name is "+ name + " I am "+ age +" years old");

            // string formatting
            Console.WriteLine("Hi my name is {0} and I am {1} years old",name,age);

            //  substring
            Console.WriteLine(name.Substring(1)); // 1 to len(str)
            Console.WriteLine(name.Substring(1,4)); // including 4
            Console.WriteLine(name.Substring(1,1));

            // remove first and last white spaces
            string gb = "       good boy       ";
            Console.WriteLine(gb.Trim());

            // first occurance of a character
            Console.WriteLine(name.IndexOf("o"));
            Console.WriteLine(name.IndexOf("O"));
            /* case sensitive and returns -1 if not found */
        }
    }
}
