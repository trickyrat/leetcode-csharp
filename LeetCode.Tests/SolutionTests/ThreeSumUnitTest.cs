// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class ThreeSumUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { -1, 0, 1, 2, -1, -4 },
            new int[][]
            {
                [-1, -1, 2],
                [-1, 0, 1]
            }
        ];

        yield return
        [
            Array.Empty<int>(),
            Array.Empty<int[]>()
        ];

        yield return
        [
            new[] { 0 },
            Array.Empty<int[]>()
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, IList<IList<int>> expected)
    {

        var actual = Solution.ThreeSum(nums);
        Assert.Equal(expected, actual);
    }
}