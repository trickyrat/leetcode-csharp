// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;
public class ValidateStackSequencesUnitTest
{
    private readonly Solution _solution;

    public ValidateStackSequencesUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 2, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 3, 5, 1, 2 }, false)]
    public void MultipleDataTest(int[] pushed, int[] popped, bool expected)
    {
        var actual = _solution.ValidateStackSequences(pushed, popped);
        Assert.Equal(expected, actual);
    }
}

