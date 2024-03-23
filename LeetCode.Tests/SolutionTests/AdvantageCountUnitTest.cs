// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class AdvantageCountUnitTest
{
    public static TheoryData<int[], int[], int[]> Data
    {
        get
        {
            var data = new TheoryData<int[], int[], int[]>
            {
                { [2, 7, 11, 15], [1, 10, 4, 11], [2, 11, 7, 15] },
                { [12, 24, 8, 32], [13, 25, 32, 11], [24, 32, 8, 12] }
            };
            return data;
        }
    }


    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int[] nums1, int[] nums2, int[] expected)
    {
        var actual = Solution.AdvantageCount(nums1, nums2);
        Assert.Equal(expected, actual);
    }
}