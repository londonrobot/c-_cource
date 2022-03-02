using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Part
{
    internal class Program
    {
        static string[] StringToArray(string initialString)
        {
            string[] subs = initialString.Split(' ');
            return subs;
        }

        static void PrintArray(string[] array) 
        {
            Console.WriteLine("\nСлова введенной строки: ");
            foreach(var e in array) Console.WriteLine($"{e} ");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, разделяя слова в ней с помощью пробела:");
            string inputString = Console.ReadLine();

            string[] array = StringToArray(inputString);

            PrintArray(array);

            Console.ReadKey();
        }
    }
}
