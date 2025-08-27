
using System.Threading.Channels;

namespace Date
{
    public class DateClass
    {
        private int _month;
        private int _year;
        private int _day;

        public DateClass(int year,int month,int day)
        {
            _day = day;
            _year = year;
            if(month > 1 &&  month < 12)
            {
                _month = month;
            }
            else
            {
                _month = 1;
            }
        }


        public void DisplayDate()
        {
           Console.WriteLine($"{_year}/{_month}/{_day}");
        }

    }
}
