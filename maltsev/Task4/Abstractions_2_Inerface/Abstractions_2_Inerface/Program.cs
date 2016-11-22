using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions_2_Inerface
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player: IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Music is playing");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Music is paused");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Music is stopped");
        }
        public void Record()
        {
            Console.WriteLine("Recording is started");
        }
        void IRecordable.Pause()
        {
            Console.WriteLine("Recording is paused");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("Recording is stopped");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.Record();
            (player as IRecordable).Pause();
            (player as IRecordable).Stop();

            player.Play();
            (player as IPlayable).Pause();
            (player as IPlayable).Stop();

            Console.ReadKey();
        }
    }
}
