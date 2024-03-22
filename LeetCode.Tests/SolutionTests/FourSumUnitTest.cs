// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class FourSumUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1,0,-1,0,-2,2 },
            0,
            new int[][]
            {
                [-2, -1, 1, 2],
                [-2, 0, 0, 2],
                [-1, 0, 0, 1]
            }
        ];
        yield return
        [
            new[] { 2,2,2,2,2 },
             8,
             new int[][]
             {
                 [2,2,2,2],
             }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, int target, IList<IList<int>> expected)
    {
        var actual = Solution.FourSum(nums, target);
        Assert.Equal(expected, actual);
    }

}