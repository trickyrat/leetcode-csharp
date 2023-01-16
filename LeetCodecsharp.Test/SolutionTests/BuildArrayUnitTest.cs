using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class BuildArrayUnitTest
{
    private readonly Solution _solution;

    public BuildArrayUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] {1, 3}, 3, new string[] {"Push", "Push", "Pop", "Push"})]
    [InlineData(new int[] {1, 2, 3}, 3, new string[] {"Push", "Push", "Push"})]
    [InlineData(new int[] {1, 2}, 4, new string[] {"Push", "Push"})]
    public void Test(int[] targets, int n, IList<string> expected)
    {
        var actual = _solution.BuildArray(targets, n);
        Assert.Equal(expected, actual);
    }
}