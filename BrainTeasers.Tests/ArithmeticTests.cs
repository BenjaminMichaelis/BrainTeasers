namespace BrainTeasers.Tests;

public class ArithmeticTests
{
    [Fact]
    public void SubtractionArithmaticTest()
    {
        // Assert
        Assert.InRange(SubtractionArithmatic(), (decimal)1.0, (decimal)1.0);
        //Assert.Equal(1.0, SubtractionArithmatic());
    }

    public static decimal SubtractionArithmatic()
    {
        decimal d1 = 1.000001m;
        decimal d2 = 0.000001m;
        return (d1 - d2);
    }
}