using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo117
{
    internal class imagePost:Post
    {
        public string ImageURL { get; set; }
        public imagePost()
        {

        }

        public imagePost(string title,string sendByUsername,string imageURL, bool isPublic)
        {
            // these properties are inherited from parent
            this.ID = getNextID();
            this.title = title;
            this.sendByUsername = sendByUsername;
            this.isPublic = isPublic;

            //this is its own not parent's
            this.ImageURL = imageURL;
        }

        public override void info()
        {
            Console.WriteLine("{0}   {1}    {2}    {3}", this.ID, this.title, this.sendByUsername,this.ImageURL);
        }

    }
}
