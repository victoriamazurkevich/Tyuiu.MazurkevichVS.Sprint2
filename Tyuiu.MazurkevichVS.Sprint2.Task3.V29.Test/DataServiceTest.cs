using Tyuiu.MazurkevichVS.Sprint2.Task3.V29.Lib;
namespace Tyuiu.MazurkevichVS.Sprint2.Task3.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition0()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = ds.Calculate(x);
            double expected = 4687.5;
            Assert.AreEqual(expected, y);
        }

        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = ds.Calculate(x);
            double expected = 1;
            Assert.AreEqual(expected, y);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = -1;
            double y = ds.Calculate(x);
            double expected = 0.5;
            Assert.AreEqual(expected, y);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -40;
            double y = ds.Calculate(x);
            double expected = -439.975;
            Assert.AreEqual(expected, y);
        }
    }
}
