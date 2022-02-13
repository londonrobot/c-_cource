using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число. Проверим, является ли оно простым!");
            int number = int.Parse(Console.ReadLine());

            if (0 == number) Console.WriteLine("Вы ввели ноль. Он не относится к натуральным числам, а простые числа могут быть только натуральными. ");
            if (1 == number) Console.WriteLine($"{number} это простое число");

            int i = 2;
            Boolean isSimple = true;
            while (i < number)
            {
                if (number % i == 0)
                {
                    isSimple = false;
                    break;
                }
                i++;
            }

            Console.WriteLine(isSimple ? $"{number} это простое число" : $"{number} имеет делители");

            Console.ReadKey();
        }
    }
}
