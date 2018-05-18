using FluentAssertions;
using NUnit.Framework;

namespace LeapYearsKata.UnitTests
{
    [TestFixture]
    public class LeapYearsCheckerShould
    {
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

        [TestCase("1804")]
        [TestCase("1808")]
        [TestCase("1812")]
        [TestCase("1816")]
        [TestCase("1820")]
        [TestCase("1824")]
        [TestCase("1828")]
        [TestCase("1832")]
        [TestCase("1836")]
        [TestCase("1840")]
        [TestCase("1844")]
        [TestCase("1848")]
        [TestCase("1852")]
        [TestCase("1856")]
        [TestCase("1860")]
        [TestCase("1864")]
        [TestCase("1868")]
        [TestCase("1872")]
        [TestCase("1876")]
        [TestCase("1880")]
        [TestCase("1884")]
        [TestCase("1888")]
        [TestCase("1892")]
        [TestCase("1896")]
        [TestCase("1904")]
        [TestCase("1908")]
        [TestCase("1912")]
        [TestCase("1916")]
        [TestCase("1920")]
        [TestCase("1924")]
        [TestCase("1928")]
        [TestCase("1932")]
        [TestCase("1936")]
        [TestCase("1940")]
        [TestCase("1944")]
        [TestCase("1948")]
        [TestCase("1952")]
        [TestCase("1956")]
        [TestCase("1960")]
        [TestCase("1964")]
        [TestCase("1968")]
        [TestCase("1972")]
        [TestCase("1976")]
        [TestCase("1980")]
        [TestCase("1984")]
        [TestCase("1988")]
        [TestCase("1992")]
        [TestCase("1996")]
        [TestCase("2000")]
        [TestCase("2004")]
        [TestCase("2008")]
        [TestCase("2012")]
        [TestCase("2016")]
        [TestCase("2020")]
        [TestCase("2024")]
        [TestCase("2028")]
        [TestCase("2032")]
        [TestCase("2036")]
        [TestCase("2040")]
        [TestCase("2044")]
        [TestCase("2048")]
        [TestCase("2052")]
        [TestCase("2056")]
        [TestCase("2060")]
        [TestCase("2064")]
        [TestCase("2068")]
        [TestCase("2072")]
        [TestCase("2076")]
        [TestCase("2080")]
        [TestCase("2084")]
        [TestCase("2088")]
        [TestCase("2092")]
        [TestCase("2096")]
        [TestCase("2104")]
        [TestCase("2108")]
        [TestCase("2112")]
        [TestCase("2116")]
        [TestCase("2120")]
        [TestCase("2124")]
        [TestCase("2128")]
        [TestCase("2132")]
        [TestCase("2136")]
        [TestCase("2140")]
        [TestCase("2144")]
        [TestCase("2148")]
        [TestCase("2152")]
        [TestCase("2156")]
        [TestCase("2160")]
        [TestCase("2164")]
        [TestCase("2168")]
        [TestCase("2172")]
        [TestCase("2176")]
        [TestCase("2180")]
        [TestCase("2184")]
        [TestCase("2188")]
        [TestCase("2192")]
        [TestCase("2196")]
        [TestCase("2204")]
        [TestCase("2208")]
        [TestCase("2212")]
        [TestCase("2216")]
        [TestCase("2220")]
        [TestCase("2224")]
        [TestCase("2228")]
        [TestCase("2232")]
        [TestCase("2236")]
        [TestCase("2240")]
        [TestCase("2244")]
        [TestCase("2248")]
        [TestCase("2252")]
        [TestCase("2256")]
        [TestCase("2260")]
        [TestCase("2264")]
        [TestCase("2268")]
        [TestCase("2272")]
        [TestCase("2276")]
        [TestCase("2280")]
        [TestCase("2284")]
        [TestCase("2288")]
        [TestCase("2292")]
        [TestCase("2296")]
        [TestCase("2304")]
        [TestCase("2308")]
        [TestCase("2312")]
        [TestCase("2316")]
        [TestCase("2320")]
        [TestCase("2324")]
        [TestCase("2328")]
        [TestCase("2332")]
        [TestCase("2336")]
        [TestCase("2340")]
        [TestCase("2344")]
        [TestCase("2348")]
        [TestCase("2352")]
        [TestCase("2356")]
        [TestCase("2360")]
        [TestCase("2364")]
        [TestCase("2368")]
        [TestCase("2372")]
        [TestCase("2376")]
        [TestCase("2380")]
        [TestCase("2384")]
        [TestCase("2388")]
        [TestCase("2392")]
        [TestCase("2396")]
        [TestCase("2400")]
        public void TestRandomYears(string input)
        {
            var leapYearsChecker = new LeapYearsChecker();

            var result = leapYearsChecker.Check(input);

            result.Should().BeTrue();
        }

        [Test]
        public void ReturnFalse_WhenCheckIsCalledWithEmptyString()
        {
            var input = string.Empty;
            var leapYearsChecker = new LeapYearsChecker();

            var result = leapYearsChecker.Check(input);

            result.Should().BeFalse();
        }
    }
}