// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class MinimumTotalUnitTest
{
    private readonly Solution _solution;
    public MinimumTotalUnitTest()
    {
        _solution = new Solution();
    }
    [Fact]
    public void Test()
    {
        IList<IList<int>> data = new List<IList<int>>
        {
            new List<int>{ 2 },
            new List<int>{ 3, 4 },
            new List<int>{ 6, 5, 7 },
            new List<int>{ 4, 1, 8, 3 },
        };
        var actual = _solution.MinimumTotal(data);
        var expected = 11;
        Assert.Equal(expected, actual);
    }
}
