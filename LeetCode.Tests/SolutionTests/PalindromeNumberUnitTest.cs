﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class PalindromeNumberUnitTest
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    public void MultipleDataTest(int input, bool expected)
    {

        var actual = Solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }
}