using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел в последовательности: ");
            int number = Convert.ToInt32(Console.ReadLine());
        
            while (number <= 0)
            {
                Console.Write("Количество чисел должно быть больше нуля. Введите еще раз: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            
            int[] sequence = new int[number];
            Console.WriteLine("Вводите числа по одному, завершая ввод числа клавишей Enter: ");

            for (int i = 0; i < number; i++)
            {
                sequence[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = sequence[0];
            for (int i = 1; i < number; i++)
            {
                if (sequence[i] < min) min = sequence[i];
            }

            Console.WriteLine($"Минимальное число в последовательности: {min}.");
            Console.ReadKey();

        }
    }
}
