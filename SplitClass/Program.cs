using System;
using System.Threading;
using System.Threading.Tasks;

namespace SplitClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player(new Weapon(1, 10));

            Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep(200);
                    player.Attack();
                }
            });

            Console.ReadLine();
        }
    }
}