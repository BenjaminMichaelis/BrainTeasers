namespace BrainTeasers.Tests;

public class OrderMatters
{
    [Fact]
    public void CallsStaticConstructorTwice()
    {
        // I call Foo then Bar
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        _ = new Foo();
        _ = new Bar();
        int j = Bar.i;
        Assert.Equal("Foo\r\nBar\r\n", stringWriter.ToString());
    }
}
class Foo
{
    static Foo()
    {
        Console.WriteLine("Foo");
    }
}

class Bar
{
    public static int i = Init();

    static int Init()
    {
        Console.WriteLine("Bar");
        return 0;
    }
}
