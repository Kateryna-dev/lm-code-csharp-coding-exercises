using System;
namespace Exercises
{
    public class Exercise004
    {
        // Gigasecond is 10^9 (1,000,000,000) seconds
        const int GIGA_SECOND = 1000000000;
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            // To prevent overflow
            if (dateTime > DateTime.MaxValue.AddSeconds(-GIGA_SECOND))
            {
                throw new ArgumentException("DateTime is too big");
            }

            return dateTime.AddSeconds(GIGA_SECOND);
        }
    }
}
