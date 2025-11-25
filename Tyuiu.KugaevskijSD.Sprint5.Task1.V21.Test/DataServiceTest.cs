using Tyuiu.KugaevskijSD.Sprint5.Task1.V21.Lib;
namespace Tyuiu.KugaevskijSD.Sprint5.Task1.V21.Test;

    [TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;
        bool wait = false;
        Assert.AreEqual(fileExists, wait);
    }
}
