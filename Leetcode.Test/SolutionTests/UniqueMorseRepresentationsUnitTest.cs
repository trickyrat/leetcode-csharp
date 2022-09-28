// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class UniqueMorseRepresentationsUnitTest

{
    private readonly Solution _solution;
    public UniqueMorseRepresentationsUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new string[] { "gin", "zen", "gig", "msg" }, 2)]
    [InlineData(new string[] { "a" }, 1)]
    public void MultipleDataTest(string[] words, int expected)
    {
        var actual = _solution.UniqueMorseRepresentations(words);
        Assert.Equal(expected, actual);
    }
}