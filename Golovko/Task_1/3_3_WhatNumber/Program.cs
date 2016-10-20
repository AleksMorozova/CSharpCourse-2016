using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3_WhatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            IGame game = new Game(1, 146);
            game.Play();
            Console.ReadKey();
        }
    }
}
