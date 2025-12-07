using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KugaevskijSD.Sprint5.Task6.V15.Lib;

namespace Tyuiu.KugaevskijSD.Sprint5.Task6.V15;
    internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнил: Кугаевский С. Д. | АСОиУб-25-1";
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спритн #5                                                              *");
        Console.WriteLine("* Тема: Создания итогого решения по спринту                              *");
        Console.WriteLine("* Задание #6                                                             *");
        Console.WriteLine("* Вариант #15                                                            *");
        Console.WriteLine("* Выполнил: Кугаевский С. Д. | АСОиУб-25-1                               *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("*                                                                        *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        DataService ds = new DataService();
        string path = @"C:\Users\1Plushkin\source\repos\Sprint5Task6\Sprint5Task6\InPutDataFileTask6V15";
        Console.WriteLine("Файл: " + path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
    }
}
