using Xunit;

namespace LeetCode.Test.SolutionTests;

public class CountEvenUnitTest
{
    private readonly Solution _solution;

    public CountEvenUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(4, 2)]
    [InlineData(30, 14)]
    public void Test(int num, int expected)
    {
        var actual = _solution.CountEven(num);
        Assert.Equal(expected, actual);
    }
}