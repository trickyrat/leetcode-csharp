// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.InterviewSolutionTests;

public class MagicIndexUnitTest
{
    public static TheoryData<int[], int> Data
    {
        get
        {
            var data = new TheoryData<int[], int>
            {
                { [0, 1, 2, 3, 4], 0 },
                { [0, 1, 3, 3, 4], 0 },
                { [0, 2, 3, 3, 4], 0 },
                { [1, 2, 2, 3, 4], 2 },
                { [1, 2, 3, 4, 4], 4 },
            };
            return data;
        }
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void MagicIndexTest1(int[] nums, int expected)
    {
        int actual = InterviewSolution.FindMagicIndex(nums);
        Assert.Equal(expected, actual);
    }
}