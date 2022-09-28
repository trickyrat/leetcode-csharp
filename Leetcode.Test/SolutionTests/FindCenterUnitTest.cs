// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class FindCenterUnitTest
{
    private readonly Solution _solution;

    public FindCenterUnitTest()
    {
        _solution = new Solution();
    }
    public static IEnumerable<object[]> GetEdges()
    {
        yield return new object[]
        {
            (new int[][]
            {
                new int[]{1,2 },
                new int[]{2,3 },
                new int[]{4,2 },
            }, 2)
        };
        yield return new object[]
        {
            (new int[][]
            {
                new int[]{1,2 },
                new int[]{5,1 },
                new int[]{1,3 },
                new int[]{1,4 },
            }, 1)
        };

    }


    [Theory]
    [MemberData(nameof(GetEdges))]
    public void Test((int[][] edges, int expected) input)
    {
        var actual = _solution.FindCenter(input.edges);
        Assert.Equal(input.expected, actual);
    }
}
