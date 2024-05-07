namespace BrainTeasers.Tests;

public class StaticConstructorTests
{
    private static int _refCount;

    [Fact]
    public void CallsStaticConstructorTwice()
    {
        InstanceCounter<string> a = new();
        InstanceCounter<int> b = new();
        //TODO: Write code that makes the following assertion pass
        Assert.Equal(2, _refCount);
    }

    private class InstanceCounter<T>
    {
        static InstanceCounter()
        {
            _refCount++;
        }
    }
}