using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PolyakovaAS.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            double res = 0;

            switch (n)
            {
                case 31:
                    switch (m)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                            res = 1 + (m + 1) * 0.01;
                            break;
                        case 12:
                            res = 1 + 0.01; 
                            break;
                    }
                    break;
                case 30:
                    switch (m)
                    {
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            res = 1 + (m + 1) * 0.01;
                            break;
                    }
                    break;
                case 29:
                    switch (m)
                    {
                        case 2:
                            res = 1 + 3 * 0.01; 
                            break;
                    }
                    break;
                default:
                    res = (n + 1) + m * 0.01;
                    break;
            }

            return res.ToString("F2").Replace(",", ".");

        }
    }
}
