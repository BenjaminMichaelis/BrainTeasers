using System.Diagnostics;

using Xunit.Abstractions;

namespace BrainTeasers.Tests;

public class AsyncTests(ITestOutputHelper output)
{
    private readonly ITestOutputHelper _Output = output;

    [Fact]
    public async Task AsyncExceptionTest()
    {
        // Assert
        await Assert.ThrowsAnyAsync<Exception>(Async.AsyncOperation);
    }

    [Fact]
    public async Task CompressFasterTest()
    {
        var n = 100000;
        // Arrange
        byte[] buffer = [];
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < n; i++)
        {
            await Async.Compress(buffer);
        }
        stopwatch.Stop();
        _Output.WriteLine(stopwatch.ElapsedTicks.ToString());

        var stopwatch2 = new Stopwatch();
        stopwatch2.Start();
        for (int i = 0; i < n; i++)
        {
            // make this method to be faster than Compress
            await Async.CompressFaster(buffer);
        }
        stopwatch2.Stop();
        _Output.WriteLine(stopwatch2.ElapsedTicks.ToString());

        // Assert
        // at least 40% faster
        Assert.InRange(stopwatch2.ElapsedTicks, 0, stopwatch.ElapsedTicks - (stopwatch.ElapsedTicks * .4));

    }
}