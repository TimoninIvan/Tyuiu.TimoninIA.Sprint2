using Tyuiu.TimoninIA.Sprint2.Task2.V19.Lib;

namespace Tyuiu.TimoninIA.Sprint2.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 6;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}