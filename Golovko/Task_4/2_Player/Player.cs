using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Player
{
    class Player : IRecordable, IPlayable
    {
        public void Record()
        {
            Console.WriteLine("The record has began");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("The record has stopped");
        }
        void IRecordable.Pause()
        {
            Console.WriteLine("The record has paused");
        }
        public void Play()
        {
            Console.WriteLine("The playing began");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("The playing has paused");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("The playing has stopped");
        }
    }
}
