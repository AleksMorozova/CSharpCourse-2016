using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_2
{
    class Player : IRecordable, IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Проигрывание");
        }

        public void Record()
        {
            Console.WriteLine("Запись");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Запись остановленна");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Запись на паузе");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Проигрывание остановленно");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Проигрывание на паузе");
        }

    }
}
