using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Task2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IPlayable ip = (IPlayable)player;
            IRecodable ir = (IRecodable)player;

            player.Play();           
            ir.Pause();
            ip.Pause();           
            ir.Stop();
            ip.Stop();
            player.Record();

            Console.ReadKey();
            
        }
    }
}
