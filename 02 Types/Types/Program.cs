using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    internal class Program
    {
        static void Main()
        {
            /* 

            Задание 1

             */

            string fullName = "Альбус Персиваль Дамблдор";
            int age = 173;
            string email = "dambldor@hogwarts.co.uk";
            double programmingGrade = 343.432, 
                   mathGrade = 243.34, 
                   physicsGrade = 432.4311;

            
            Console.WriteLine($"Полное имя:\t\t\t{fullName}\nВозраст:\t\t\t{age}\nЭлектронный адрес:\t\t{email}" +
                $"\nБаллы по программированию:\t{programmingGrade}\nБаллы по математике:\t\t{mathGrade}\nБаллы по физике:\t\t{physicsGrade}\n");
            Console.ReadKey();


            /* 

            Задание 2         

             */

            double sum = programmingGrade + mathGrade + physicsGrade;
            double medianGrade = sum / 3;
            Console.WriteLine($"Средниее арифметическое по всем баллам составляет: {medianGrade.ToString("### ###.###"), 10}");

            Console.ReadKey();

        }
    }
}
