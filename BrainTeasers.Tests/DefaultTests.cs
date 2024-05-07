using Xunit.Abstractions;

namespace BrainTeasers.Tests;

public class DefaultTests(ITestOutputHelper output)
{
    private readonly ITestOutputHelper _Output = output;

    [Fact]
    public void DefaultsQuiz()
    {
        // Assert
        //Uncomment each and make them pass
        Assert.Equal(0, default(int));
        Assert.Equal(0.0, default(double));
        Assert.Equal<float>(0.000000f, default(float));
        //Assert.Equal(foo, default(decimal));
        //Assert.Equal(foo, default(long));
        //Assert.Equal(foo, default(short));
        Assert.Equal<char>('\0', default(char));
        Assert.Equal<char?>(null, default(char?));
        Assert.Equal<string>(null, default(string));
        Assert.Equal<object>(null, default(object));
        //Assert.Equal(new DateTime(1974, 12, 31), default(DateTime));
        var thing = new DateTimeOffset(1974, 12, 31, 0, 0, 0, TimeSpan.Zero);
        DateTime DateTime = thing.DateTime;
        Assert.Equal(DateTime, thing);
        //Assert.Equal(foo, default(DateTime?));
        //Assert.Equal(foo, default(int?));

    }
}