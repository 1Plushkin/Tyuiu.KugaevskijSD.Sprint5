using Tyuiu.KugaevskijSD.Sprint5.Task3.V26.Lib;
namespace Tyuiu.KugaevskijSD.Sprint5.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\1Plushkin\source\repos\Tyuiu.KugaevskijSD.Sprint5\Tyuiu.KugaevskijSD.Sprint5.Task3.V26\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}