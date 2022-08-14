using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    // class is a blueprint
    internal class Human
    {
        //member variable
        private string firstName="default first name";
        private string lastName="default last name";
        private string eyeColor="default Colour";
        private int age;


        // default constructor
        public Human()
        {
            Console.WriteLine("Inside defualt constructor");
        }

        // 1 parameter constructor
        public Human(string myfirstName)
        {
            Console.WriteLine("Inside 1 parameter constructor.");
            firstName = myfirstName;
        }

        // 2 parameter constructor
        public Human(string myfirstName, string lastName)
        {
            Console.WriteLine("Inside 2 parameter constructor.");
            firstName = myfirstName;
            this.lastName = lastName; //this key refers to global variable
   
        }

        // 3 parameter construtor
        public Human(string myfirstName, string lastName, string eyeColor)
        {
            Console.WriteLine("Inside 3 parameter constructor.");
            firstName = myfirstName;
            this.lastName = lastName; //this key refers to global variable
            this.eyeColor = eyeColor;
        }

        // 3 parameter construcor with age
        public Human(string myfirstName, string lastName, int age)
        {
            Console.WriteLine("Inside 3 parameter constructor with age.");
            firstName = myfirstName;
            this.lastName = lastName; //this key refers to global variable
            this.age = age;
        }
        // 4 parameter constructor
        public Human(string myfirstName,string lastName,string eyeColor, int age)
        {
            Console.WriteLine("Inside 4 parameter constructor.");
            firstName=myfirstName;
            this.lastName = lastName; //this key refers to global variable
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // member
        public void introduce()
        {
            Console.WriteLine("Hi I am {0} {1} and {3} years old and my eye color is {2}",firstName,lastName,eyeColor,age);
        }
    }
}
