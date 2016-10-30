using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Player
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            IPlayable iplayable = player;
            player.Play();
            iplayable.Pause();
            iplayable.Stop();

            IRecordable irecordable = player;
            player.Record();
            irecordable.Pause();
            irecordable.Stop();
        }
    }
}
