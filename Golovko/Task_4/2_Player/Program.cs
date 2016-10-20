using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IPlayable play = player;
            play.Play();
            play.Pause();
            play.Stop();
            IRecordable record = player;
            record.Record();
            record.Pause();
            record.Stop();
            Console.ReadKey();
        }
    }
}
