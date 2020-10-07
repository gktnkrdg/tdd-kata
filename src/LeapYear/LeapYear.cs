using System;
using System.Collections.Generic;
using System.Text;

namespace TDDKatas.LeapYear
{
    public class LeapYear
    {
        public bool IsLeapYear(int year)
        {
            return ((year % 4 == 0 && year %100 != 0) || year %400 == 0);
        }
    }
}
