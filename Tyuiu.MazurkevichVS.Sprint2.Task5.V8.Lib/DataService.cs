using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MazurkevichVS.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            {

                int prevDay, prevMonth;

                switch (n)
                {
                    case 1:
                        // Переход к предыдущему месяцу
                        switch (m)
                        {
                            case 3:
                                prevDay = 28;
                                break;
                            case 2:
                            case 4:
                            case 6:
                            case 8:
                            case 9:
                            case 11:
                                prevDay = 31;
                                break;
                            case 5:
                            case 7:
                            case 10:
                            case 12:
                                prevDay = 30;
                                break;
                            default:
                                prevDay = 31;
                                break;
                        }
                        prevMonth = m - 1;
                        break;

                    default:
                        prevDay = n - 1;
                        prevMonth = m;
                        break;
                }

                string result = $"{prevMonth}, {prevDay}";
                return result;
            }
        }
    }
}