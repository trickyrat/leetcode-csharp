// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;
public class PreimageSizeFZFUnitTest
{
    private readonly Solution _solution;

    public PreimageSizeFZFUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, 0)]
    [InlineData(3, 5)]
    public void MultipleDataTest(int k, int expected)
    {
        var actual = _solution.PreimageSizeFZF(k);
        Assert.Equal(expected, actual);
    }
}

