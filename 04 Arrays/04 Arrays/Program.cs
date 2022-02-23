using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк в матрице: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов в матрице: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[cols, rows];
            Random r = new Random();
            int sum = 0;

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    matrix[i, j] = r.Next(-999, 1000);
                    Console.Write($"{matrix[i, j], 4} ");
                    sum += matrix[i, j];
                }
                Console.WriteLine();
            }
            Console.Write($"Сумма всех элементов матрицы: {sum} ");
            Console.ReadKey();

        }
    }
}
