using Xunit.Abstractions;

namespace BrainTeasers.Tests;

public class DateTimeTests(ITestOutputHelper output)
{
    private readonly ITestOutputHelper _Output = output;

    [Fact]
    public void IsLeapYearTest()
    {
        // Assert
        Assert.True(Dates.IsLeapYear(new DateTime(2024, 1, 1)));
        Assert.False(Dates.IsLeapYear(new DateTime(2023, 1, 1)));
        Assert.False(Dates.IsLeapYear(new DateTime(2021, 1, 1)));
        Assert.True(Dates.IsLeapYear(new DateTime(2000, 1, 1)));
    }

    [Fact]
    public void IsDST()
    {
        Assert.False(Dates.IsDST(new DateTime(2024, 1, 1)));
        Assert.False(Dates.IsDST(new DateTime(2024, 3, 1)));
        Assert.True(Dates.IsDST(new DateTime(2024, 4, 1)));
        Assert.True(Dates.IsDST(new DateTime(2024, 10, 1)));
    }

    [Fact]
    public void TimeInTokyoJapan()
    {
        Assert.Equal("16 hours", Dates.HowManyHoursDifferenceToTokyoJapan(DateTimeOffset.Now));
        Assert.Equal("9 hours", Dates.HowManyHoursDifferenceToTokyoJapan(DateTimeOffset.Now.ToOffset(TimeSpan.FromHours(0))));
        Assert.Equal("5 hours", Dates.HowManyHoursDifferenceToTokyoJapan(DateTimeOffset.Now.ToOffset(TimeSpan.FromHours(4))));
        Assert.Equal("0 hours", Dates.HowManyHoursDifferenceToTokyoJapan(DateTimeOffset.Now.ToOffset(TimeSpan.FromHours(9))));
        Assert.Equal("-5 hours", Dates.HowManyHoursDifferenceToTokyoJapan(DateTimeOffset.Now.ToOffset(TimeSpan.FromHours(14))));
    }
}