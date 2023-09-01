// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class ReorderSpacesUnitTest
{
    [Theory]
    [InlineData("  this   is  a sentence ", "this   is   a   sentence")]
    [InlineData(" practice   makes   perfect", "practice   makes   perfect ")]
    [InlineData(" practice  ", "practice   ")]
    public void MultipleDataTest(string text, string expected)
    {
        var actual = Solution.ReorderSpaces(text);
        Assert.Equal(expected, actual);
    }
}

