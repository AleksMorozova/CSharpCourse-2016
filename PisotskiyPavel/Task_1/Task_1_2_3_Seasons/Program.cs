using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_3_Seasons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetSeasonByNumber(month));
            Console.ReadLine();
        }

        static string GetSeasonByNumber(int number)
        {
            string result = string.Empty;

            switch (number)
            {
                case 12:
                case 1:
                case 2:
                    result = "Зима"; break;

                case 3:
                case 4:
                case 5:
                    result = "Весна"; break;

                case 6:
                case 7:
                case 8:
                    result = "Лето"; break;

                case 9:
                case 10:
                case 11:
                    result = "Осень"; break;

                default:
                    result = "На этой планете такого месяца нет.";
                    break;
            }
            
            return result;
        }
    }
}
