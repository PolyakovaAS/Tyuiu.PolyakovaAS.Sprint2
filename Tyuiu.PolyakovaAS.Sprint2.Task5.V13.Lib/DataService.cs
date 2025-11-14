using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PolyakovaAS.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int day = n;
            int month = m;
            int year = g;

            
            int daysInMonth = DateTime.DaysInMonth(year, month);

            
            if (day == daysInMonth)
            {
                day = 1;
                if (month == 12)
                {
                    month = 1;
                    year++;
                }
                else
                {
                    month++;
                }
            }
            else
            {
                day++;
            }

            
            return $"{day:D2}.{month:D2}.{year}";
        }

    }
    }
