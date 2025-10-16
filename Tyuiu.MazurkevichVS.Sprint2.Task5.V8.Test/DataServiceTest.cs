using Tyuiu.MazurkevichVS.Sprint2.Task5.V8.Lib;
namespace Tyuiu.MazurkevichVS.Sprint2.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            DataService ds = new DataService();
            int n = 6;
            int m = 20;
            string res = ds.FindDateOfPreviousDay(n, m);
            string expected = "19.06";
            Assert.AreEqual(expected, res);
        }
    }
}
