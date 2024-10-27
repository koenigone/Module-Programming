using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace dateClass
{
    class Date
    {
        public int day;
        public int month = 30;
        public int year;

        void setDay(int d)      // sets Day, 1-30
        {
            if (d > 0 && d < 31) { day = d; }
        }
        void setMonth(int m)    // sets Month, 1-12
        {
            if (m > 0 && m < 13) { month = m; }
        }
        void setYear(int y)     // sets Year
        {
            year = y;
        }

        // adds to day
        void addDays(int n)
        {
            day = (day + n) % 30;
        }
        // adds to month
        void addMonths(int n)
        {
            month = (month + n) % 12;
        }
        // adds to year
        void addYear(int n)
        {
            year += n;
        }

        string Formatted()
        {
            string format = "YY-MM-DD";

            format = format.Replace("YY", year.ToString("D4"));     // replace with specified year 
            format = format.Replace("MM", month.ToString("D2"));    // month
            format = format.Replace("DD", day.ToString("D2"));      // day

            return format;
        }

        /* Check if the year is before
         * true if other is larger than specified year
         * if years are equel, check months
         * if months are equel, check days
         */
        bool isBefore(Date other)
        {
            if (year < other.year)
            {
                return true;
            }
            else if (year == other.year)
            {
                if (month < other.month)
                {
                    return true;
                }
                else if (month == other.month)
                {
                    if (day < other.day)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Check if the year is after
        bool isAfter(Date other)
        {
            if (year > other.year)
            {
                return true;
            }
            else if (year == other.year)
            {
                if (month > other.month)
                {
                    return true;
                }
                else if (month == other.month)
                {
                    if (day > other.day)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        bool IsTheSameAS(Date other)
        {
            if (year == other.year && month == other.month && day == other.day)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
