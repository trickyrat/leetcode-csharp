namespace LeetCode.Tests.SolutionTests;

public class FooBarUnitTest
{
    public static TheoryData<int, string> Data =>
        new()
        {
            { 1, "foobar" },
            { 2, "foobarfoobar" },
            { 4, "foobarfoobarfoobarfoobar" },
        };


    [Theory]
    [MemberData(nameof(Data))]
    public async Task Test(int n, string expected)
    {
        var foobar = new FooBar(n);
        string actual = "";

        var fooTask = Task.Run(() => foobar.Foo(() => actual += "foo"));
        var barTask = Task.Run(() => foobar.Bar(() => actual += "bar"));
        await Task.WhenAll(fooTask, barTask);

        Assert.Equal(expected, actual);
    }
}
