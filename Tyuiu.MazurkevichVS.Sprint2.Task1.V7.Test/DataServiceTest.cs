using Tyuiu.MazurkevichVS.Sprint2.Task1.V7.Lib;
namespace Tyuiu.MazurkevichVS.Sprint2.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            int a = 195;
            int b = 16;
            int c = 14;
            int d = 45;
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] expected = { true, false, false, false, true, false };
            CollectionAssert.AreEqual(expected, res);
        }
    }
}
