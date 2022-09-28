// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace Leetcode.Test.SolutionTests;
public class PermuteUnitTest
{
    private readonly Solution _solution;

    public PermuteUnitTest()
    {
        _solution = new Solution();
    }

    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            new int[]{ 1,2,3},
            new List<IList<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 1, 3, 2 },
                new List<int> { 3, 1, 2 },
                new List<int> { 2, 1, 3 },
                new List<int> { 2, 3, 1 },
                new List<int> { 3, 2, 1 }
            }
        };

        yield return new object[]
        {
            new int[]{ 0, 1 },
            new List<IList<int>>
            {
                new List<int> { 0, 1 },
                new List<int> { 1, 0 }
            }
        };

        yield return new object[]
        {
            new int[]{ 1 },
            new List<IList<int>>
            {
                new List<int> { 1 }
            }
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, IList<IList<int>> expected)
    {
        var actual = _solution.Permute(nums);
        Assert.Equal(expected, actual);
    }
}

