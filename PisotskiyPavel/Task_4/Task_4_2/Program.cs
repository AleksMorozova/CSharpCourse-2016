using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IRecordable recordDevice = player;
            IPlayable playerDevice = player;

            recordDevice.Record();
            recordDevice.Pause();
            recordDevice.Stop();

            playerDevice.Play();
            playerDevice.Pause();
            playerDevice.Stop();

            Console.ReadLine();
        }
    }
}
