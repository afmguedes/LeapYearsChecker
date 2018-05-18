using System;
using FluentAssertions;
using NUnit.Framework;

namespace LeapYearsKata.UnitTests
{
    [TestFixture]
    public class LeapYearsCheckerShould
    {
        [Test]
        public void ReturnFalse_WhenCheckIsCalledWithEmptyString()
        {
            var input = string.Empty;
            var leapYearsChecker = new LeapYearsChecker();

            var result = leapYearsChecker.Check(input);

            result.Should().BeFalse();
        }

        [TestCase("400")]
        [TestCase("800")]
        [TestCase("1200")]
        public void ReturnTrue_WhenCheckIsCalledWithYearDivisibleBy400(string input)
        {
            var leapYearsChecker = new LeapYearsChecker();

            var result = leapYearsChecker.Check(input);

            result.Should().BeTrue();
        }

        [TestCase("100")]
        [TestCase("1000")]
        [TestCase("1500")]
        public void ReturnFalse_WhenCheckIsCalledWithYearDivisibleBy100ButNotBy400(string input)
        {
            var leapYearsChecker = new LeapYearsChecker();

            var result = leapYearsChecker.Check(input);

            result.Should().BeFalse();
        }

        [TestCase("2008")]
        [TestCase("2012")]
        [TestCase("2016")]
        public void ReturnFalse_WhenCheckIsCalledWithYearDivisibleBy4ButNotBy100(string input)
        {
            var leapYearsChecker = new LeapYearsChecker();

            var result = leapYearsChecker.Check(input);

            result.Should().BeTrue();
        }

        [TestCase("2017")]
        [TestCase("2018")]
        [TestCase("2019")]
        public void ReturnFalse_WhenCheckIsCalledWithYearNotDivisibleBy4(string input)
        {
            var leapYearsChecker = new LeapYearsChecker();

            var result = leapYearsChecker.Check(input);

            result.Should().BeFalse();
        }
    }

    public class LeapYearsChecker
    {
        public bool Check(string input)
        {
            if (!int.TryParse(input, out var year))
                return false;

            if (year.IsDivisibleBy(400))
                return true;

            if (year.IsDivisibleBy(100) && !year.IsDivisibleBy(400))
                return false;

            if (year.IsDivisibleBy(4) && !year.IsDivisibleBy(100))
                return true;

            if (!year.IsDivisibleBy(4))
                return false;

            return true;
        }

        
    }

    public static class CustomExtensions
    {
        public static bool IsDivisibleBy(this int year, int divisor)
        {
            return year % divisor == 0;
        }
    }
}
