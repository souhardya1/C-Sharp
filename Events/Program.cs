using System.Security.Cryptography;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Shooter shooter = new Shooter();
            shooter.ShotsFired += KilledEnemy;
            shooter.OnShoot();
        }

        public static void KilledEnemy(object sender,EventArgs e)
        {
            Console.WriteLine("I killed an enemy");
        }
        
    }
    internal class Shooter
    {
        private Random rng = new Random();
        public delegate void KillingHandler(object sender, EventArgs e);
        public event KillingHandler? ShotsFired;

        public void OnShoot()
        {
            while (true)
            {
                if (rng.Next(0, 100) % 2 == 0)
                {
                    if(ShotsFired != null)
                    {
                        ShotsFired.Invoke(this,EventArgs.Empty);
                    }                 
                }
                else
                {
                    Console.WriteLine("I missed");
                }
                Thread.Sleep(500);
            }
        }

    }
}