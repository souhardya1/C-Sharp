using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    internal class Dog:Animal
    {
        public bool IsHappy { get; set; }

        public Dog(string Name,int age) : base(Name, age)
        {
            IsHappy = true;
        }

        // virtual in parent class allows child to use override keyword
        public override void Eat()
        {
            // it says to call the eat method of base class
            base.Eat();

        }

        public override void MakeSound()
        {
            // since every animal will make a totally different sound each animal will implemetn its own version
            Console.WriteLine("A Dog Will Bark!!");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
            else
            {
                Console.WriteLine("Dog is not happy");
            }
            
        }
    }
}
