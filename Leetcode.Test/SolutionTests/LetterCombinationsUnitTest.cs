// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class LetterCombinationsUnitTest
{
    private readonly Solution _solution;
    public LetterCombinationsUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData("23", new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
    [InlineData("", new string[] { })]
    [InlineData("2", new string[] { "a", "b", "c" })]
    public void MultipleDataTest(string digits, string[] expected)
    {

        var actual = _solution.LetterCombinations(digits);
        Assert.Equal(expected, actual);
    }
}