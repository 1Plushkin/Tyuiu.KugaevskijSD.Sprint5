using Tyuiu.KugaevskijSD.Sprint5.Task2.V16.Lib;
namespace Tyuiu.KugaevskijSD.Sprint5.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\1Plushkin\source\repos\Tyuiu.KugaevskijSD.Sprint5\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);

        }
    }
}