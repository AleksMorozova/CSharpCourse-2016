using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>(2);
            myDictionary.Add("Zero", "Нуль");
            myDictionary.Add("One", "Один");
            myDictionary.Add("Two", "Два");
            myDictionary.Add("Three", "Три");
            myDictionary.Add("Four", "Четыре");
            myDictionary.Add("Five", "Пять");
            myDictionary.Add("Six", "Шесть");
            myDictionary.Add("Seven", "Семь");
            myDictionary.Add("Eight", "Восемь");
            myDictionary.Add("Nine", "Девять");
            myDictionary.Add("Ten", "Десять");

            Console.WriteLine("Количество элементов в списке: {0}", myDictionary.Count);
            Console.WriteLine("Элементы списка: ");
            foreach (MyKeyValuePair<string, string> keyValuePair in myDictionary)
            {
                Console.WriteLine(keyValuePair.Key + " - " + keyValuePair.Value);
            }

            Console.ReadLine();
        }
    }
}
