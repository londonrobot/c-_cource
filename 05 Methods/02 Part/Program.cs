using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Part
{
    internal class Program
    {
        static string ReversWords(string inputPhrase)
        {
            string[] subs = inputPhrase.Split(' ');
            string newString = ChangeWordsOrder(subs);
            return newString;
        }

        static string ChangeWordsOrder(string[] initial)
        {
            string newstring = "";
            for (int i = initial.Length; i > 0; i--) newstring += initial[i-1] + " ";

            // Альтернативное решение:
            //Array.Reverse(initial);
            //foreach (var e in initial) newstring += e + " ";
            return newstring;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите строку, разделяя слова в ней с помощью пробела:");
            string inputString = Console.ReadLine();

            string inputReverse = ReversWords(inputString);

            Console.WriteLine(inputReverse);
            Console.ReadKey();

        }
    }
}
