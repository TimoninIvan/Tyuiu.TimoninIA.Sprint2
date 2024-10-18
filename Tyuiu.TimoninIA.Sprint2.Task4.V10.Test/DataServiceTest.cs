using Tyuiu.TimoninIA.Sprint2.Task4.V10.Lib;
namespace Tyuiu.TimoninIA.Sprint2.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(6, res);
        }
    }
}