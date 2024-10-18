using Tyuiu.TimoninIA.Sprint2.Task5.V14.Lib;
namespace Tyuiu.TimoninIA.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName1()
        {
            DataService ds = new DataService();


            Assert.AreEqual("�����������", ds.FindDayName(1, 1));
            Assert.AreEqual("�������", ds.FindDayName(2, 1));
            Assert.AreEqual("�����", ds.FindDayName(4, 3));
            Assert.AreEqual("����������� ", ds.FindDayName(7, 1));


            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(366, 1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(1, 8);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(0, 1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(1, 8);
            });
        }
    }
}