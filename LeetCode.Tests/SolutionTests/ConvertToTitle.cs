// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class ConvertToTitle
{
    [Theory]
    [InlineData(1, "A")]
    [InlineData(28, "AB")]
    [InlineData(701, "ZY")]
    public void MultipleDataTest(int columnNumber, string expected)
    {
        var actual = Solution.ConvertToTitle(columnNumber);
        Assert.Equal(expected, actual);
    }
}