using System.Globalization;

namespace BrainTeasers;

public static class Dates
{
    public static bool IsLeapYear(DateTime date)
    {
        return  DateTime.IsLeapYear(date.Year);
    }

    public static bool IsDST(DateTime date)
    {
        //TODO: return true if the date is during Daylight Saving Time
        // How would you do this if the computer was in a different country?
        return false;
    }

    public static string HowManyHoursDifferenceToTokyoJapan(DateTimeOffset dateTimeOffset)
    {
        //TODO: return difference in hours between the current time and Tokyo, Japan
        return "16 hours";
    }
}
