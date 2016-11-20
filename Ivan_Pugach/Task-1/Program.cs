using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    enum Days
    {
        Понедельник=1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    };
    class Program
    {
        public static string inputBuffer()
        {
            string input = Console.ReadLine();
            return input;
        }

        public static void displayMyName()
        {
            string delimiter = "+---------------------------------+";
            Console.WriteLine("{0}\n    {1} {2} {3}\n{4}", delimiter, "Pugach", "Ivan", "Stanislavovhich", delimiter);
            Console.ReadKey();
            Console.Clear();
        }

        public static void Task_1_1()
        {
            Console.WriteLine("Task 1, input first number");
            int firstNumber = Convert.ToInt16(inputBuffer());

            Console.WriteLine("input second number");
            int secondNumber = Convert.ToInt16(inputBuffer());

            Console.WriteLine("result");
            Console.WriteLine(firstNumber + secondNumber);
        }

        public static void Task_1_2()
        {
            Console.WriteLine("Task 2 \ninput мяу or гав");

            string buff = inputBuffer();

            if (buff == "мяу") Console.WriteLine("Покорма кота");

            else if (buff == "гав") Console.WriteLine("Погуляй с собакой");

            else Console.WriteLine("wrong input");
        }

        public static void Task_1_3()
        {
            Console.WriteLine("Task 3 \ninput the number of months");
            int numberOfTheMonth= Convert.ToInt16(inputBuffer());

            if (numberOfTheMonth >= 3 && numberOfTheMonth <= 5) Console.WriteLine("Весна");

            else if (numberOfTheMonth >= 6 && numberOfTheMonth <= 8) Console.WriteLine("Лето");
            else if (numberOfTheMonth >= 9 && numberOfTheMonth <= 11) Console.WriteLine("Осень");
            else if (numberOfTheMonth == 1 || numberOfTheMonth == 2 || numberOfTheMonth == 12) Console.WriteLine("Зима");
            else Console.WriteLine("На этой планете такого месяца нет");
        }

        public static void Task_1_4()
        {
            Console.WriteLine("Task 4 \ninput 0 or 1");
            int inputNumber= Convert.ToInt16(inputBuffer());

            Console.WriteLine("{0}", (inputNumber == 0) ? "Плохо" : "Хорошо");
        }
        public static void Task_1_5()
        {
            Console.Write("Task 5 \ninput the number : ");
            int number =Convert.ToInt16(inputBuffer());
            
            Console.WriteLine("{0}", (Days)number);
        }

        public static void Task_1_6()
        {
            Console.WriteLine("number of kilometers?");
            double numberOfKilometers = Convert.ToDouble(inputBuffer());
            Console.WriteLine("downtime ?");
            double numberOfMinutes = Convert.ToDouble(inputBuffer());
            Console.WriteLine("sum to pay is {0}", (numberOfKilometers <= 5) ? 20 + numberOfMinutes : 20 + (numberOfKilometers - 5) * 3 + numberOfMinutes);
        }
        public static void Task_1_7()
        {
            bool isPrime=true;
            Console.WriteLine("Task 7 \nnumber?");
            int inputNumber = Convert.ToInt16(inputBuffer());
            for(int i=2; i<=Math.Sqrt(inputNumber);i++)
            {
                if (inputNumber % i == 0) { isPrime=false; break; }
            }
            if (isPrime) Console.WriteLine("prime");
            else Console.WriteLine("not prime");
        }

        public static void Task_1_8()
        {
            Console.WriteLine("Task 8 \nbet?");
            int inputNumber = Convert.ToInt16(inputBuffer());
            Random rnd = new Random();
            int cub = rnd.Next(1, 12);
            int result;
            if (cub <= 5) result = 0;
            else if (cub == 12) result = inputNumber * 10;
            else if (cub >= 6 && cub <= 8) result = inputNumber;
            else result = inputNumber * 2;
            Console.WriteLine(result);
        }

        public static void Task_1_9()
        {
            Console.WriteLine("Task 9 \nsum?");
            int inputNumber = Convert.ToInt16(inputBuffer());
            Console.WriteLine("currency? whirte grn, euro or $");
            string curr = inputBuffer();
            if (curr == "grn") Console.WriteLine("{0} euros, {1} $s", inputNumber / 25, inputNumber / 30);
            else if(curr=="euro") Console.WriteLine("{0} grns, {1} $s", inputNumber * 30, inputNumber *1.2 );
            else Console.WriteLine("{0} grns, {1} euros", inputNumber * 25, inputNumber / 1.2);
        }

        public static void Task_1_10()
        {
            Console.WriteLine("input the number for table");
            int inputNumber = Convert.ToInt16(Console.ReadLine());
            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", inputNumber, i, inputNumber * i);
            }
        }
        public static void Task_1_11()
        {
            Console.WriteLine("input the numbere");
            string inputNumber = Console.ReadLine();
            Console.WriteLine(inputNumber.Length);
        }

        public static void Task_1_12()
        {
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 146), customerChoice;
            Console.WriteLine("try to guess the number between 1 to 146");
            do
            {
                Console.Write("variant =");
                customerChoice = Convert.ToInt16(inputBuffer());
                if (customerChoice == secretNumber) Console.WriteLine("YOU WON");
                else if (customerChoice > secretNumber) Console.WriteLine("less");
                else Console.WriteLine("more");
            } while (customerChoice != secretNumber);
        }
        public static void Task_1_13()
        {
            Console.WriteLine("input the number for table");
            int inputNumber = Convert.ToInt16(Console.ReadLine());
            for(int i=1; i*i<inputNumber;i++)
            {
                Console.WriteLine(i*i);
            }
        }
        public static void Task_1_14()
        {
            Console.WriteLine("input 5 numbers");
            int sum = 0, counter= 0, inputNumber;
            while (counter!=5)
            {
                inputNumber = Convert.ToInt16(Console.ReadLine());
                sum += inputNumber;
                counter++;
            }
            Console.WriteLine("average of 5 numbers = {0}", sum / counter);
        }
        public static void Task_1_15()
        {
            Random rnd = new Random();
            int sum = 0, counter = 0;
            while (counter != 5)
            {
                sum += rnd.Next(1,100);
                counter++;
            }
            Console.WriteLine("average of 5 random numbers = {0}", sum / counter);
        }
        public static void Task_1_16()
        {
            for (int i = 2; i <= 16; i *= 2)
            {
                Console.WriteLine("{0} gooses and {1} rabbits", i/2, (64/i)/4);
            }
        }
        public static void Task_1_17()
        {
            string inputedPassword, password = "root";
            do
            {
                inputedPassword = Console.ReadLine();
                if(password!=inputedPassword) Console.WriteLine("wrong password");
            } while (password != inputedPassword);
        }
        static void Main(string[] args)
        {
            displayMyName();
            Task_1_1();
            Task_1_2();
            Task_1_3();
            Task_1_4();
            Task_1_5();
            Task_1_6();
            Task_1_7();
            Task_1_8();
            Task_1_9();
            Task_1_10();
            Task_1_11();
            Task_1_12();
            Task_1_13();
            Task_1_14();
            Task_1_15();
            Task_1_16();
            Task_1_17();
        }
    }
}
