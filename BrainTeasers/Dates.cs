using System.Globalization;

namespace BrainTeasers;

public static class Dates
{
    public static bool IsLeapYear(DateTime date)
    {
        //TODO: return true if the date is in a leap year
        return false;
    }

    public static bool IsDST(DateTime date)
    {
        //TODO: return true if the date is during Daylight Saving Time
        // How would you do this if the computer was in a different country?
        return false;
    }

    public static DateTime TimeInTokyoJapan()
    {
        //TODO: return the current time in Tokyo, Japan
        return DateTime.UtcNow;
    }
}
