using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KugaevskijSD.Sprint5.Task5.V12.Lib;

namespace Tyuiu.KugaevskijSD.Sprint5.Task5.V12;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Кугаевский С. Д. | АСОиУб-25-1";

        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("- Спринт #5                                         -");
        Console.WriteLine("- Тема: Чтение набора данных из текстового файла    -");
        Console.WriteLine("- Задание #5                                        -");
        Console.WriteLine("- Вариант #12                                       -");
        Console.WriteLine("- Выполнил: Кугаевский С. Д. | АСОиУб-25-1          -");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("- УСЛОВИЕ:                                          -");
        Console.WriteLine("- Найти разницу между суммой всех положительных и   -");
        Console.WriteLine("- отрицательных целых чисел в файле.Полученный      -");
        Console.WriteLine("- результат вывести на консоль.                     -");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ:                                  -");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("- РЕЗУЛЬТАТ:                                        -");
        Console.WriteLine("-----------------------------------------------------");
        string path = @"C:\DataSprint5\InPutDataFileTask5V12.txt";
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine("Результат: " + res);
        Console.ReadLine();
    }
}