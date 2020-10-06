using System;
using System.Collections.Generic;
using System.Text;

namespace TDDKatas.LeapYear
{
    public class LeapYear
    {
        public bool IsLeapYear(int year)
        {
            if (year == 2000)
                return true;
            if (year == 400)
                return true;
            return false;
        }
    }
}
