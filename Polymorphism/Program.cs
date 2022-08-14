using System;
using System.Collections.Generic;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "blue", "R8"),
                new BMW(250, "white", "M3")
            };

            foreach (var i in cars)
            {
                i.repair();
            }

            Car bmw1 = new BMW(100, "black", "z3");
            Car audi1 = new Audi(101, "Red", "A3");

            bmw1.showDetails();
            audi1.showDetails();

            BMW bmw2 = new BMW(330, "white", "popo");
            bmw2.showDetails(); // show details of bmw has been called as we used new keyword so it prioritised bmw.showdetails than car.showdetails

             M3 mym3 = new M3(260, "red", "M3 super turbo");
            // mym3.repair();
            // wont work as bmw class has sealed repair and it restricts m3 class to override .repair

            bmw2.SetCarIDInfo(1001,"Souhardya");
            audi1.SetCarIDInfo(1002, "Purbasha");

            bmw2.GetCarIDInfo();



        }

    }
}

