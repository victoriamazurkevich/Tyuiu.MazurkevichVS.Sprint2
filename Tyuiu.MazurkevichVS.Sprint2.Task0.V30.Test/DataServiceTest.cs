using Tyuiu.MazurkevichVS.Sprint2.Task0.V30.Lib;
namespace Tyuiu.MazurkevichVS.Sprint2.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 95;
            int y = 1735;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] expected = { true, false, true, false, true, false }; 
            CollectionAssert.AreEqual(expected, res);
            
        }
    }
}
