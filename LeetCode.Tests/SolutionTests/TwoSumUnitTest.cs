// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class TwoSumUnitTest
{
    public static TheoryData<int[], int, int[]> Data
    {
        get
        {
            var data = new TheoryData<int[], int, int[]>
            {
                { [2, 7, 11, 15], 9, [0, 1] },
                { [3, 2, 4], 6, [1, 2] },
                { [3, 3], 6, [0, 1] }
            };
            return data;
        }
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void TwoSumTest(int[] nums, int target, int[] expected)
    {
        var actual = Solution.TwoSum(nums, target);
        Assert.Equal(expected, actual);
    }
}