using System;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside Main method");
            Operator();

            string inp1 = Console.ReadLine();
            string inp2 = Console.ReadLine();


            try
            {
                int num1=int.Parse(inp1);
                int num2=int.Parse(inp2);

                Console.WriteLine("return result of single add method: " + add(num1, num2));
            }

            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number");
            }

            finally
            {
                Console.WriteLine("This will be called anyways");
            }

            Console.WriteLine("Method inside a method: " + add(add(5, 5), add(5, 3)));

        }

        public static void Operator()
        {
            Console.WriteLine("Inside Operator method");
            int num1 = 7;
            int num2 = 5;

            //unary operator
            int num3 = -num1;
            Console.WriteLine(num3);

            // not operator
            bool what = true;
            Console.WriteLine("What is: "+!what);

            // increment operators
            num1++;
            Console.WriteLine("num1 is "+ num1); // 8
            Console.WriteLine("num1 is "+ num1++); // 8 as first print then increment
            Console.WriteLine("num1 is " + ++num1); // 10 (8+1) from previous (9+1) now


            // decrement operator
            num1--;
            Console.WriteLine("num1 is " + num1); // 9
            Console.WriteLine("num1 is " + num1--); // 9 as first print then increment
            Console.WriteLine("num1 is " + --num1); // 7 (9-1) from previous (8-1) now

        }

        public static int add(int num1,int num2)
        {
            Console.WriteLine("Inside add method");
            int result = num1 + num2;
            return result;
        }




    }
}
