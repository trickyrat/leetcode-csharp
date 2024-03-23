// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class HammingWeightUnitTest
{
    [Theory]
    [InlineData(11, 3)]
    [InlineData(128, 1)]
    [InlineData(4294967293, 31)]
    public void Test(uint n, int expected)
    {

        var actual = Solution.HammingWeight(n);
        Assert.Equal(expected, actual);
    }
}
