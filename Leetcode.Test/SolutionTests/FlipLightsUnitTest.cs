using Xunit;

namespace Leetcode.Test.SolutionTests;

public class FlipLightsUnitTest
{
    private readonly Solution _solution;

    public FlipLightsUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(2, 1, 3)]
    [InlineData(3, 1, 4)]
    public void Test(int n, int presses, int expected)
    {
        var actual = _solution.FlipLights(n, presses);
        Assert.Equal(expected, actual);
    }

}