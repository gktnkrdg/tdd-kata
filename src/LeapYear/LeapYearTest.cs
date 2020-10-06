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
        [InlineData(2000,true)]
        [InlineData(2001,false)]
        [InlineData(400, true)]
        public void IsLeapYear_ShouldReturnYearIsALeapYear(int year,bool expectedResult)
        {
            LeapYear leapYear = new LeapYear();

            var isLeapYear = leapYear.IsLeapYear(year);

            isLeapYear.Should().Be(expectedResult);
        }
    }
}
