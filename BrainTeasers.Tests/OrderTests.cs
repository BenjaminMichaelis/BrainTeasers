namespace BrainTeasers.Tests;

public class OrderTests
{
    [Fact]
    public void CallTheOverriddenMethod()
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        Derived d = new();
        int i = 10;
        d.Foo(10);
        Assert.Equal("Derived.Foo(int)\r\n", stringWriter.ToString());
    }
}
class Base
{
    public virtual void Foo(int x)
    {
        Console.WriteLine("Base.Foo(int)");
    }
}

class Derived : Base
{
    public override void Foo(int x)
    {
        Console.WriteLine("Derived.Foo(int)");
    }

    public void Foo(object o)
    {
        Console.WriteLine("Derived.Foo(object)");
    }
}
