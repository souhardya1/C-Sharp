using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 1;

            // for loop
            for (int i = 0; i< 10; i++)
            {
                Console.WriteLine("For Loop: "+i);
            }

            // while loop
            while (num1<20){
                Console.WriteLine("While Loop: "+num1);
                num1++;
            }

            // do while loop
            do
            {
                Console.WriteLine("Do While Loop: " + num2);
            } while (num2 > 20);

            // break and continue
            while (true)
            {

                num3++;
                if (num3 == 5)
                {
                    Console.WriteLine("at 5 we skip");
                    
                    continue;
                    
                }
                    
                if (num3 == 7)
                    break;

                Console.WriteLine("break n continue: " + num3);
                

            }

        }
    }
}
