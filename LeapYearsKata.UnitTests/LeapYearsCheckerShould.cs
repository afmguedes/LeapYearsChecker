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
    }

    public class LeapYearsChecker
    {
        public bool Check(string input)
        {
            throw new NotImplementedException();
        }
    }
}
