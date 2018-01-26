using System;
using MetroFramework.Forms;

namespace DaysCalculate
{
    public partial class DaysCalculate : MetroForm
    {
        public DaysCalculate()
        {
            InitializeComponent();
        }
        enum Months { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Nov, Oct, Dec };
        enum ShortMonth { Apr = 4, Jun = 6, Sep = 9, Nov = 11 };

        private void Calculate_btn_Click(object sender, EventArgs e)
        {
            string[] startDate = (metroDateTime1.Value.ToString("yyyy-MM-dd").Split('-'));
            string[] endDate = (metroDateTime2.Value.ToString("yyyy-MM-dd").Split('-'));

            Result_lb.Text = CalculateDurationinDays(Int32.Parse(startDate[0]), Int32.Parse(startDate[1]), Int32.Parse(startDate[2]),
                                                     Int32.Parse(endDate[0]), Int32.Parse(endDate[1]), Int32.Parse(endDate[2]))
                                                     .ToString("N0") + " Days";
        }

        //find if current year is leap year
        public bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            return false;
        }

        //find how many days in this month
        public int TotaldaysinCurrentMonth(int year, int month)
        {
            const int iCommonMonthDays = 31;
            const int iShortMonthDays = 30;
            const int iCommonFebDays = 28;
            const int iLeapFebDays = 29;

            if (month == (int)Months.Feb)
            {
                return (IsLeapYear(year) ? iLeapFebDays : iCommonFebDays);
            }
            if (Enum.IsDefined(typeof(ShortMonth), month))
            {
                return iShortMonthDays;
            }

            return iCommonMonthDays;
        }

        // Convert date to days
        public int ConvertToDays(int year, int month, int day, int baselineYear)
        {
            const int iCommonYear = 365;
            const int iLeapYear = 366;

            int iMonthToDays = day;   // plus days in current month to start with
            int iYeartoDays = 0;

            //conver month to days, start from next month of current month to Jan
            for (int iMonth = month - 1; iMonth >= (int)Months.Jan; iMonth--)
            {
                iMonthToDays += TotaldaysinCurrentMonth(year, iMonth);
            }

            //convert year to days, start from next year of current year to baselineYear
            for (int iYear = year - 1; iYear >= baselineYear; iYear--)
            {
                if (IsLeapYear(iYear))
                {
                    iYeartoDays += iLeapYear;
                }
                else
                {
                    iYeartoDays += iCommonYear;
                }

            }

            return iMonthToDays + iYeartoDays;

        }

        public int CalculateDurationinDays(int startYear, int startMonth, int startDay, int endYear, int endMonth, int endDay)
        {
            int iBaselineYear = Math.Min(startYear, endYear); //set the smaller year as the baseline year   

            return Math.Abs(ConvertToDays(endYear, endMonth, endDay, iBaselineYear)
                - ConvertToDays(startYear, startMonth, startDay, iBaselineYear));

        }

    }


}


