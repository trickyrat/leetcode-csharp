// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class TitleToNumberUnitTest
{
    [Theory]
    [InlineData("A", 1)]
    [InlineData("AB", 28)]
    [InlineData("ZY", 701)]
    public void MultipleDataTest(string columnTitle, int expected)
    {
        var actual = Solution.TitleToNumber(columnTitle);
        Assert.Equal(expected, actual);
    }
}