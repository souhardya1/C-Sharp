using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo117
{
    internal class Post
    {
        private static int currentPostId;

        //properties
        protected int ID { get; set; }
        protected string title { get; set; }
        protected string sendByUsername { get; set; }
        protected bool isPublic { get; set; }


        /* 
         default constructo. If a derived class does not invoke a base class
         constructor explicitely then default constructor is called implicitely
        */
        public Post()
        {
            ID = 0;
            title = "My FIrst Post";
            sendByUsername = "Souhardya";
            isPublic = true;
        }

        // instance constructor with different number of parameters
        public Post(string title,bool isPublic, string sendByUsername)
        {
            this.ID = getNextID();
            this.title = title;
            this.sendByUsername = sendByUsername;
            this.isPublic = isPublic;
        }

        protected int getNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title,bool isPublic)
        {
            this.title = title;
            this.isPublic=isPublic;
        }

        public virtual void info()
        {
            Console.WriteLine("{0}   {1}    {2} ", this.ID, this.title, this.sendByUsername);
        }
    }
}
