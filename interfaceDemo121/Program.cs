using System;

namespace interfaceDemo121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ticket t1 = new ticket(10);
            ticket t2 = new ticket(10);
            Console.WriteLine(t1.Equals(t2));
        }
    }
}
