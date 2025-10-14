using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MazurkevichVS.Sprint2.Task1.V7.Lib
{
    public class DataService : ISprint2Task1V7
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (d < c);
            res[1] = (a < c) & (b > d);
            res[2] = (a == d) || (c > b);
            res[3] = (a != d) && (b == d);
            res[4] = !(!res[0]);
            res[5] = (a != d) ^ (b > c);

            return res;
        }
    }
}
