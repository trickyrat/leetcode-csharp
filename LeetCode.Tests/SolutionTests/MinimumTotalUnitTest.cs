﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class MinimumTotalUnitTest
{
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
        var actual = Solution.MinimumTotal(data);
        const int expected = 11;
        Assert.Equal(expected, actual);
    }
}
