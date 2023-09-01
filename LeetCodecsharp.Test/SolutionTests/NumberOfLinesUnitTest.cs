// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class NumberOfLinesUnitTest
{
    [Theory]
    [InlineData(new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 },
        "abcdefghijklmnopqrstuvwxyz",
        new int[] { 3, 60 })]
    [InlineData(new int[] { 4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 },
        "bbbcccdddaaa",
        new int[] { 2, 4 })]
    public void MultipleDataTest(int[] widths, string s, int[] expected)
    {

        var actual = Solution.NumberOfLines(widths, s);
        Assert.Equal(expected, actual);
    }

}