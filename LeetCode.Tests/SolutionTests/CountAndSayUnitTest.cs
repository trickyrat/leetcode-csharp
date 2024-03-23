// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class CountAndSayUnitTest
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(4, "1211")]
    public void Test(int n, string expected)
    {
        var actual = Solution.CountAndSay(n);
        Assert.Equal(expected, actual);
    }
}
