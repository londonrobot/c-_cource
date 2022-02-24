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
            Console.Write("Введите максимальное целое чсло в диапазоне: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            int number = r.Next(limit + 1);
            Console.WriteLine(number);

            Console.WriteLine("Теперь попробуйте угадать загаданное программой число: ");
                
            while (true)
            {
                string attemptString = Console.ReadLine();

                if (attemptString == "") 
                {
                    Console.WriteLine($"Загадано было число: {number}");
                    break;
                } else
                {
                    int attempt = Convert.ToInt32(attemptString);

                    if (attempt == number)
                    {
                        Console.WriteLine("Вы угадали! Поздравления.");
                        break;
                    } 
                    else if (attempt > number) Console.WriteLine("Введенное число больше загаданного. Попробуйте еще раз: "); 
                    else Console.WriteLine("Введенное число меньше загаданного. Попробуйте еще раз: ");
                }

            }

            Console.ReadKey();

        }
    }
}
