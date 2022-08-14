using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    internal class Animal
    {

        public string Name { get; set; }
        public int age { get; set; }
        public bool IsHungry { get; set; }

        // constructor
        public  Animal(string Name,int age)
        {
            this .Name = Name;
            this.age = age;
            IsHungry = true;
        }

        // an empty virtual method for other classes to override
        public virtual void MakeSound()
        {

        }

        public  virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine("{0} is eating", Name);
            }
            else
            {
                Console.WriteLine("{0} is not hundgry",Name);
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }


    }
}
