// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using LeetCode.DataStructure;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class NumComponentsUnitTest
{
    private readonly Solution _solution;

    public NumComponentsUnitTest()
    {
        _solution = new Solution();
    }

    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            Utilities.CreateListNode(new int[]{ 0, 1, 2, 3 }),
            new int[]{ 0, 1, 3 },
            2
        };
        yield return new object[]
        {
            Utilities.CreateListNode(new int[]{ 0, 1, 2, 3, 4 }),
            new int[]{ 0, 3, 1, 4 },
            2
        };

    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(ListNode head, int[] nums, int expected)
    {
        var actual = _solution.NumComponents(head, nums);
        Assert.Equal(expected, actual);
    }

}

