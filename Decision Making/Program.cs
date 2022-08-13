using System;

namespace Decision_Making
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is today's temp?");
            string inp = Console.ReadLine();
            int num;
            int temp;
            /* if parsing is succeeded to int then int.TryParse will return true
             and parsed integer will be stored to num */
            if (int.TryParse(inp, out num)) 
            {
                 temp = num;
            }
            else
            { 
                temp = 0;
                Console.WriteLine("Input number was not integer, temp value set to 0");

            }

            
            if (temp < 20)
            {
                Console.WriteLine("temp is {0}, stay at home",temp);
            }
            else if (temp > 20 && temp < 30)
            {
                Console.WriteLine("temp is {0}, go out",temp);
            }
            else
            {
                Console.WriteLine("temp is {0},stay inside", temp);
            }
        }

      
    }
}
