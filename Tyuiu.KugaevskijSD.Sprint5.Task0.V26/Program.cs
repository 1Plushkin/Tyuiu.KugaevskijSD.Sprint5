using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KugaevskijSD.Sprint5.Task0.V26.Lib;

namespace Tyuiu.KugaevskijSD.Sprint5.Task0.V26;

    internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Кугаевский С. Д. | АСОиУб-25-1";
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("- Спринт #5                                                            -");
        Console.WriteLine("- Тема: Класс File. Запись данных в текстовый файл                     -");
        Console.WriteLine("- Задание #0                                                           -");
        Console.WriteLine("- Вариант #26                                                          -");
        Console.WriteLine("- Выполнил: Кугаевский С. Д. | АСОиУб-25-1                             -");
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("- УСЛОВИЕ: Дано выражение вычислить его значение при x = 2, результат  -");
        Console.WriteLine("- сохранить в текстовый файл OutPutFileTask0.txt и вывести на консоль. -");
        Console.WriteLine("- Округлить до трёх знаков после запятой.                              -");
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ: x = 2                                               -");
        Console.WriteLine("------------------------------------------------------------------------");
        int x = 2;
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("- РЕЗУЛЬТАТ:                                                           -");
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}
