using Tyuiu.TimoninIA.Sprint2.Task7.V12.Lib;
namespace Tyuiu.TimoninIA.Sprint2.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadeArea()
        {
            DataService ds = new DataService();
            double y = 0;
            double x = 0.1;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}