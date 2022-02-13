using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch_n_Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка числа на четность.\nВведите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("0 не относится ни к четным, ни к нечетным числам.");
            }
            else Console.WriteLine(number % 2 == 0 ? "Число четное." : "Число нечетное.");

            Console.ReadKey();

        }
    }
}
