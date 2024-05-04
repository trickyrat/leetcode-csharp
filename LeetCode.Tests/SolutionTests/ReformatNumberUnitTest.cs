﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;
public class ReformatNumberUnitTest
{
    [Theory]
    [InlineData("1-23-45 6", "123-456")]
    [InlineData("123 4-567", "123-45-67")]
    [InlineData("123 4-5678", "123-456-78")]
    public void MultipleDataTest(string number, string expected)
    {
        var actual = Solution.ReformatNumber(number);
        Assert.Equal(expected, actual);
    }
}

