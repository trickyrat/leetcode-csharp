﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class ComplexNumberMultiplyUnitTest
{
    [Theory]
    [InlineData("1+1i", "1+1i", "0+2i")]
    [InlineData("1+-1i", "1+-1i", "0+-2i")]
    public void MultipleDataTest(string num1, string num2, string expected)
    {
        var actual = Solution.ComplexNumberMultiply(num1, num2);
        Assert.Equal(expected, actual);
    }
}
