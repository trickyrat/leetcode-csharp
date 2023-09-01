// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class FinalValueAfterOperationsUnitTest
{
    [Theory]
    [InlineData(new string[] { "--X", "X++", "X++" }, 1)]
    [InlineData(new string[] { "++X", "++X", "X++" }, 3)]
    [InlineData(new string[] { "X++", "++X", "--X", "X--" }, 0)]
    public void Test(string[] operations, int expected)
    {
        var actual = Solution.FinalValueAfterOperations(operations);
        Assert.Equal(expected, actual);
    }
}