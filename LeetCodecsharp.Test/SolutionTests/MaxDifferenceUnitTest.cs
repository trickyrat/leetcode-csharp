// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MaxDifferenceUnitTest
{
    [Theory]
    [InlineData(new int[] { 7, 1, 5, 4 }, 4)]
    [InlineData(new int[] { 9, 4, 3, 2 }, -1)]
    [InlineData(new int[] { 1, 5, 2, 10 }, 9)]
    public void Test(int[] input, int expected)
    {

        var actual = Solution.MaximumDifference(input);
        Assert.Equal(expected, actual);
    }
}