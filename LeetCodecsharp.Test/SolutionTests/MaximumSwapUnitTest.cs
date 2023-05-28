// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MaximumSwapUnitTest
{
    private readonly Solution _solution;

    public MaximumSwapUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(2736, 7236)]
    [InlineData(9973, 9973)]
    public void Test(int num, int expected)
    {
        var actual = _solution.MaximumSwap(num);
        Assert.Equal(expected, actual);
    }
}