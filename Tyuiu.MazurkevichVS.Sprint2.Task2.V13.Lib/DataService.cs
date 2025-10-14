using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MazurkevichVS.Sprint2.Task2.V13.Lib
{
    public class DataService : ISprint2Task2V13
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x >= 3 && x<= 13 && y == 6) || (x == 4 && y >= 2 && y <= 8) || (x >= 8 && x <= 12 && y >= 5 && y <= 10) || (x >= 3 && x <= 9 && y == 11) || (x >= 6 && x <= 7 && y == 10) || (x >= 7 && x <= 10 && y == 11) || (x >= 9 && x <= 12 && y >= 3 && y <= 4) || (x == 13 && y >= 6 && y <= 8))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
