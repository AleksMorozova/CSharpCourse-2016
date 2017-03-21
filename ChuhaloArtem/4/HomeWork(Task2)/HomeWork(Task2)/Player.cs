using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Task2_
{
    class Player: IPlayable, IRecodable
    {
        public void Record()
        {
            Console.WriteLine("Recording now.");
        }
        public void Play()
        {
            Console.WriteLine("Playing now.");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Paused now.");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Unpaused now.");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Stopped now.");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Unstopped now.");
        }
    }
}
