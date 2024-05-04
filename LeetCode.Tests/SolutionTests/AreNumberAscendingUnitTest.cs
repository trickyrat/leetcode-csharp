﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;
public class AreNumberAscendingUnitTest
{
    [Theory]
    [InlineData("1 box has 3 blue 4 red 6 green and 12 yellow marbles", true)]
    [InlineData("hello world 5 x 5", false)]
    [InlineData("sunset is at 7 51 pm overnight lows will be in the low 50 and 60 s", false)]
    public void MultipleDataTest(string s, bool expected)
    {
        var actual = Solution.AreNumberAscending(s);
        Assert.Equal(expected, actual);
    }

}