// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MinDeletionSizeUnitTest
{
    [Theory]
    [InlineData(new string[] { "cba", "daf", "ghi" }, 1)]
    [InlineData(new string[] { "a", "b" }, 0)]
    [InlineData(new string[] { "zyx", "wvu", "tsr" }, 3)]
    public void MultipleDataTest(string[] strs, int expected)
    {
        var actual = Solution.MinDeletionSize(strs);
        Assert.Equal(expected, actual);
    }

}