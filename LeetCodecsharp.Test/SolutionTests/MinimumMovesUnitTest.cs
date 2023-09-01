// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class MinimumMovesUnitTest
{
    [Theory]
    [InlineData("XXX", 1)]
    [InlineData("XXOX", 2)]
    [InlineData("OOOO", 0)]
    public void MultipleDataTest(string s, int expected)
    {
        var actual = Solution.MinimumMoves(s);
        Assert.Equal(expected, actual);
    }

}


