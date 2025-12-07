using Tyuiu.KugaevskijSD.Sprint5.Task5.V12.Lib;
namespace Tyuiu.KugaevskijSD.Sprint5.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\1Plushkin\source\repos\Sprint5Task5\Sprint5Task5\InPutDataFileTask5V12";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}