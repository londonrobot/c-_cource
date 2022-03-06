using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06_Files
{
    internal class Program
    {
        static void DataPrinting(string filename, char separator)
        {
            if (File.Exists(filename))
            {
                using (StreamReader streamreader = new StreamReader(filename))
                {
                    while (!streamreader.EndOfStream)
                    {
                        string[] array = streamreader.ReadLine().Split(separator);

                        foreach (string s in array)
                        {
                            Console.Write(s + "\t");
                        }
                        Console.WriteLine();
                    }
                    streamreader.Close();
                    Console.WriteLine();
                }
            }
            else 
            { 
                Console.WriteLine("Каталог сотрудников еще не создан.\n"); 
            }
        }

        static int TakeStartID(string filename, char separator)
        {
            int id = 0;
            if (File.Exists(filename))
            {
                using (StreamReader streamreader = new StreamReader(filename))
                {
                    string line = "";

                    while (!streamreader.EndOfStream)
                    {
                        line = streamreader.ReadLine();
                    }
                    streamreader.Close();

                    id = Convert.ToInt32(line.Remove(line.IndexOf(separator)));
                    Console.WriteLine("id" + id);
                }
            }
            else
            {
                id = 0;
            }
            return id;
        }

        static void DataInput (string filename, char separator, int id)
        {
            string[] data = new string[5];
            Console.Write("Введите ФИО сотрудника: ");
            data[0] = "\n" +  (id + 1) + separator + DateTime.Now + separator + Console.ReadLine();
            Console.Write("Введите возраст сотрудника: ");
            data[1] = Console.ReadLine();
            Console.Write("Введите рост сотрудника: ");
            data[2] = Console.ReadLine();
            Console.Write("Введите дату рождения сотрудника: ");
            data[3] = Console.ReadLine();
            Console.Write("Введите место рождения сотрудника: ");
            data[4] = Console.ReadLine();

            using (StreamWriter streamwriter = new StreamWriter(File.Open(filename, FileMode.Append, FileAccess.Write)))
            {
                for (int i = 0; i < data.Length; i++)
                {
                    streamwriter.Write(i == (data.Length - 1) ? data[i] : data[i] + separator);
                }
                streamwriter.Close();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вы открыли справочник «Сотрудники».");

            // имя справочника с сотрудниками и путь к нему
            const string filename = "employers.txt";

            // разделитель для записи свойств
            const char separator = '#';

            int id = TakeStartID(filename, separator);

            while (true)
            {
                Console.WriteLine($"Выберите действие:\n\t1: вывод данных на экран;" +
                                    $"\n\t2: ввести данные про нового сотрудника;" +
                                    $"\n\t3: выйти из программы.");

                string actionType = Console.ReadLine();
                Console.WriteLine();

                if (actionType == "1")
                {
                    DataPrinting(filename, separator);
                }

                if (actionType == "2")
                {
                    DataInput(filename, separator, id);
                    id++;
                }

                if (actionType == "3") break;

            }
        }
    }
}
