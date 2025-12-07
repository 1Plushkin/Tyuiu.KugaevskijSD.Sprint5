using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KugaevskijSD.Sprint5.Task7.V23.Lib;

namespace Tyuiu.KugaevskijSD.Sprint5.Task7.V23;

    internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Исходные данные:                                                        *");
        Console.WriteLine("***************************************************************************");


        string path = $@"C:\DataSprint5\InPutDataFileTask7V23.txt";
        string pathSaveFile = @"C:\Users\1Plushkin\source\repos\Sprint5Task7\Sprint5Task7\InPutDataFileTask7V23";


        Console.WriteLine("Данные находяться в файле: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Находится в файле : ");
        pathSaveFile = ds.LoadDataAndSave(path);
        Console.WriteLine(pathSaveFile);
        Console.ReadKey(); ;
    }
}
