namespace BrainTeasers.Tests;

public class ArithmeticTests
{
    [Fact]
    public void SubtractionArithmaticTest()
    {
        // Assert
        Assert.InRange(SubtractionArithmatic(), 1.0, 1.0);
    }

    public static double SubtractionArithmatic()
    {
        double d1 = 1.000001;
        double d2 = 0.000001;
        return (d1 - d2);
    }
}