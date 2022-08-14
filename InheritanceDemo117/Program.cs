using System;

namespace InheritanceDemo117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Purbasha");
            post1.info();

            imagePost image1 = new imagePost("Good view", "Souhardya", "https//img.gur", true);
            image1.info();

            VideoPost video1 = new VideoPost("Failed Video","bubu","https//gg.com",true,10);
            video1.info();
            video1.play();
            Console.WriteLine("Press any key to stop the video");
            Console.Read();
            video1.stop();
        }
    }
}
