// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class TwoOutOfThreeUnitTest
{
    public static TheoryData<int[], int[], int[], IList<int>> Data => new()
    {
        { [1, 1, 3, 2], [2, 3], [3], [3, 2] },
        { [3, 1], [2, 3], [1, 2], [2, 3, 1] },
        { [1, 2, 2], [4, 3, 3], [5], [] }
    };

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int[] nums1, int[] nums2, int[] nums3, IList<int> expected)
    {
        var actual = Solution.TwoOutOfThree(nums1, nums2, nums3);
        actual = actual.OrderBy(x => x).ToList();
        expected = expected.OrderBy(x => x).ToList();
        Assert.Equal(expected, actual);
    }
}