namespace LeetCode;

public class FooBar
{
    private int _n;
    private readonly AutoResetEvent _foo = new(true);
    private readonly AutoResetEvent _bar = new(false);

    public FooBar(int n)
    {
        _n = n;
    }

    public void Foo(Action printFoo)
    {
        for (int i = 0; i < _n; i++)
        {
            _foo.WaitOne();
            printFoo();
            _bar.Set();
        }
    }

    public void Bar(Action printBar)
    {
        for (int i = 0; i < _n; i++)
        {
            _bar.WaitOne();
            printBar();
            _foo.Set();
        }
    }
}
