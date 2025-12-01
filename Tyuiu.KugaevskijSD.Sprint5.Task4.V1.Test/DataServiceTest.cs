using System.IO;
using Tyuiu.KugaevskijSD.Sprint5.Task4.V1.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
namespace Tyuiu.KugaevskijSD.Sprint5.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine(@"C:\Users\1Plushkin\source\repos\Sprint5Task4\Sprint5Task4\InPutDataFileTask4V1");
            FileInfo fileInfo = new FileInfo(path);
            double wait = -3.680;
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}