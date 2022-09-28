using Xunit;

namespace Leetcode.Test.SolutionTests;

public class FinalPricesUnitTest
{
    private readonly Solution _solution;

    public FinalPricesUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(new int[] { 8, 4, 6, 2, 3 }, new int[] { 4, 2, 4, 2, 3 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 10, 1, 1, 6 }, new int[] { 9, 0, 1, 6 })]
    public void Test(int[] prices, int[] expected)
    {
        var actual = _solution.FinalPrices(prices);
        Assert.Equal(expected, actual);
    }
}