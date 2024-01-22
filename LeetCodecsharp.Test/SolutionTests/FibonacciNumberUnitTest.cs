using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class FibonacciNumberUnitTest
{
    [Theory]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    public void Test(int n, int expected)
    {
        var actual = Solution.Fib(n);
        Assert.Equal(expected, actual);
    }
}