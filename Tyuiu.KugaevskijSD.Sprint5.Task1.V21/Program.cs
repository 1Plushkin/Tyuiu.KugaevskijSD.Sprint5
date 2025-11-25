using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KugaevskijSD.Sprint5.Task1.V21.Lib;

namespace Tyuiu.KugaevskijSD.Sprint5.Task1.V21;
    internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Кугаевский С. Д. | АСОиУб-25-1";
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- Спринт #5                                                               -");
        Console.WriteLine("- Тема:                                                                   -");
        Console.WriteLine("- Задание #1                                                              -");
        Console.WriteLine("- Вариант #5                                                              -");
        Console.WriteLine("- Выполнил: Кугаевский С. Д. | АСОиУб-25-1                                -");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ:                                                        -");
        Console.WriteLine("---------------------------------------------------------------------------");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("startValue = " + startValue);
        Console.WriteLine("stopValue = " + stopValue);

        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- РЕЗУЛЬТАТ:                                                              -");
        Console.WriteLine("---------------------------------------------------------------------------");

        string res = ds.SaveToFileTextData(startValue, stopValue);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}
