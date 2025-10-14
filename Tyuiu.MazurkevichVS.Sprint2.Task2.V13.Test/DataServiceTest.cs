using Tyuiu.MazurkevichVS.Sprint2.Task2.V13.Lib;
namespace Tyuiu.MazurkevichVS.Sprint2.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 6;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool expected = true;
            Assert.AreEqual(expected, res);
        }
    }
}
