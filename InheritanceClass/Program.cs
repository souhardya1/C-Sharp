using System;

namespace InheritanceClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            radio myradio = new radio(false, "Sony");
            myradio.ListenToRadio();
            myradio.SwitchOn();
            myradio.ListenToRadio();

            tv mytv = new tv(true, "LG");
            mytv.WatchTV();
            mytv.SwitchOff();
            mytv.WatchTV();
        }
    }
}
