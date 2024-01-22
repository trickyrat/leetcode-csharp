// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MinMove2UnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 2, 3 }, 2
        ];

        yield return
        [
            new[] { 1, 10, 2, 9 }, 16
        ];
    }
    
    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = Solution.MinMove2(nums);
        Assert.Equal(expected, actual);
    }

}