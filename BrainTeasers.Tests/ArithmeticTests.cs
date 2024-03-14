namespace BrainTeasers.Tests;

public class ArithmeticTests
{
    [Fact]
    public void SubtractionArithmaticTest()
    {
        // Assert
        Assert.InRange(Arithmetic.SubtractionArithmatic(), 1.0, 1.0);
    }
}