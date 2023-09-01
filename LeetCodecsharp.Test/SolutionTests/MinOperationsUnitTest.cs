// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MinOperationsUnitTest
{
    [Theory]
    [InlineData(new string[] { "d1/", "d2/", "../", "d21/", "./" }, 2)]
    [InlineData(new string[] { "d1/", "d2/", "./", "d3/", "../", "d31/" }, 3)]
    [InlineData(new string[] { "d1/", "../", "../", "../" }, 0)]
    public void Test(string[] logs, int expected)
    {
        var actual = Solution.MinOperations(logs);
        Assert.Equal(expected, actual);
    }
}