// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class CountAndSayUnitTest
{
    private readonly Solution _solution;

    public CountAndSayUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(1, "1")]
    [InlineData(4, "1211")]
    public void Test(int n, string expected)
    {
        var actual = _solution.CountAndSay(n);
        Assert.Equal(expected, actual);
    }
}
