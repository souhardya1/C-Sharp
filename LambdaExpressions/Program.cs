using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            string[] dogs = { "Tommy", "Jimmy", "Dudu", "Tuffy", "Pom", "Dollar", "Shiro", "Pluto" };
            List<int> numbers = new List<int>() { 5, 6, 8, 2, 09, 1, 4, 2, 5, 2, 0, 234, 6, 423, 4, 623, 4, 76, 35, 4, 326, 521, 65, 123 };
            object[] mix = { 1, "string", 'd', new List<int>() { 2, 4, 6, 1 }, new List<int>() { 3, 9, 5, 1 }, "popo", 'a', 88 , 5, 8, 94 ,3};
            List<Warriors> warriors = new List<Warriors>()
            {
                new Warriors() {Name = "Spartan", Height = 199},
                new Warriors() {Name = "Prince", Height = 170},
                new Warriors() {Name = "Alexander", Height = 200},
                new Warriors() {Name = "Barbador", Height = 230},
                new Warriors() {Name = "Archer", Height = 157},

            };

            // using foreach loop
            Console.WriteLine("Foreach Loop Odds");
            foreach(var n in numbers)
            {
                if (n % 2 == 1)
                {
                    Console.Write( n + " ");
                }
            }
            Console.WriteLine();

            // using LinQ
            var LinqOdds = from n in numbers 
                       where n % 2 == 1
                       select n;
            Console.WriteLine("Linq Odds: "+ string.Join(",",LinqOdds));

            // using Lambda
            var LambdaOdds = numbers.Where(n => (n % 2 == 1));
            Console.WriteLine("Lambda Odds: "+ string.Join(",", LambdaOdds));

            // Lambda Methods
            double average = numbers.Average(n => n);
            double sum = numbers.Sum(n => n);
            double maxint = numbers.Max(n => n);
            double minint = numbers.Min(n => n);
            double dogLengthAverage = dogs.Average(d => d.Length);
            
            Console.WriteLine($"The Average is: {average}");
            Console.WriteLine($"The Sum is: {sum}");
            Console.WriteLine($"The Maxint is: {maxint}");
            Console.WriteLine($"The Minint is: {minint}");
            Console.WriteLine($"The Average of dog's name length is: {dogLengthAverage}");

            // Find a Type
            var allIntElements = mix.OfType<int>();
            var intLessThanTen = mix.OfType<int>().Where(i => i < 10);
            var listofInt = mix.OfType<List<int>>().ToList();

            Console.WriteLine("All int  from Mix: " + (string.Join(",", allIntElements)));
            Console.WriteLine("All int less than ten: "+(string.Join(",",intLessThanTen)));
            Console.WriteLine("List of Integers in mix are: ");
            foreach(var e in listofInt)
            {
                foreach(var i in e)
                {
                    Console.Write(i.ToString()+", ");
                }
                Console.WriteLine();
            }

            // Select vs Where
            var shortWarriors = warriors.Where(w => w.Height<200).Select(wh => wh.Name);
            Console.WriteLine("Short Warriors Are: " + string.Join(",",shortWarriors));

            // Lamda ForEach
            warriors.ForEach(w => Console.WriteLine("Name is: " + w.Name + " and Height is " + w.Height));



        }
    }
}