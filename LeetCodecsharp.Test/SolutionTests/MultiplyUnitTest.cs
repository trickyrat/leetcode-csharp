// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MultiplyUnitTest
{
    [Theory]
    [InlineData("2", "3", "6")]
    [InlineData("123", "456", "56088")]
    public void MultipleDataTest(string num1, string num2, string expected)
    {
        var actual = Solution.Multiply(num1, num2);
        Assert.Equal(expected, actual);
    }

}