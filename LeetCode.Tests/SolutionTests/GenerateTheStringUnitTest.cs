// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Tests.SolutionTests;
public class GenerateTheStringUnitTest
{
    [Theory]
    [InlineData(4, "aaab")]
    [InlineData(2, "ab")]
    [InlineData(3, "aaa")]
    public void MultipleDataTest(int input, string expected)
    {
        var actual = Solution.GenerateTheString(input);
        Assert.Equal(expected, actual);
    }
}

