// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class IsPalindromeUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 2, 2, 1 }, true
        ];

        yield return
        [
            new[] { 1, 2 }, false
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] nums, bool expected)
    {
        var head = Util.CreateListNode(nums);
        var actual = Solution.IsPalindrome(head);
        Assert.Equal(expected, actual);
    }
}