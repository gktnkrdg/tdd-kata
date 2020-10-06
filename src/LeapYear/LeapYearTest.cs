using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TDDKatas.LeapYear
{
   public class LeapYearTest
    {
       [Theory]
       [InlineData(2000)]
       public void IsLeapYear_ShouldReturnYearIsALeapYear(int year)
        {
            LeapYear leapYear = new LeapYear();

            var isLeapYear = leapYear.IsLeapYear(year);

            isLeapYear.Should().Be(true);
        }
    }
}
