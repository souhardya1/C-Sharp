using System;
using System.Linq;
using System.Collections.Generic;




namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] nums =  {1,2,3,4,5,6,7};
            OddNumber(nums);

        }

        static void OddNumber(int[] nums)
        {
            Console.WriteLine("Odd Numbers: ");
            IEnumerable<int> odds = from i in nums where i % 2 !=0 select i;
            Console.WriteLine(odds);

            foreach(int i in odds)
            {
                Console.WriteLine(i);
            }

        }
    }
}
