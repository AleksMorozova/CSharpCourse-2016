using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Циклы_
{
    class Program
    {
        static void Main(string[] args)
        {
            string y;
            Table table = new Table();
            Rozriad rozriad = new Rozriad();
            Task3 ugadai = new Task3();
            Natural natural = new Natural();
            Midlle midlle = new Midlle();
            RndMidlle rndmid = new RndMidlle();
            Animals animals = new Animals();
            Password pass = new Password();

            do
            {
                Console.Write("Select activity (table, rozriad, ugadai, pow,\n midlle, rndmid, animals, pass): ");
                string str = Console.ReadLine();

                switch (str)
                {
                    case "table":
                        do
                        {
                            table.Function();
                            Console.Write("\nStart table again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "rozriad":
                        do
                        {
                            rozriad.Print();
                            Console.Write("\nStart rozriad again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "ugadai":
                        do
                        {
                            ugadai.Ugadai();
                            Console.Write("\nStart ugadai again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "pow":
                        do
                        {
                            natural.Show();
                            Console.Write("\nStart natural again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "midlle":
                        do
                        {
                            midlle.Show();
                            Console.Write("\nStart midlle again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "rndmid":
                        do
                        {
                            rndmid.Show();
                            Console.Write("\nStart rndmid again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "animals":
                        do
                        {
                            animals.Show();
                            Console.Write("\nStart animals again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "pass":
                        do
                        {
                            pass.Show();
                            Console.Write("\nStart pass again? y/n: ");
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
