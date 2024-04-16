namespace LeetCode.Tests;

public class ZeroEvenOddUnitTest
{
    public static TheoryData<int, string> Data =>
        new()
        {
            {1, "01" },
            {2, "0102" },
            {5, "0102030405" }
        };

    [Theory]
    [MemberData(nameof(Data))]
    public async Task Test(int n, string expected)
    {
        var zeroEvenOdd = new ZeroEvenOdd(n);
        var actual = "";
        var zeroTask = Task.Run(() => zeroEvenOdd.Zero((int n) => actual += n));
        var evenTask = Task.Run(() => zeroEvenOdd.Even((int n) => actual += n));
        var oddTask = Task.Run(() => zeroEvenOdd.Odd((int n) => actual += n));

        await Task.WhenAll(zeroTask, evenTask, oddTask);

        Assert.Equal(expected, actual);
    }
}
