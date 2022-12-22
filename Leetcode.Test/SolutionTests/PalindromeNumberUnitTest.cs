// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class PalindromeNumberUnitTest
{
    private readonly Solution _solution;
    public PalindromeNumberUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    public void MultipleDataTest(int input, bool expected)
    {

        var actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }
}