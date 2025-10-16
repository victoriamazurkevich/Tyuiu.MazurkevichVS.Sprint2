using Tyuiu.MazurkevichVS.Sprint2.Task6.V15.Lib;
namespace Tyuiu.MazurkevichVS.Sprint2.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            DataService ds = new DataService();
            int k = 2;
            string expected = "Вторник";
            string res = ds.FindDayName(k);
            Assert.AreEqual(expected, res);
        }
    }
}
