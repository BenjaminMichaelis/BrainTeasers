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
        // Arrange

        Assert.Equal(Dates.TimeInTokyoJapan().ToShortTimeString(), DateTime.UtcNow.AddHours(9).ToShortTimeString());

    }
}