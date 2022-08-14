using System;

namespace VirtualOverrideDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Dollar", 1);
            Console.WriteLine(dog);
            Console.WriteLine($"Dog name is {dog.Name} and he is {dog.age} years old");
            dog.Play();
            dog.Eat();
            dog.MakeSound();

        }
    }
}
