using LeapYearsKata.Helpers;

namespace LeapYearsKata
{
    public class LeapYearsChecker
    {
        public bool Check(string input)
        {
            if (!int.TryParse(input, out var year))
                return false;

            //if (year.IsDivisibleBy(400))
            //    return true;

            //if (year.IsDivisibleBy(100) && !year.IsDivisibleBy(400))
            //    return false;

            //if (year.IsDivisibleBy(4) && !year.IsDivisibleBy(100))
            //    return true;

            //if (!year.IsDivisibleBy(4))
            //    return false;

            if (year.IsDivisibleBy(400) || (year.IsDivisibleBy(4) && !year.IsDivisibleBy(100)))
                return true;

            return false;
        }
    }
}