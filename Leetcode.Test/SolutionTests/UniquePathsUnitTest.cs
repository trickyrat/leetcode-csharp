// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;
public class UniquePathsUnitTest
{
    private readonly Solution _solution;

    public UniquePathsUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(3, 7, 28)]
    [InlineData(3, 2, 3)]
    public void MultipleDataTest(int m, int n, int expected)
    {
        var actual = _solution.UniquePaths(m, n);
        Assert.Equal(expected, actual);
    }
}

