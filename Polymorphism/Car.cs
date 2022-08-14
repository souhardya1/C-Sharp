using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        //Has a relationship
        protected CarIDInfo carIDinfo =  new CarIDInfo();

        public void SetCarIDInfo(int idnum,string owner)
        {
            carIDinfo.IDnum = idnum;
            carIDinfo.owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine($"The car owner is {carIDinfo.owner} and id is {carIDinfo.IDnum} ");
        }

        public Car()
        {

        }
        public Car(int HP,string Color)
        {
            this.HP = HP;
            this.Color = Color;
        }

        public  void showDetails()
        {
            Console.WriteLine(this.HP+" "+this.Color);
        }

        public virtual void repair()
        {
            Console.WriteLine("Car is repaired");
        }


    }
}
