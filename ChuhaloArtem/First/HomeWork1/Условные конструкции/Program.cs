using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {

        static void Main(string[] args)
        {
            string y;
            FIO fio = new FIO();
            Biger biger = new Biger();
            Animals pets = new Animals();
            Month month = new Month();
            ThreeOp three = new ThreeOp();
            Week week = new Week();
            Taxi taxi = new Taxi();
            Simple simple = new Simple();
            Chanse chanse = new Chanse();
            Money money = new Money();

            do
            {
                Console.Write("Select activity (fio, biger, pets, month, threeOp,\n week, taxi, simple, chanse, money): ");
                string str = Console.ReadLine();

                switch (str)
                {
                    case "fio":
                        do
                        {
                            fio.Print(); 
                            Console.Write("\nStart fio again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "biger":
                        do
                        {
                            biger.Match();
                            Console.Write("\nStart biger again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "pets":
                        do
                        {
                            pets.Pets();
                            Console.Write("\nStart pets again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "month":
                        do
                        {
                            month.Time();
                            Console.Write("\nStart month again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "threeOp":
                        do
                        {
                            three.Operation();
                            Console.Write("\nStart treeOp again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case"week":
                        do
                        {
                            week.Print();
                            Console.Write("\nStart week again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "taxi":
                        do
                        {
                            taxi.Function();
                            Console.Write("\nStart taxi again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "simple":
                        do
                        {
                            simple.Function();
                            Console.Write("\nStart simple again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "chanse":
                        do
                        {
                            chanse.Function();
                            Console.Write("\nStart chanse again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "money":
                        do
                        {
                            money.Function();
                            Console.Write("\nStart money again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;
                        
                    default:
                        Console.WriteLine("Invalid selection. Please select proposed item");
                        break;
                }
                Console.Write("\nStart all again? y/n: ");
                y = Console.ReadLine();
            } while (y == "y");
        }
    }
}
