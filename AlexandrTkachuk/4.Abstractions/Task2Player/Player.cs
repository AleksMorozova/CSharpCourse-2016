using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Player
{
    class Player: IRecordable, IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Pause playing");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop playing");
        }

        public void Record()
        {
            Console.WriteLine("Record");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Pause recording");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Stop recording");
        }
    }
}
