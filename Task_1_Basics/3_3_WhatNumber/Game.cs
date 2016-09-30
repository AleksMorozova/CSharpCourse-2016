using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3_WhatNumber
{
    class Game : IGame
    {
        private readonly int numberMin;
        private readonly int numberMax;
        public Game(int numberMin, int numberMax)
        {
            this.numberMin = numberMin;
            this.numberMax = numberMax;
        }
        public void Play()
        {
            int number = Generator.Generate(numberMin, numberMax);
            int result;
            int count = 1;
            do
            {
                Console.WriteLine("Try number {0}. Let's guess the number:", count++);
                result = int.Parse(Console.ReadLine());
                Console.WriteLine(result > number ? "less <" : "more >");
            }
            while (number != result);
            Console.WriteLine("Try number {0}. You guess!!!", count);
        }
    }
}
