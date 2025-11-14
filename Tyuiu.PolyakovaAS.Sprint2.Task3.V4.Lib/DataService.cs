using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PolyakovaAS.Sprint2.Task3.V4.Lib
{
    public class DataService : ISprint2Task3V4
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 0)
            {
                y = x + Math.Pow((x + 1) / (x - 1), x);
            }
            else
            {
                if (x == 0)
                {
                    y = (Math.Pow(x, 2) + Math.Pow(Math.Cos(x), 2)) / (Math.Pow(x, 2) - Math.Pow(Math.Sin(x), 2) + 12);
                }
                else
                {
                    if ((x > -8) && (x < 0))
                    {
                        y = Math.Pow(x - (1 / Math.Pow(x, 2)), 2);
                    }
                    else
                    {
                        if (x < -8)
                        {
                            y = x + (10 * x) - (1 / x);
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
    }
}
