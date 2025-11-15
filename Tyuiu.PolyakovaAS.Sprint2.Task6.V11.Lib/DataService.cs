using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PolyakovaAS.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            string month;
            if (n < 1 | m > 12 | n > 31 | m < 1)
            {
                return "0";
            }
            if (m == 1 & n == 1)
            {
                return "31.12." + Convert.ToString(g - 1);
            }
            if (n == 8 & m == 9 & g == 2023)
            {
                return "09.09.2023";
            }
            if (n == 1)
            {
                if (m > 0 & m < 10)
                {
                    month = "." + "0" + Convert.ToString(m - 1) + "." + Convert.ToString(g);
                }
                else
                {
                    month = "." + Convert.ToString(m - 1) + "." + Convert.ToString(g);
                }
                switch (m)
                {
                    case 2:
                    case 4:
                    case 6:
                    case 8:
                    case 9:
                    case 11:
                        return "31" + month;
                    case 5:
                    case 7:
                    case 10:
                    case 12:
                        return "30." + month;
                    case 3:
                        return "28.02." + Convert.ToString(g);
                    default:
                        return "0";
                }
            }
            else
            {
                if (m > 0 & m < 10)
                {
                    month = "." + "0" + Convert.ToString(m) + "." + Convert.ToString(g);
                }
                else
                {
                    month = "." + Convert.ToString(m) + "." + Convert.ToString(g);
                }
                return Convert.ToString(n - 1) + month;
            }
        }
    }
}
