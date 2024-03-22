// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class MaximumWealthUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new int[][]
            {
                [1,2,3],
                [3,2,1]
            },
            6
        ];
        yield return
        [
            new int[][]
            {
                [1,5],
                [7,3],
                [3,5]
            },
            10
        ];
        yield return
        [
            new int[][]
            {
                [2,8,7],
                [7,1,3],
                [1,9,5],
            },
           17
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[][] accounts, int expected)
    {

        var actual = Solution.MaximumWealth(accounts);
        Assert.Equal(expected, actual);
    }
}