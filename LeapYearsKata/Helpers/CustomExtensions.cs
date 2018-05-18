namespace LeapYearsKata.Helpers
{
    public static class CustomExtensions
    {
        public static bool IsDivisibleBy(this int year, int divisor)
        {
            return year % divisor == 0;
        }
    }
}