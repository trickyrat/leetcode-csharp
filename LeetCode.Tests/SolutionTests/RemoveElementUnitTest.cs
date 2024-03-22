// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class RemoveElementUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new int[] { 3, 2, 2, 3 }, 3, 2
        ];
        yield return
        [
            new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5
        ];
    }
    
    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, int value, int expected)
    {
        var actual = Solution.RemoveElement(nums, value);
        Assert.Equal(expected, actual);
    }
}