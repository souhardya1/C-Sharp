using System;

namespace ObjectOrientedProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an object of my class
            // an instance of Human
            Human me = new Human("Souhardya","Charaborty","black",22);

            // access public variable from outside and even change it
            /*me.firstName = "Souhardya";*/

            //call methods of class
            me.introduce();

            Human you = new Human("Purbasha", "Ghosh", 21);// calls constructor with 3parameter and age
            you.introduce();


            Human friend1 = new Human(); // calls default constructor
            friend1.introduce();

            Human friend2 =  new Human("Bubu","Sordar","blue"); // calls constructor with 3parameter and eyecolor 
            friend2.introduce();




        }
    }
}
