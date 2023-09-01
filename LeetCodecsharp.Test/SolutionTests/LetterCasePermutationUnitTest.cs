// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class LetterCasePermutationUnitTest
{
    [Theory]
    [InlineData("a1b2", new string[] { "a1b2", "A1b2", "a1B2", "A1B2" })]
    [InlineData("3z4", new string[] { "3z4", "3Z4" })]
    public void Test(string input, string[] expected)
    {
        var actual = Solution.LetterCasePermutation(input);
        Assert.Equal(expected, actual);
    }
}
