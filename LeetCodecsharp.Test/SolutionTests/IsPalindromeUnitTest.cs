// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class IsPalindromeUnitTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 2, 1 }, true)]
    [InlineData(new int[] { 1, 2 }, false)]
    public void Test(int[] nums, bool expected)
    {

        var head = Util.CreateListNode(nums);
        var actual = Solution.IsPalindrome(head);
        Assert.Equal(expected, actual);
    }
}
