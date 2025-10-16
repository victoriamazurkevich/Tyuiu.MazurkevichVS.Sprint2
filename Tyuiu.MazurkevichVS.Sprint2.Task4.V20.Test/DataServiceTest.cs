using Tyuiu.MazurkevichVS.Sprint2.Task4.V20.Lib;
namespace Tyuiu.MazurkevichVS.Sprint2.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double z = ds.Calculate(x, y);
            double expected = 8;
            Assert.AreEqual(expected, z);
        }
    }
}
