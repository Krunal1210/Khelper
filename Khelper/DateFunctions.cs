using System;

namespace Khelper
{
    public enum WeekDays
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
    public enum Months
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }
    /// <summary>
    /// Date Formate Related Methods
    /// </summary>
    public static class DateFunctions
    {
        /// <summary>
        /// GetMonthArray : Get String Array of Months
        /// </summary>
        /// <returns></returns>
        public static string[] GetMonthArray()
        {
            string[] months = {Months.January.ToString(), Months.February.ToString(), Months.March.ToString(), Months.April.ToString(), Months.May.ToString(),
            Months.June.ToString(), Months.July.ToString(), Months.August.ToString(), Months.September.ToString(), Months.October.ToString(), Months.November.ToString(),Months.December.ToString()};
            return months;
        }

        public static string[] GetDateFormateArray(DateTime dt)
        {
            string[] Formates = {dt.ToString("dd"),dt.ToString("MM"),dt.ToString("MMMM"),dt.ToString("yyyy"),dt.ToString("yy"),
                dt.ToString("hh"),dt.ToString("mm"),dt.ToString("ss") ,dt.ToString("tt"),dt.ToString("dddd")};
            return Formates;
        }
        public static int GetDaysInAYear(int year)
        {
            int days = 0;
            for (int i = 1; i <= 12; i++)
            {
                days += DateTime.DaysInMonth(year, i);
            }
            return days;
        }
        public static string GetDateFormateDDMMYYYY(DateTime dt)
        {
            return dt.ToString("dd/MM/yyyy");
        }
        public static string GetDateFormateMMDDYYYY(DateTime dt)
        {
            return dt.ToString("MM/dd/yyyy");
        }
    }
}
