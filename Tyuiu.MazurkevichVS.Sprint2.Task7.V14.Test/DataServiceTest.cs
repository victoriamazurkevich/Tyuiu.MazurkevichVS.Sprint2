using Tyuiu.MazurkevichVS.Sprint2.Task7.V14.Lib;
namespace Tyuiu.MazurkevichVS.Sprint2.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInArea()
        {
            DataService ds = new DataService();
            double x = 0.2;
            double y = 0.2;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool expected = true;
            Assert.AreEqual(expected, res);
        }
    }
}
