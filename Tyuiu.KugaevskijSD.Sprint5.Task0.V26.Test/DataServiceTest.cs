using Tyuiu.KugaevskijSD.Sprint5.Task0.V26.Lib;
namespace Tyuiu.KugaevskijSD.Sprint5.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string path = @"C:\Users\1Plushkin\source\repos\Tyuiu.KugaevskijSD.Sprint5\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(false, fileExists);
        }
    }
}