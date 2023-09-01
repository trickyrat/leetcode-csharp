// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class ReformatUnitTest
{
    [Theory]
    [InlineData("a0b1c2", "a0b1c2")]
    [InlineData("leetcode", "")]
    [InlineData("1229857369", "")]
    public void MultipleDataTest(string input, string expected)
    {
        var actual = Solution.Reformat(input);
        Assert.Equal(expected, actual);
    }
}

