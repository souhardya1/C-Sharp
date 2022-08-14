using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritanceDemo117
{
    internal class VideoPost:Post
    {
        //member field
        protected bool isPlaying=false;
        protected int currDuration;
        Timer timer;

        //properties
        public string videoURL { get; set; }
        public int vidlength { get; set; }
        public VideoPost()
        {

        }


        public VideoPost(string title, string sendByUsername, string imageURL, bool isPublic,int vidLength)
        {
            // these properties are inherited from parent
            this.ID = getNextID();
            this.title = title;
            this.sendByUsername = sendByUsername;
            this.isPublic = isPublic;

            //this is its own not parent's
            this.videoURL = videoURL;
            this.vidlength = vidLength;
        }

        public override void info()
        {
            Console.WriteLine("{0}   {1}    {2}    {3}    {4}", this.ID, this.title, this.sendByUsername, this.videoURL,this.vidlength);
        }

        public void play()
        {
            if (!this.isPlaying)
            {
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
            
        }

        private void TimerCallback(Object o)
        {
            if (currDuration < vidlength)
            {
                currDuration++;
                Console.WriteLine("Video at {0}sec",currDuration); 
            }
            else
            {
                stop();
            }
        }

        public void stop()
        {
            Console.WriteLine("Video Paused at {0}",currDuration);
            currDuration = 0;
            timer.Dispose();
        }
    }
}
