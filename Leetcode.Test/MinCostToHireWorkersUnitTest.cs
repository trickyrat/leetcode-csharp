using System;
using Xunit;

namespace Leetcode.Test;

public class MinCostToHireWorkersUnitTest
{
    private readonly Solution _solution;

    public MinCostToHireWorkersUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] {10, 20, 5}, new int[] {70, 50, 30}, 2, 105.00000)]
    [InlineData(new int[] {3, 1, 10, 10, 1}, new int[] {4, 8, 2, 2, 7}, 3, 30.66667)]
    public void Test(int[] quality, int[] wage, int k, double expected)
    {
        var actual = _solution.MinCostToHireWorkers(quality, wage, k);
        actual = Math.Round(actual, 5);
        Assert.Equal(expected, actual);
    }
}