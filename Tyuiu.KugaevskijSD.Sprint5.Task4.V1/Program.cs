using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KugaevskijSD.Sprint5.Task4.V1.Lib;

namespace Tyuiu.KugaevskijSD.Sprint5.Task4.V1;

    internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
        Console.WriteLine("*****************************************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask4V1.txt";
        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("*****************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
        Console.WriteLine("*****************************************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}
