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

            Console.Write("Приветствуем вас в игре Блэкджек. Напишите, сколько карт у вас на руках: ");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Теперь укажите все карты. Номиналы: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, T. ");

            int sum = 0;

            for (int i = 0; i < amount; i++)
            {
                string card = Console.ReadLine();

                switch (card)
                {
                    case "2":
                        sum += 2;
                        break;
                    case "3":
                        sum += 3;
                        break;
                    case "4":
                        sum += 2;
                        break;
                    case "5":
                        sum += 3;
                        break;
                    case "6":
                        sum += 2;
                        break;
                    case "7":
                        sum += 3;
                        break;
                    case "8":
                        sum += 2;
                        break;
                    case "9":
                        sum += 3;
                        break;
                    case "10":
                        sum += 2;
                        break;
                    case "J":
                        sum += 3;
                        break;
                    case "Q":
                        sum += 2;
                        break;
                    case "K":
                        sum += 3;
                        break;
                    case "T":
                        sum += 2;
                        break;
                    default:
                        i--;
                        Console.Write("Ошибка во вводе номинала карты. Пожалуйста, введите карту еще раз: ");
                        break;
                }
            }

            Console.WriteLine($"Сумма номиналов карт составила {sum}. ");
            Console.ReadKey();
        }
    }
}
