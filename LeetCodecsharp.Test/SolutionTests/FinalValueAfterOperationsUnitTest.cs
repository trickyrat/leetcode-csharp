// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class FinalValueAfterOperationsUnitTest
{
    private readonly Solution _solution;

    public FinalValueAfterOperationsUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new string[] { "--X", "X++", "X++" }, 1)]
    [InlineData(new string[] { "++X", "++X", "X++" }, 3)]
    [InlineData(new string[] { "X++", "++X", "--X", "X--" }, 0)]
    public void Test(string[] operations, int expected)
    {
        var actual = _solution.FinalValueAfterOperations(operations);
        Assert.Equal(expected, actual);
    }
}