using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDKatas.LeapYear
{
   public class LeapYearTest
    {
       public void IsLeapYear_ShouldReturnYearIsALeapYear()
        {
            LeapYear leapYear = new LeapYear();

            var isLeapYear = leapYear.IsLeapYear(2000);

            isLeapYear.Should().Be(true);
        }
    }
}
